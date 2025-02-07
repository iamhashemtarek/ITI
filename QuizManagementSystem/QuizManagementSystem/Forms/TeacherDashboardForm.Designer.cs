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
            btnCreateQuiz = new MaterialSkin.Controls.MaterialButton();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            btnView = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnCreateQuiz
            // 
            btnCreateQuiz.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreateQuiz.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreateQuiz.Depth = 0;
            btnCreateQuiz.HighEmphasis = true;
            btnCreateQuiz.Icon = null;
            btnCreateQuiz.Location = new Point(106, 129);
            btnCreateQuiz.Margin = new Padding(4, 6, 4, 6);
            btnCreateQuiz.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreateQuiz.Name = "btnCreateQuiz";
            btnCreateQuiz.NoAccentTextColor = Color.Empty;
            btnCreateQuiz.Size = new Size(161, 36);
            btnCreateQuiz.TabIndex = 3;
            btnCreateQuiz.Text = "Create a new quiz";
            btnCreateQuiz.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreateQuiz.UseAccentColor = false;
            btnCreateQuiz.UseVisualStyleBackColor = true;
            btnCreateQuiz.Click += btnCreateQuiz_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(148, 316);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(78, 36);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnView
            // 
            btnView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnView.Depth = 0;
            btnView.HighEmphasis = true;
            btnView.Icon = null;
            btnView.Location = new Point(109, 226);
            btnView.Margin = new Padding(4, 6, 4, 6);
            btnView.MouseState = MaterialSkin.MouseState.HOVER;
            btnView.Name = "btnView";
            btnView.NoAccentTextColor = Color.Empty;
            btnView.Size = new Size(158, 36);
            btnView.TabIndex = 6;
            btnView.Text = "View Quiz Results";
            btnView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnView.UseAccentColor = false;
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnViewResults_Click;
            // 
            // TeacherDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 403);
            Controls.Add(btnView);
            Controls.Add(btnLogout);
            Controls.Add(btnCreateQuiz);
            Name = "TeacherDashboardForm";
            Text = "Teacher Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private MaterialSkin.Controls.MaterialButton btnCreateQuiz;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialButton btnView;
    }
}