using System.Diagnostics;

namespace WinFormsPaint
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Pen pen = new Pen(Color.Black, 5);
        int x = -1;
        int y = -1;
        bool moving = false;

        public Form1()
        {
            InitializeComponent();
            gr = panel1.CreateGraphics();
        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                gr.DrawLine(pen, new Point(x, y), e.Location);
            }
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        // Change color buttons
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pen.Color = Color.DarkOrchid;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pen.Color = Color.MediumBlue;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Gold;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pen.Color = Color.LimeGreen;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }
    }
}
