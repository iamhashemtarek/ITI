namespace flappy_bird
{
    partial class game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bird = new PictureBox();
            pipeTop = new PictureBox();
            ground = new PictureBox();
            pipeBottom = new PictureBox();
            score = new Label();
            gametimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            SuspendLayout();
            // 
            // bird
            // 
            bird.BackgroundImage = Properties.Resources.bird;
            bird.Location = new Point(65, 258);
            bird.Name = "bird";
            bird.Size = new Size(80, 62);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 0;
            bird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(313, -54);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(125, 261);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-57, 579);
            ground.Name = "ground";
            ground.Size = new Size(828, 78);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(502, 364);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(125, 337);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 4;
            pipeBottom.TabStop = false;
            // 
            // score
            // 
            score.AutoSize = true;
            score.BackColor = Color.Transparent;
            score.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            score.Location = new Point(243, 274);
            score.Name = "score";
            score.Size = new Size(105, 37);
            score.TabIndex = 5;
            score.Text = "Score : ";
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += gameTimerEvent;
            // 
            // game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(639, 639);
            Controls.Add(score);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(bird);
            Name = "game";
            Text = "flappy bird";
            KeyDown += gamekeydown;
            KeyUp += gamekeyup;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox bird;
        private PictureBox pipeTop;
        private PictureBox ground;
        private PictureBox pipeBottom;
        private Label score;
        private System.Windows.Forms.Timer gametimer;
    }
}
