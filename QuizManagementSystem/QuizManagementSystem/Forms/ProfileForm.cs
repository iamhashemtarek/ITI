using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ProfileForm : Form
    {
        private int _userId;

        public ProfileForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadProfile();
        }
        private void LoadProfile()
        {
            using (var context = new QuizContext())
            {
                var user = context.Users.Find(_userId);
                lblUsername.Text = user.Username;
                txtEmail.Text = user.Email;
                txtFullName.Text = user.FullName;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new QuizContext())
            {
                var user = context.Users.Find(_userId);
                user.Email = txtEmail.Text;
                user.FullName = txtFullName.Text;
                context.SaveChanges();
                MessageBox.Show("Profile updated successfully!");
            }
        }
    }
}
