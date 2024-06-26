namespace _4WayMovement
{
    public partial class Form1 : Form
    {
        private Image playerImage;
        private List<string> playerMovements = new List<string>();
        private int steps = 0;
        private int animationFrameCount = 0;
        private bool isMovingLeft, isMovingRight, isMovingUp, isMovingDown;
        private int playerXCoordinate;
        private int playerYCoordinate;
        private const int playerHeight = 100;
        private const int playerWidth = 100;
        private const int playerSpeed = 8;

        public Form1()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isMovingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                isMovingRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                isMovingUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                isMovingDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isMovingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                isMovingRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                isMovingUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                isMovingDown = false;
            }
        }

        private void PaintEvent(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.DrawImage(playerImage, playerXCoordinate, playerYCoordinate, playerWidth, playerHeight);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (isMovingLeft && playerXCoordinate > 0)
            {
                playerXCoordinate -= playerSpeed;
                AnimatePlayer(4, 7);
            }
            else if (isMovingRight && playerXCoordinate + playerWidth < ClientSize.Width)
            {
                playerXCoordinate += playerSpeed;
                AnimatePlayer(8, 11);
            }
            else if (isMovingUp && playerYCoordinate > 0)
            {
                playerYCoordinate -= playerSpeed;
                AnimatePlayer(12, 15);
            }
            else if (isMovingDown && playerYCoordinate + playerHeight < ClientSize.Height)
            {
                playerYCoordinate += playerSpeed;
                AnimatePlayer(0, 3);
            }
            else
            {
                AnimatePlayer(0, 0);
            }
            this.Invalidate();
            label1.Text = "Movements: " + steps;
        }

        private void SetUpGame()
        {
            this.BackgroundImage = Image.FromFile("background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;

            playerMovements = Directory.GetFiles("player", "*.png").ToList();
            playerImage = Image.FromFile(playerMovements[0]);
        }

        private void AnimatePlayer(int start, int end)
        {
            animationFrameCount += 1;
            if (animationFrameCount == 4)
            {
                steps++;
                animationFrameCount = 0;
            }
            if (steps > end || steps < start)
            {
                steps = start;
            }
            playerImage = Image.FromFile(playerMovements[steps]);
        }
    }
}
