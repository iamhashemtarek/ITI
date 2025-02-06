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
            txtQuestion = new TextBox();
            chkIsCorrect = new CheckBox();
            txtAnswer = new TextBox();
            btnAddAnswer = new Button();
            btnSave = new Button();
            lstAnswers = new ListBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(247, 12);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(125, 27);
            txtQuestion.TabIndex = 0;
            // 
            // chkIsCorrect
            // 
            chkIsCorrect.AutoSize = true;
            chkIsCorrect.Location = new Point(247, 141);
            chkIsCorrect.Name = "chkIsCorrect";
            chkIsCorrect.Size = new Size(91, 24);
            chkIsCorrect.TabIndex = 1;
            chkIsCorrect.Text = "is correct";
            chkIsCorrect.UseVisualStyleBackColor = true;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(247, 70);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(125, 27);
            txtAnswer.TabIndex = 3;
            // 
            // btnAddAnswer
            // 
            btnAddAnswer.Location = new Point(442, 141);
            btnAddAnswer.Name = "btnAddAnswer";
            btnAddAnswer.Size = new Size(94, 29);
            btnAddAnswer.TabIndex = 4;
            btnAddAnswer.Text = "add answer";
            btnAddAnswer.UseVisualStyleBackColor = true;
            btnAddAnswer.Click += btnAddAnswer_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(586, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lstAnswers
            // 
            lstAnswers.FormattingEnabled = true;
            lstAnswers.Location = new Point(235, 271);
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
            label1.Location = new Point(109, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 73);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 8;
            label2.Text = "answer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 204);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 288);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 11;
            label5.Text = "answers";
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstAnswers);
            Controls.Add(btnSave);
            Controls.Add(btnAddAnswer);
            Controls.Add(txtAnswer);
            Controls.Add(chkIsCorrect);
            Controls.Add(txtQuestion);
            Name = "QuestionForm";
            Text = "QuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion;
        private CheckBox chkIsCorrect;
        private TextBox txtAnswer;
        private Button btnAddAnswer;
        private Button btnSave;
        private ListBox lstAnswers;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}