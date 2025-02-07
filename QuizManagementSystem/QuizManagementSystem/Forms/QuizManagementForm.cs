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
    public partial class QuizManagementForm : MaterialForm
    {
        private int _teacherId;
        private List<Question> _questions = new List<Question>();
        public QuizManagementForm(int teacherId)
        {
            InitializeComponent();
            GlobalStyle.Apply(this);

            _teacherId = teacherId;

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            var questionForm = new QuestionForm();
            if (questionForm.ShowDialog() == DialogResult.OK)
            {
                _questions.Add(questionForm.Question);
                dgvQuestions.DataSource = _questions.Select(q => new
                {
                    q.Text,
                    Answers = q.Answers.Count
                }).ToList();
            }
        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuizTitle1.Text))
            {
                MessageBox.Show("Please enter a quiz title.");
                return;
            }

            if (_questions.Count == 0)
            {
                MessageBox.Show("Please add at least one question.");
                return;
            }

            using (var context = new QuizContext())
            {
                var quiz = new Quiz
                {
                    Title = txtQuizTitle1.Text,
                    TeacherId = _teacherId,
                    Questions = _questions
                };

                context.Quizzes.Add(quiz);
                context.SaveChanges();
                MessageBox.Show("Quiz saved successfully!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
