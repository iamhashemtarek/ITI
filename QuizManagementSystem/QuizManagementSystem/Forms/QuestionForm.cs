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
    public partial class QuestionForm : Form
    {
        public Question Question { get; private set; } = new Question();

        public QuestionForm()
        {
            InitializeComponent();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            var answer = new Answer
            {
                Text = txtAnswer.Text,
                IsCorrect = chkIsCorrect.Checked
            };

            Question.Answers.Add(answer);
            lstAnswers.Items.Add(answer.Text);
            txtAnswer.Clear();
            chkIsCorrect.Checked = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) || Question.Answers.Count == 0)
            {
                MessageBox.Show("Please enter a question and at least one answer.");
                return;
            }

            Question.Text = txtQuestion.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
