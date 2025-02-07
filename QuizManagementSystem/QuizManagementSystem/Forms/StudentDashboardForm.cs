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
using MaterialSkin.Controls;


namespace QuizManagementSystem.Forms
{
    public partial class StudentDashboardForm : MaterialForm
    {
        private int _studentId;

        public StudentDashboardForm(int studentId)
        {
            InitializeComponent();
            GlobalStyle.Apply(this);

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

                cmbQuizzes1.DataSource = quizzes;
                cmbQuizzes1.DisplayMember = "Title";
                cmbQuizzes1.ValueMember = "Id";
            }
        }


        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            if (cmbQuizzes1.SelectedValue == null)
            {
                MessageBox.Show("Please select a quiz.");
                return;
            }

            int quizId = (int)cmbQuizzes1.SelectedValue;
            var quizForm = new QuizTakingForm(_studentId, quizId);
            quizForm.Show();
            this.Hide();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            using (var context = new QuizContext())
            {
                var results = context.Results
                    .Where(r => r.StudentId == (int)this._studentId)
                    .Select(r => new ResultDto
                    {
                        QuizTitle = r.Quiz.Title,
                        StudentName = context.Users.Where(s => s.Id == _studentId).Select(u => u.FullName).FirstOrDefault(),
                        Score = r.Score,
                    })
                    .ToList();

                if (results.Count == 0)
                {
                    MessageBox.Show("No results found.");
                    return;
                }


                //foreach (var result in results)
                //{
                //    context.Entry(result).Reference(r => r.Quiz).Load();
                //    context.Entry(result).Reference(r => r.Student).Load();
                //}

                new ResultForm(results).Show();
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

        private void cmbQuizzes1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
