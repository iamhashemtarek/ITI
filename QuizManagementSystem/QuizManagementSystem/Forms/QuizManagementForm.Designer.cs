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
            dgvQuestions = new DataGridView();
            label1 = new Label();
            save = new MaterialSkin.Controls.MaterialButton();
            txtQuizTitle1 = new MaterialSkin.Controls.MaterialTextBox();
            back = new MaterialSkin.Controls.MaterialButton();
            add = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(24, 207);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RowHeadersWidth = 51;
            dgvQuestions.Size = new Size(271, 106);
            dgvQuestions.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 103);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "quiz title";
            // 
            // save
            // 
            save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save.Depth = 0;
            save.HighEmphasis = true;
            save.Icon = null;
            save.Location = new Point(335, 207);
            save.Margin = new Padding(4, 6, 4, 6);
            save.MouseState = MaterialSkin.MouseState.HOVER;
            save.Name = "save";
            save.NoAccentTextColor = Color.Empty;
            save.Size = new Size(64, 36);
            save.TabIndex = 8;
            save.Text = "Save";
            save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save.UseAccentColor = false;
            save.UseVisualStyleBackColor = true;
            save.Click += btnSaveQuiz_Click;
            // 
            // txtQuizTitle1
            // 
            txtQuizTitle1.AnimateReadOnly = false;
            txtQuizTitle1.BorderStyle = BorderStyle.None;
            txtQuizTitle1.Depth = 0;
            txtQuizTitle1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuizTitle1.LeadingIcon = null;
            txtQuizTitle1.Location = new Point(24, 142);
            txtQuizTitle1.MaxLength = 50;
            txtQuizTitle1.MouseState = MaterialSkin.MouseState.OUT;
            txtQuizTitle1.Multiline = false;
            txtQuizTitle1.Name = "txtQuizTitle1";
            txtQuizTitle1.Size = new Size(271, 50);
            txtQuizTitle1.TabIndex = 9;
            txtQuizTitle1.Text = "";
            txtQuizTitle1.TrailingIcon = null;
            txtQuizTitle1.TextChanged += materialTextBox1_TextChanged;
            // 
            // back
            // 
            back.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            back.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            back.Depth = 0;
            back.HighEmphasis = true;
            back.Icon = null;
            back.Location = new Point(335, 277);
            back.Margin = new Padding(4, 6, 4, 6);
            back.MouseState = MaterialSkin.MouseState.HOVER;
            back.Name = "back";
            back.NoAccentTextColor = Color.Empty;
            back.Size = new Size(64, 36);
            back.TabIndex = 10;
            back.Text = "Back";
            back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            back.UseAccentColor = false;
            back.UseVisualStyleBackColor = true;
            back.Click += btnBack_Click;
            // 
            // add
            // 
            add.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            add.Depth = 0;
            add.HighEmphasis = true;
            add.Icon = null;
            add.Location = new Point(335, 142);
            add.Margin = new Padding(4, 6, 4, 6);
            add.MouseState = MaterialSkin.MouseState.HOVER;
            add.Name = "add";
            add.NoAccentTextColor = Color.Empty;
            add.Size = new Size(64, 36);
            add.TabIndex = 11;
            add.Text = "Add";
            add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            add.UseAccentColor = false;
            add.UseVisualStyleBackColor = true;
            add.Click += btnAddQuestion_Click;
            // 
            // QuizManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 344);
            Controls.Add(add);
            Controls.Add(back);
            Controls.Add(txtQuizTitle1);
            Controls.Add(save);
            Controls.Add(label1);
            Controls.Add(dgvQuestions);
            Name = "QuizManagementForm";
            Text = "Quiz Management";
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuizTitle;
        private Button btnAddQuestion1;
        private DataGridView dgvQuestions;
        private Label label1;
        //private MaterialSkin.Controls.MaterialTextBox txtQuizTitle;
        //private MaterialSkin.Controls.MaterialButton btnAddQuestion;
        private MaterialSkin.Controls.MaterialButton btnAddQuestion;
        private MaterialSkin.Controls.MaterialTextBox txtQuizTitle1;
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialButton add;
        private MaterialSkin.Controls.MaterialButton back;
        //private MaterialSkin.Controls.MaterialButton btnBack;
    }
}