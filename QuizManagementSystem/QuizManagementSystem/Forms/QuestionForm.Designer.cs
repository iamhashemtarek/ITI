namespace QuizManagementSystem.Forms
{
    partial class QuestionForm
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
            lstAnswers = new ListBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtQuestion = new MaterialSkin.Controls.MaterialTextBox();
            chkIsCorrect = new MaterialSkin.Controls.MaterialCheckbox();
            btnAddAnswer = new MaterialSkin.Controls.MaterialButton();
            txtAnswer1 = new MaterialSkin.Controls.MaterialTextBox();
            btnSave1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lstAnswers
            // 
            lstAnswers.FormattingEnabled = true;
            lstAnswers.Location = new Point(441, 269);
            lstAnswers.Name = "lstAnswers";
            lstAnswers.Size = new Size(150, 104);
            lstAnswers.TabIndex = 6;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 105);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 234);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 8;
            label2.Text = "answer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 185);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 10;
            label4.Text = "Answers ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 234);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 11;
            label5.Text = "answers";
            // 
            // txtQuestion
            // 
            txtQuestion.AnimateReadOnly = false;
            txtQuestion.BorderStyle = BorderStyle.None;
            txtQuestion.Depth = 0;
            txtQuestion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuestion.LeadingIcon = null;
            txtQuestion.Location = new Point(180, 93);
            txtQuestion.MaxLength = 50;
            txtQuestion.MouseState = MaterialSkin.MouseState.OUT;
            txtQuestion.Multiline = false;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(363, 50);
            txtQuestion.TabIndex = 12;
            txtQuestion.Text = "";
            txtQuestion.TrailingIcon = null;
            // 
            // chkIsCorrect
            // 
            chkIsCorrect.AutoSize = true;
            chkIsCorrect.Depth = 0;
            chkIsCorrect.Location = new Point(29, 343);
            chkIsCorrect.Margin = new Padding(0);
            chkIsCorrect.MouseLocation = new Point(-1, -1);
            chkIsCorrect.MouseState = MaterialSkin.MouseState.HOVER;
            chkIsCorrect.Name = "chkIsCorrect";
            chkIsCorrect.ReadOnly = false;
            chkIsCorrect.Ripple = true;
            chkIsCorrect.Size = new Size(101, 37);
            chkIsCorrect.TabIndex = 14;
            chkIsCorrect.Text = "Is Correct";
            chkIsCorrect.UseVisualStyleBackColor = true;
            // 
            // btnAddAnswer
            // 
            btnAddAnswer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddAnswer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddAnswer.Depth = 0;
            btnAddAnswer.HighEmphasis = true;
            btnAddAnswer.Icon = null;
            btnAddAnswer.Location = new Point(180, 344);
            btnAddAnswer.Margin = new Padding(4, 6, 4, 6);
            btnAddAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddAnswer.Name = "btnAddAnswer";
            btnAddAnswer.NoAccentTextColor = Color.Empty;
            btnAddAnswer.Size = new Size(114, 36);
            btnAddAnswer.TabIndex = 15;
            btnAddAnswer.Text = "Add Answer";
            btnAddAnswer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddAnswer.UseAccentColor = false;
            btnAddAnswer.UseVisualStyleBackColor = true;
            btnAddAnswer.Click += btnAddAnswer_Click;
            // 
            // txtAnswer1
            // 
            txtAnswer1.AnimateReadOnly = false;
            txtAnswer1.BorderStyle = BorderStyle.None;
            txtAnswer1.Depth = 0;
            txtAnswer1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnswer1.LeadingIcon = null;
            txtAnswer1.Location = new Point(29, 269);
            txtAnswer1.MaxLength = 50;
            txtAnswer1.MouseState = MaterialSkin.MouseState.OUT;
            txtAnswer1.Multiline = false;
            txtAnswer1.Name = "txtAnswer1";
            txtAnswer1.Size = new Size(242, 50);
            txtAnswer1.TabIndex = 16;
            txtAnswer1.Text = "";
            txtAnswer1.TrailingIcon = null;
            // 
            // btnSave1
            // 
            btnSave1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave1.Depth = 0;
            btnSave1.HighEmphasis = true;
            btnSave1.Icon = null;
            btnSave1.Location = new Point(477, 446);
            btnSave1.Margin = new Padding(4, 6, 4, 6);
            btnSave1.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave1.Name = "btnSave1";
            btnSave1.NoAccentTextColor = Color.Empty;
            btnSave1.Size = new Size(64, 36);
            btnSave1.TabIndex = 17;
            btnSave1.Text = "Save";
            btnSave1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave1.UseAccentColor = false;
            btnSave1.UseVisualStyleBackColor = true;
            btnSave1.Click += btnSave_Click;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 522);
            Controls.Add(btnSave1);
            Controls.Add(txtAnswer1);
            Controls.Add(btnAddAnswer);
            Controls.Add(chkIsCorrect);
            Controls.Add(txtQuestion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstAnswers);
            Name = "QuestionForm";
            Text = "Question Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAnswer;
        private Button btnSave;
        private ListBox lstAnswers;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtQuestion;
        //private MaterialSkin.Controls.MaterialTextBox txtAnswer;
        private MaterialSkin.Controls.MaterialCheckbox chkIsCorrect;
        private MaterialSkin.Controls.MaterialButton btnAddAnswer;
        private MaterialSkin.Controls.MaterialTextBox txtAnswer1;
        private MaterialSkin.Controls.MaterialButton btnSave1;
        //private MaterialSkin.Controls.MaterialButton btnSave;
    }
}