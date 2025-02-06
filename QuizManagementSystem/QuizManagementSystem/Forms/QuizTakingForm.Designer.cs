namespace QuizManagementSystem.Forms
{
    partial class QuizTakingForm
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
            btnBack = new Button();
            lblQuestion = new Label();
            btnNext = new Button();
            btnSubmit = new Button();
            pnlAnswers = new Panel();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(551, 46);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(150, 69);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(66, 20);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "question";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(473, 409);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(161, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pnlAnswers
            // 
            pnlAnswers.Location = new Point(130, 151);
            pnlAnswers.Name = "pnlAnswers";
            pnlAnswers.Size = new Size(499, 236);
            pnlAnswers.TabIndex = 5;
            pnlAnswers.Paint += panel1_Paint;
            // 
            // QuizTakingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlAnswers);
            Controls.Add(btnSubmit);
            Controls.Add(btnNext);
            Controls.Add(lblQuestion);
            Controls.Add(btnBack);
            Name = "QuizTakingForm";
            Text = "QuizTakingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblQuestion;
        private Button btnNext;
        private Button btnSubmit;
        private Panel pnlAnswers;
    }
}