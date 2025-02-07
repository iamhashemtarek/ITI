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
            lblQuestion = new Label();
            pnlAnswers = new Panel();
            btnNext = new MaterialSkin.Controls.MaterialButton();
            btnSubmit = new MaterialSkin.Controls.MaterialButton();
            btnExit = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(22, 84);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(66, 20);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "question";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // pnlAnswers
            // 
            pnlAnswers.Location = new Point(6, 121);
            pnlAnswers.Name = "pnlAnswers";
            pnlAnswers.Size = new Size(519, 168);
            pnlAnswers.TabIndex = 5;
            pnlAnswers.Paint += panel1_Paint;
            // 
            // btnNext
            // 
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNext.Depth = 0;
            btnNext.HighEmphasis = true;
            btnNext.Icon = null;
            btnNext.Location = new Point(24, 318);
            btnNext.Margin = new Padding(4, 6, 4, 6);
            btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            btnNext.Name = "btnNext";
            btnNext.NoAccentTextColor = Color.Empty;
            btnNext.Size = new Size(64, 36);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNext.UseAccentColor = false;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSubmit.Depth = 0;
            btnSubmit.HighEmphasis = true;
            btnSubmit.Icon = null;
            btnSubmit.Location = new Point(110, 318);
            btnSubmit.Margin = new Padding(4, 6, 4, 6);
            btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NoAccentTextColor = Color.Empty;
            btnSubmit.Size = new Size(75, 36);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSubmit.UseAccentColor = false;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExit.Depth = 0;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.Location = new Point(211, 318);
            btnExit.Margin = new Padding(4, 6, 4, 6);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.NoAccentTextColor = Color.Empty;
            btnExit.Size = new Size(158, 36);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExit.UseAccentColor = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnBack_Click;
            // 
            // QuizTakingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 369);
            Controls.Add(btnExit);
            Controls.Add(pnlAnswers);
            Controls.Add(btnSubmit);
            Controls.Add(btnNext);
            Controls.Add(lblQuestion);
            Name = "QuizTakingForm";
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back1;
        private Label lblQuestion;
        private Panel pnlAnswers;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialButton btnExit;
    }
}