using BussinessLogicLayer;
using Models;
using System.Data;

namespace basic3TierApp
{
    public partial class Instructor : Form
    {
        private InstructorBLL instructorBLL;
        public Instructor()
        {
            InitializeComponent();

            string connectionString = "Server=DESKTOP-77H1T1P\\SQLEXPRESS; Database = ITI; Integrated Security=True; TrustServerCertificate=True";
            instructorBLL = new InstructorBLL(connectionString);

            LoadInstructors();

        }
        private void LoadInstructors()
        {
            dgv_instructors.DataSource = instructorBLL.getAllInstructors();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgv_instructors.DataSource;

            Models.Instructor newInstructor = new Models.Instructor
            {
                Ins_Id = (int)num_id.Value,
                Ins_Name = txt_name.Text,
                Ins_Degree = txt_degree.Text,
                Salary = (int)num_salary.Value,
                Dept_Id = (int)num_dept.Value,

            };

            instructorBLL.addInstructor(newInstructor, dt);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgv_instructors.DataSource;

            Models.Instructor newInstructor = new Models.Instructor
            {
                Ins_Id = (int)num_id.Value,
                Ins_Name = txt_name.Text,
                Ins_Degree = txt_degree.Text,
                Salary = (int)num_salary.Value,
                Dept_Id = (int)num_dept.Value,

            };

            instructorBLL.updateInstructor(newInstructor, dt);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgv_instructors.DataSource;


            int Ins_Id = (int)num_id.Value;


            instructorBLL.deleteInstructor(Ins_Id, dt);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgv_instructors.DataSource;

            instructorBLL.updateDatabase(dt);
        }

        private void dgv_instructors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            int rowIndex = e.RowIndex;

            string insId = dgv_instructors.Rows[rowIndex].Cells["Ins_Id"].Value.ToString();
            string insName = dgv_instructors.Rows[rowIndex].Cells["Ins_Name"].Value.ToString();
            string insDegree = dgv_instructors.Rows[rowIndex].Cells["Ins_Degree"].Value.ToString();
            string salary = dgv_instructors.Rows[rowIndex].Cells["Salary"].Value.ToString();
            string deptId = dgv_instructors.Rows[rowIndex].Cells["Dept_Id"].Value.ToString();

            num_id.Value = int.Parse(insId);
            txt_name.Text = insName;
            txt_degree.Text = insDegree;
            num_salary.Value = decimal.Parse(salary);
            num_dept.Value = int.Parse(deptId);
        }
    }
}
