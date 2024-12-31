namespace flappy_bird
{
    public partial class game : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int myscore = 0;
        public game()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;
            score.Text = myscore.ToString();

            if (pipeBottom.Left < -180)
            {
                pipeBottom.Left = 700;
                myscore++;
            }
            if (pipeTop.Left < -130)
            {
                pipeTop.Left = 790;
                myscore++;
            }

            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25)
            { 

                endGame();
            }
        }
        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -5;

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = +5;
        }
        private void endGame()
        {
            gametimer.Stop();
            score.Text += " - Game Over!";
        }
    }
}
