using MaterialSkin.Controls;
using QuizManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem.Forms
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            GlobalStyle.Apply(this);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (var context = new QuizContext())
            {
                if (context.Users.Any(u => u.Username == txtUsername.Text))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }

                var user = new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    FullName = txtFullName.Text,
                    IsTeacher = chkIsTeacher.Checked
                };

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Registration successful!");
                //this.Close();
                var welcomeForm = new WelcomeForm();
                welcomeForm.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
    }
}
