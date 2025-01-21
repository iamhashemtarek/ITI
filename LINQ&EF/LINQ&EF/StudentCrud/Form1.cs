using StudentCrud.Models;

namespace StudentCrud
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
            var student = db.Students.Select(student => new
            {
                student.St_Id,
                student.St_Fname,
                student.St_Lname,
                student.St_Age,
                student.St_Address,
                student.Dept.Dept_Name,
                student.St_super
            }).ToList();

            id = student.Last().St_Id;
            //int lastRowIndex = dgv_students.Rows.Count - 1;
            //id = (int)dgv_students.Rows[lastRowIndex].Cells[0].Value;

            dgv_students.DataSource = student;
            dgv_students.Columns["St_Id"].Visible = false;


            cb_dept.DataSource = db.Departments.ToList();
            cb_dept.DisplayMember = "Dept_Name";
            cb_dept.ValueMember = "Dept_Id";

            cb_super.DataSource = db.Students.ToList();
            cb_super.DisplayMember = "St_Fname";
            cb_super.ValueMember = "St_Id";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                St_Id = ++id,
                St_Fname = txt_fname.Text,
                St_Lname = txt_lname.Text,
                St_Address = txt_address.Text,
                St_Age = int.Parse(txt_age.Text),
                Dept_Id = (int)cb_dept.SelectedValue,
                St_super = (int)cb_super.SelectedValue
            };

            db.Students.Add(student);

            db.SaveChanges();
            txt_fname.Text = txt_lname.Text = txt_address.Text = txt_age.Text = "";
            dgv_students.DataSource = db.Students.Select(student => new
            {
                student.St_Id,
                student.St_Fname,
                student.St_Lname,
                student.St_Age,
                student.St_Address,
                student.Dept.Dept_Name,
                student.St_super
            }).ToList();
            MessageBox.Show("student added successfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(n => n.St_Id == id).SingleOrDefault();
            s.St_Fname = txt_fname.Text;
            s.St_Lname = txt_lname.Text;
            s.St_Age = int.Parse(txt_age.Text);
            s.St_Address = txt_address.Text;
            s.Dept_Id = (int)cb_dept.SelectedValue;
            s.St_super = (int)cb_super.SelectedValue;

            db.SaveChanges();
            txt_address.Text = txt_age.Text = txt_lname.Text = txt_fname.Text = "";
            dgv_students.DataSource = db.Students.Select(student => new
            {
                student.St_Id,
                student.St_Fname,
                student.St_Lname,
                student.St_Age,
                student.St_Address,
                student.Dept.Dept_Name,
                student.St_super
            }).ToList();
            dgv_students.Columns["St_Id"].Visible = false;
            MessageBox.Show("updated");
        }

        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_students.SelectedRows[0].Cells[0].Value;
            var s = db.Students.Where(st => st.St_Id == id).SingleOrDefault();

            txt_fname.Text = s.St_Fname;
            txt_lname.Text = s.St_Lname;
            txt_age.Text = s.St_Age.ToString();
            txt_address.Text = s.St_Address;
            cb_dept.SelectedValue = s.Dept_Id;
            cb_super.SelectedValue = s.St_Id;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Student s = db.Students.Where(s => s.St_Id == id).SingleOrDefault();
                if(s.Dept_Id.HasValue || s.St_super.HasValue)
                {
                    MessageBox.Show("you can't delete this row");
                    return;
                }
                db.Students.Remove(s);

                db.SaveChanges();
                txt_address.Text = txt_age.Text = txt_lname.Text = txt_fname.Text = "";
                dgv_students.DataSource = db.Students.ToList();
                MessageBox.Show("deleted");
            }
        }
    }
}
