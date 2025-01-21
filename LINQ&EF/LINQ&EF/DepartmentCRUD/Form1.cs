using DepartmentCRUD.Models;

namespace DepartmentCRUD
{
    public partial class Form1 : Form
    {
        int id;
        ITIContext db;
        public Form1()
        {
            InitializeComponent();
            db = new ITIContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var department = db.Departments.Select(dept => new
            {
                dept.Dept_Id,
                dept.Dept_Name,
                dept.Dept_Desc,
                dept.Dept_Location,
                dept.Dept_Manager,
                dept.Manager_hiredate
            }).ToList();
            id = department.Last().Dept_Id;

            dgv_dept.DataSource = department;
            cb_manager.DataSource = db.Instructors.ToList();
            cb_manager.DisplayMember = "Ins_Name";
            cb_manager.ValueMember = "Ins_Id";
            

            dgv_dept.Columns["Dept_Id"].Visible = false;

        }

        private void dgv_dept_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_dept.SelectedRows[0].Cells[0].Value;
            var department = db.Departments.Where(dept => dept.Dept_Id == id).SingleOrDefault();

            txt_name.Text = department.Dept_Name;
            txt_desc.Text = department.Dept_Desc;
            txt_loc.Text = department.Dept_Location;
            cb_manager.SelectedValue = department.Dept_Manager;
            dt_hiringDate.Value = (DateTime)department.Manager_hiredate;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                Dept_Id = ++id,
                Dept_Name = txt_name.Text,
                Dept_Desc = txt_desc.Text,
                Dept_Location = txt_loc.Text,
                Dept_Manager = (int)cb_manager.SelectedValue,
                Manager_hiredate = dt_hiringDate.Value,
            };

            db.Departments.Add(department);
            db.SaveChanges();

            txt_name.Text = txt_desc.Text = txt_loc.Text = "";
            dgv_dept.DataSource = db.Departments.Select(dept => new
            {
                dept.Dept_Id,
                dept.Dept_Name,
                dept.Dept_Desc,
                dept.Dept_Location,
                dept.Dept_Manager,
                dept.Manager_hiredate
            }).ToList();

            MessageBox.Show($"department {department.Dept_Name} with id:{department.Dept_Id} added successfully");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Department dept = db.Departments.Where(dept => dept.Dept_Id == id).SingleOrDefault();
            dept.Dept_Name = txt_name.Text;
            dept.Dept_Desc = txt_desc.Text;
            dept.Dept_Location = txt_loc.Text;
            dept.Dept_Manager = (int)cb_manager.SelectedValue;
            dept.Manager_hiredate = dt_hiringDate.Value;

            db.SaveChanges();

            txt_name.Text = txt_desc.Text = txt_loc.Text = "";
            dgv_dept.DataSource = db.Departments.Select(dept => new
            {
                dept.Dept_Id,
                dept.Dept_Name,
                dept.Dept_Desc,
                dept.Dept_Location,
                dept.Dept_Manager,
                dept.Manager_hiredate
            }).ToList();

            MessageBox.Show($"department updated successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this department", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Department d = db.Departments.Where(d => d.Dept_Id == id).SingleOrDefault();
                if (d.Dept_Manager.HasValue)
                {
                    MessageBox.Show("you can't delete this row");
                    return;
                }

                db.Departments.Remove(d);
                db.SaveChanges();

                txt_name.Text = txt_desc.Text = txt_loc.Text = "";
                dgv_dept.DataSource = db.Departments.Select(dept => new
                {
                    dept.Dept_Id,
                    dept.Dept_Name,
                    dept.Dept_Desc,
                    dept.Dept_Location,
                    dept.Dept_Manager,
                    dept.Manager_hiredate
                }).ToList();

                MessageBox.Show("department deleted successfully");
            }
        }
    }
}
