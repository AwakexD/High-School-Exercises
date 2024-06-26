using System.Threading;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        private int gamespeed = 0;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            this.random = new Random();
            overText.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gamespeed);
            Enemy(gamespeed);
            GameOver();
        }

        private void GameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                overText.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                overText.Visible = true;
            }
        }

        private void Enemy(int speed)
        {
            int x1, y1;
            int x2, y2;
            if (enemy1.Top >= 500)
            {
                x1 = random.Next(0, 300);
                y1 = random.Next(0, 450);
                enemy1.Location = new Point(x1, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x2 = random.Next(0, 300);
                y2 = random.Next(0, 450);
                enemy2.Location = new Point(x2, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
        }

        private void MoveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                {
                    car.Left += -20;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (car.Left < 370)
                {
                    car.Left += 20;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
