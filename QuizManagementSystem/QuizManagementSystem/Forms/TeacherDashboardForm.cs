using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
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
    public partial class TeacherDashboardForm : MaterialForm
    {
        private int _teacherId;

        public TeacherDashboardForm(int teacherId)
        {
            InitializeComponent();
            GlobalStyle.Apply(this);

            _teacherId = teacherId;

        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            var quizForm = new QuizManagementForm(_teacherId);
            quizForm.Show();

        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            using (var context = new QuizContext())
            {
                var results = context.Results
                    .Where(r => r.Quiz.TeacherId == _teacherId)
                    .ToList();


                if (results.Count == 0)
                {
                    MessageBox.Show("No results found.");
                    return;
                }

                foreach (var result in results)
                {
                    context.Entry(result).Reference(r => r.Quiz).Load();  
                    context.Entry(result).Reference(r => r.Student).Load(); 
                }


                var resultsForm = new ResultsForm(results);
                resultsForm.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
    }
}
