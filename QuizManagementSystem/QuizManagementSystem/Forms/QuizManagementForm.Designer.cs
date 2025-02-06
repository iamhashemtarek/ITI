namespace QuizManagementSystem.Forms
{
    partial class QuizManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtQuizTitle = new TextBox();
            btnAddQuestion = new Button();
            dgvQuestions = new DataGridView();
            btnSaveQuiz = new Button();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // txtQuizTitle
            // 
            txtQuizTitle.Location = new Point(24, 111);
            txtQuizTitle.Name = "txtQuizTitle";
            txtQuizTitle.Size = new Size(125, 27);
            txtQuizTitle.TabIndex = 0;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(395, 331);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(94, 29);
            btnAddQuestion.TabIndex = 1;
            btnAddQuestion.Text = "add";
            btnAddQuestion.UseVisualStyleBackColor = true;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(24, 216);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RowHeadersWidth = 51;
            dgvQuestions.Size = new Size(300, 188);
            dgvQuestions.TabIndex = 2;
            // 
            // btnSaveQuiz
            // 
            btnSaveQuiz.Location = new Point(395, 375);
            btnSaveQuiz.Name = "btnSaveQuiz";
            btnSaveQuiz.Size = new Size(94, 29);
            btnSaveQuiz.TabIndex = 3;
            btnSaveQuiz.Text = "save";
            btnSaveQuiz.UseVisualStyleBackColor = true;
            btnSaveQuiz.Click += btnSaveQuiz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 118);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "quiz title";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(609, 44);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // QuizManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnSaveQuiz);
            Controls.Add(dgvQuestions);
            Controls.Add(btnAddQuestion);
            Controls.Add(txtQuizTitle);
            Name = "QuizManagementForm";
            Text = "QuizManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuizTitle;
        private Button btnAddQuestion;
        private DataGridView dgvQuestions;
        private Button btnSaveQuiz;
        private Label label1;
        private Button btnBack;
    }
}