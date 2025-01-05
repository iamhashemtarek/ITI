using Microsoft.Data.SqlClient;
using Models;
using System.Data;
using System.Data.SqlTypes;

namespace dataAccessLayer
{
    public class InstructorDAL
    {
        private string connectionString;

        public InstructorDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable getAllInstructors()
        {
            DataTable dt = new DataTable();
            string query = "select * from instructor";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dt);
            }

            return dt;
        }

        public void addInstructor(Instructor instructor, DataTable dt)
        {
            DataRow newRow = dt.NewRow();
            newRow["Ins_Id"] = instructor.Ins_Id;
            newRow["Ins_Name"] = instructor.Ins_Name;
            newRow["Ins_Degree"] = instructor.Ins_Degree;
            newRow["Salary"] = instructor.Salary;
            newRow["Dept_Id"] = instructor.Dept_Id;

            dt.Rows.Add(newRow);

        }
        public void updataInstructor(Instructor instructor, DataTable dt) 
        {
            DataRow[] rowsToUpdate = dt.Select($"Ins_Id = {instructor.Ins_Id}");
            if (rowsToUpdate.Length > 0)
            {
                DataRow row = rowsToUpdate[0];
                row["Ins_Name"] = instructor.Ins_Name;
                row["Ins_Degree"] = instructor.Ins_Degree;
                row["Salary"] = instructor.Salary;
                row["Dept_Id"] = instructor.Dept_Id;
            }
        }
        public void deleteInstructor(int instructorId, DataTable dt)
        {

            DataRow[] rowsToDelete = dt.Select($"Ins_Id = {instructorId}");
            if (rowsToDelete.Length > 0)
            {
                DataRow row = rowsToDelete[0];
                dt.Rows.Remove(row); 
            }

        }

        public void UpdateDatabase(DataTable dt)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                adapter.SelectCommand = new SqlCommand("SELECT * FROM Instructor", connection);

                adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                adapter.InsertCommand = commandBuilder.GetInsertCommand();
                adapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                adapter.Update(dt);
            }
        }
    }
}
