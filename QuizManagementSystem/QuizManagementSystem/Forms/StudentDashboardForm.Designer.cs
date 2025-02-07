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
            btnTakeQuiz1 = new MaterialSkin.Controls.MaterialButton();
            btnViewResults1 = new MaterialSkin.Controls.MaterialButton();
            btnLogout1 = new MaterialSkin.Controls.MaterialButton();
            btnBack1 = new MaterialSkin.Controls.MaterialButton();
            cmbQuizzes1 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // btnTakeQuiz1
            // 
            btnTakeQuiz1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTakeQuiz1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTakeQuiz1.Depth = 0;
            btnTakeQuiz1.HighEmphasis = true;
            btnTakeQuiz1.Icon = null;
            btnTakeQuiz1.Location = new Point(35, 212);
            btnTakeQuiz1.Margin = new Padding(4, 6, 4, 6);
            btnTakeQuiz1.MouseState = MaterialSkin.MouseState.HOVER;
            btnTakeQuiz1.Name = "btnTakeQuiz1";
            btnTakeQuiz1.NoAccentTextColor = Color.Empty;
            btnTakeQuiz1.Size = new Size(94, 36);
            btnTakeQuiz1.TabIndex = 5;
            btnTakeQuiz1.Text = "Take Quiz";
            btnTakeQuiz1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTakeQuiz1.UseAccentColor = false;
            btnTakeQuiz1.UseVisualStyleBackColor = true;
            btnTakeQuiz1.Click += btnTakeQuiz_Click;
            // 
            // btnViewResults1
            // 
            btnViewResults1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewResults1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnViewResults1.Depth = 0;
            btnViewResults1.HighEmphasis = true;
            btnViewResults1.Icon = null;
            btnViewResults1.Location = new Point(252, 103);
            btnViewResults1.Margin = new Padding(4, 6, 4, 6);
            btnViewResults1.MouseState = MaterialSkin.MouseState.HOVER;
            btnViewResults1.Name = "btnViewResults1";
            btnViewResults1.NoAccentTextColor = Color.Empty;
            btnViewResults1.Size = new Size(122, 36);
            btnViewResults1.TabIndex = 6;
            btnViewResults1.Text = "View Results";
            btnViewResults1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnViewResults1.UseAccentColor = false;
            btnViewResults1.UseVisualStyleBackColor = true;
            btnViewResults1.Click += btnViewResults_Click;
            // 
            // btnLogout1
            // 
            btnLogout1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout1.Depth = 0;
            btnLogout1.HighEmphasis = true;
            btnLogout1.Icon = null;
            btnLogout1.Location = new Point(296, 157);
            btnLogout1.Margin = new Padding(4, 6, 4, 6);
            btnLogout1.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout1.Name = "btnLogout1";
            btnLogout1.NoAccentTextColor = Color.Empty;
            btnLogout1.Size = new Size(78, 36);
            btnLogout1.TabIndex = 7;
            btnLogout1.Text = "Logout";
            btnLogout1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout1.UseAccentColor = false;
            btnLogout1.UseVisualStyleBackColor = true;
            btnLogout1.Click += btnLogout_Click;
            // 
            // btnBack1
            // 
            btnBack1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBack1.Depth = 0;
            btnBack1.HighEmphasis = true;
            btnBack1.Icon = null;
            btnBack1.Location = new Point(310, 205);
            btnBack1.Margin = new Padding(4, 6, 4, 6);
            btnBack1.MouseState = MaterialSkin.MouseState.HOVER;
            btnBack1.Name = "btnBack1";
            btnBack1.NoAccentTextColor = Color.Empty;
            btnBack1.Size = new Size(64, 36);
            btnBack1.TabIndex = 8;
            btnBack1.Text = "Back";
            btnBack1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBack1.UseAccentColor = false;
            btnBack1.UseVisualStyleBackColor = true;
            btnBack1.Click += btnBack_Click;
            // 
            // cmbQuizzes1
            // 
            cmbQuizzes1.AutoResize = false;
            cmbQuizzes1.BackColor = Color.FromArgb(255, 255, 255);
            cmbQuizzes1.Depth = 0;
            cmbQuizzes1.DrawMode = DrawMode.OwnerDrawVariable;
            cmbQuizzes1.DropDownHeight = 174;
            cmbQuizzes1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuizzes1.DropDownWidth = 121;
            cmbQuizzes1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbQuizzes1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbQuizzes1.FormattingEnabled = true;
            cmbQuizzes1.IntegralHeight = false;
            cmbQuizzes1.ItemHeight = 43;
            cmbQuizzes1.Location = new Point(35, 144);
            cmbQuizzes1.MaxDropDownItems = 4;
            cmbQuizzes1.MouseState = MaterialSkin.MouseState.OUT;
            cmbQuizzes1.Name = "cmbQuizzes1";
            cmbQuizzes1.Size = new Size(151, 49);
            cmbQuizzes1.StartIndex = 0;
            cmbQuizzes1.TabIndex = 9;
            cmbQuizzes1.SelectedIndexChanged += cmbQuizzes1_SelectedIndexChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(35, 103);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(90, 19);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "Choose Quiz";
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 298);
            Controls.Add(materialLabel1);
            Controls.Add(cmbQuizzes1);
            Controls.Add(btnBack1);
            Controls.Add(btnLogout1);
            Controls.Add(btnViewResults1);
            Controls.Add(btnTakeQuiz1);
            Name = "StudentDashboardForm";
            Text = "Student Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnTakeQuiz1;
        private MaterialSkin.Controls.MaterialButton btnViewResults1;
        private MaterialSkin.Controls.MaterialButton btnLogout1;
        private MaterialSkin.Controls.MaterialButton btnBack1;
        private MaterialSkin.Controls.MaterialComboBox cmbQuizzes1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}