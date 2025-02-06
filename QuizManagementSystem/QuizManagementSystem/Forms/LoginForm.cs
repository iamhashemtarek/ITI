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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (var context = new QuizContext())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

                if (user != null)
                {
                    MessageBox.Show("Login successful!");
                    if (user.IsTeacher)
                    {
                        var teacherForm = new TeacherDashboardForm(user.Id);
                        teacherForm.Show();
                    }
                    else
                    {
                        var studentForm = new StudentDashboardForm(user.Id);
                        studentForm.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
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
