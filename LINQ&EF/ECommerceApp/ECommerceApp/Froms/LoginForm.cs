using ECommerceApp.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECommerceApp.Froms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            DataTable dt = new DatabaseHelper().ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                // Get the logged-in user's ID and role
                int userId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                string role = dt.Rows[0]["Role"].ToString();
                if (role == "Admin")
                {
                    AdminDashboardForm adminForm = new AdminDashboardForm();
                    adminForm.Show();
                }
                else
                {
                    UserDashboardForm userForm = new UserDashboardForm(userId);
                    userForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}
