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
using Microsoft.EntityFrameworkCore;


namespace QuizManagementSystem.Forms
{
    public partial class StudentDashboardForm : Form
    {
        private int _studentId;

        public StudentDashboardForm(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
            LoadQuizzes();

        }
        private void LoadQuizzes()
        {
            using (var context = new QuizContext())
            {
                var quizzes = context.Quizzes
                    .Select(q => new { q.Id, q.Title })
                    .ToList();

                cmbQuizzes.DataSource = quizzes;
                cmbQuizzes.DisplayMember = "Title";
                cmbQuizzes.ValueMember = "Id";
            }
        }


        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            if (cmbQuizzes.SelectedValue == null)
            {
                MessageBox.Show("Please select a quiz.");
                return;
            }

            int quizId = (int)cmbQuizzes.SelectedValue;
            var quizForm = new QuizTakingForm(_studentId, quizId);
            quizForm.Show();
            this.Hide();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            using (var context = new QuizContext())
            {
                var results = context.Results
                    .Where(r => r.StudentId == _studentId)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
    }
}
