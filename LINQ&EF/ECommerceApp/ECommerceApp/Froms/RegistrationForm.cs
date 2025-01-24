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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            int age = int.Parse(txtAge.Text);
            string address = txtAddress.Text;
            string role = "User"; // Default role for new users

            string query = "INSERT INTO Users (Username, Password, Email, Age, Address, Role) VALUES (@Username, @Password, @Email, @Age, @Address, @Role)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@Email", email),
                new SqlParameter("@Age", age),
                new SqlParameter("@Address", address),
                new SqlParameter("@Role", role)
            };

            int result = new DatabaseHelper().ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Registration successful!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }
    }
}
