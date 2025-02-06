namespace QuizManagementSystem.Forms
{
    partial class StudentDashboardForm
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
            btnTakeQuiz = new Button();
            btnViewResults = new Button();
            btnLogout = new Button();
            btnBack = new Button();
            cmbQuizzes = new ComboBox();
            SuspendLayout();
            // 
            // btnTakeQuiz
            // 
            btnTakeQuiz.Location = new Point(112, 84);
            btnTakeQuiz.Name = "btnTakeQuiz";
            btnTakeQuiz.Size = new Size(94, 29);
            btnTakeQuiz.TabIndex = 0;
            btnTakeQuiz.Text = "take quiz";
            btnTakeQuiz.UseVisualStyleBackColor = true;
            btnTakeQuiz.Click += btnTakeQuiz_Click;
            // 
            // btnViewResults
            // 
            btnViewResults.Location = new Point(299, 95);
            btnViewResults.Name = "btnViewResults";
            btnViewResults.Size = new Size(94, 29);
            btnViewResults.TabIndex = 1;
            btnViewResults.Text = "view results";
            btnViewResults.UseVisualStyleBackColor = true;
            btnViewResults.Click += btnViewResults_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(512, 84);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(454, 290);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbQuizzes
            // 
            cmbQuizzes.FormattingEnabled = true;
            cmbQuizzes.Location = new Point(172, 201);
            cmbQuizzes.Name = "cmbQuizzes";
            cmbQuizzes.Size = new Size(151, 28);
            cmbQuizzes.TabIndex = 4;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbQuizzes);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Controls.Add(btnViewResults);
            Controls.Add(btnTakeQuiz);
            Name = "StudentDashboardForm";
            Text = "StudentDashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTakeQuiz;
        private Button btnViewResults;
        private Button btnLogout;
        private Button btnBack;
        private ComboBox cmbQuizzes;
    }
}