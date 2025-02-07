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
using static System.Formats.Asn1.AsnWriter;

namespace QuizManagementSystem.Forms
{
    public partial class QuizTakingForm : MaterialForm
    {
        private int _studentId;
        private int _quizId;
        private int _currentQuestionIndex = 0;
        private List<Question> _questions;
        private int _score = 0;

        public QuizTakingForm(int studentId, int quizId)
        {
            InitializeComponent();
            GlobalStyle.Apply(this);

            _studentId = studentId;
            _quizId = quizId;
            LoadQuiz();
            DisplayQuestion();

        }
        private void LoadQuiz()
        {
            using (var context = new QuizContext())
            {
                _questions = context.Questions
                    .Include(q => q.Answers)
                    .Where(q => q.QuizId == _quizId)
                    .ToList();
            }
        }
        private void DisplayQuestion()
        {
            if (_currentQuestionIndex >= _questions.Count)
            {
                MessageBox.Show("No more questions.");
                return;
            }

            var question = _questions[_currentQuestionIndex];
            lblQuestion.Text = question.Text;

            // Clear previous radio buttons
            pnlAnswers.Controls.Clear();

            int yOffset = 10; // Start position for radio buttons

            foreach (var answer in question.Answers)
            {
                var rdo = new RadioButton()
                {
                    Text = answer.Text,
                    Tag = answer.IsCorrect,
                    AutoSize = true,
                    Location = new Point(10, yOffset) // Adjust position
                };

                pnlAnswers.Controls.Add(rdo);
                yOffset += 30; // Move next radio button down
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigateToStudentDashboard();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check if an answer is selected
            var selectedAnswer = pnlAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (selectedAnswer == null)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            // Update score if the answer is correct
            if ((bool)selectedAnswer.Tag)
            {
                _score++;
            }

            // Move to the next question
            _currentQuestionIndex++;
            if (_currentQuestionIndex < _questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Quiz completed!");
                SaveResult();
                NavigateToStudentDashboard();
            }
        }
        
        private void SaveResult()
        {
            using (var context = new QuizContext())
            {
                var result = new Result
                {
                    StudentId = _studentId,
                    QuizId = _quizId,
                    Score = _score
                };

                context.Results.Add(result);
                context.SaveChanges();
            }
        }
        private void NavigateToStudentDashboard()
        {
            var studentDashboard = new StudentDashboardForm(_studentId);
            studentDashboard.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if an answer is selected for the current question
            var selectedAnswer = pnlAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (selectedAnswer == null)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            // Update score if the answer is correct
            if ((bool)selectedAnswer.Tag)
            {
                _score++;
            }

            // Save the result and navigate to the student dashboard
            SaveResult();
            MessageBox.Show("Quiz submitted successfully!");
            NavigateToStudentDashboard();
        }
    }
}
