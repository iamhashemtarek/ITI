namespace QuizManagementSystem.Forms
{
    partial class TeacherDashboardForm
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
            btnCreateQuiz = new Button();
            btnViewResults = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnCreateQuiz
            // 
            btnCreateQuiz.Location = new Point(78, 71);
            btnCreateQuiz.Name = "btnCreateQuiz";
            btnCreateQuiz.Size = new Size(94, 29);
            btnCreateQuiz.TabIndex = 0;
            btnCreateQuiz.Text = "create quiz";
            btnCreateQuiz.UseVisualStyleBackColor = true;
            btnCreateQuiz.Click += btnCreateQuiz_Click;
            // 
            // btnViewResults
            // 
            btnViewResults.Location = new Point(298, 71);
            btnViewResults.Name = "btnViewResults";
            btnViewResults.Size = new Size(94, 29);
            btnViewResults.TabIndex = 1;
            btnViewResults.Text = "view results";
            btnViewResults.UseVisualStyleBackColor = true;
            btnViewResults.Click += btnViewResults_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(546, 71);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // TeacherDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnViewResults);
            Controls.Add(btnCreateQuiz);
            Name = "TeacherDashboardForm";
            Text = "TeacherDashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateQuiz;
        private Button btnViewResults;
        private Button btnLogout;
    }
}