using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;


namespace CRUD
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        int id;
        string? name;
        int duration;
        int topic;
        public Form1()
        {
            InitializeComponent();

            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Duration", "Duration");
            dataGridView.Columns.Add("Topic", "Topic");

            var configuration = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            connection = new SqlConnection(configuration.GetSection("constr").Value);

            getAllTopics();
        }

        private void btn_add_click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            string name = txt_name.Text;
            int duration = int.Parse(txt_duration.Text);
            int topic = 2;//int.Parse(cb_topic.SelectedValue.ToString());

            string sqlStr = "insert into course values (@id, @name, @duration, @topic)";
            var command = new SqlCommand(sqlStr, connection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@duration", duration);
            command.Parameters.AddWithValue("@topic", topic);

            connection.Open();

            int affectedRows = command.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                MessageBox.Show("course added successfully");

            }

            connection.Close();


        }

        private void btn_cancel_click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_duration.Text = "";
            cb_topic.SelectedIndex = -1;


        }

        private void btn_update_click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            string name = txt_name.Text;
            int duration = int.Parse(txt_duration.Text);
            int topic = 3;//int.Parse(cb_topic.SelectedValue.ToString()) ;

            string sqlStr = "UPDATE course SET crs_name = @name, crs_duration = @duration, top_id = @topic WHERE crs_id = @id";
            var command = new SqlCommand(sqlStr, connection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@duration", duration);
            command.Parameters.AddWithValue("@topic", topic);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                MessageBox.Show("Course updated successfully!");
            }

            connection.Close() ;    
        }

        private void btn_delete_click(object sender, EventArgs e)
        {
         
                //int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);

                string sqlStr = "DELETE FROM course WHERE crs_id = @id";
                var command = new SqlCommand(sqlStr, connection);

                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Course deleted successfully!");
                }
            connection.Close();
        }

        private void getAllCourses(object sender, EventArgs e)
        {

            var command = new SqlCommand("select * from Course", connection);

            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                string name = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);
                int duration = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                int topic = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);


                dataGridView.Rows.Add(id, name, duration, topic);
            }

            connection.Close();
        }

        private void getAllTopics()
        {

            var command = new SqlCommand("select top_id, top_name from topic", connection);

            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                string name = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);

                var item = new { Name = name, Id = id };
                cb_topic.Items.Add(new ComboBoxItem { Name = name, Id = id });

            }
            cb_topic.DisplayMember = "Name";
            cb_topic.ValueMember = "Id";

            connection.Close();
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridView.Rows[e.RowIndex];
            id = Convert.ToInt32(clickedRow.Cells["Id"].Value);
            name = clickedRow.Cells["Name"].Value.ToString();
            duration = Convert.ToInt32(clickedRow.Cells["Duration"].Value);
            topic = Convert.ToInt32(clickedRow.Cells["Topic"].Value);

            txt_id.Text = id.ToString();
            txt_name.Text = name;
            txt_duration.Text = duration.ToString();
            cb_topic.SelectedValue = topic;

            btn_update.Visible = true;
            btn_delete.Visible = true;


        }
    }
}


public class ComboBoxItem
{
    public string Name { get; set; }
    public int Id { get; set; }

    public override string ToString()
    {
        return Name; // Display name in ComboBox
    }
}