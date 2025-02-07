using MaterialSkin;
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
    public partial class LoginForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;

        public LoginForm()
        {
            InitializeComponent();
            GlobalStyle.Apply(this);

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

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }



        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
