using Timer = System.Windows.Forms.Timer;

namespace RadarTask10
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        int WIDTH = 300;
        int HEIGHT = 300;
        int HAND = 150;

        int u;  
        int cx, cy;     
        int x, y;   

        int tx, ty, lim = 20;

        Bitmap bmp;
        Pen p;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            this.BackColor = Color.FromArgb(0, 0, 0);

            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            u = 0;

            t.Interval = 5;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            p = new Pen(Color.Green, 1);

            g = Graphics.FromImage(bmp);

            //Hand cordinates
            int tu = (u - lim) % 360;

            if (u >= 0 && u <= 180)
            {

                x = cx + (int)(HAND * Math.Sin(Math.PI * u / 180));
                y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));
            }
            else
            {
                x = cx - (int)(HAND * -Math.Sin(Math.PI * u / 180));
                y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));
            }

            if (tu >= 0 && tu <= 180)
            {

                tx = cx + (int)(HAND * Math.Sin(Math.PI * tu / 180));
                ty = cy - (int)(HAND * Math.Cos(Math.PI * tu / 180));
            }
            else
            {
                tx = cx - (int)(HAND * -Math.Sin(Math.PI * tu / 180));
                ty = cy - (int)(HAND * Math.Cos(Math.PI * tu / 180));
            }

            g.DrawEllipse(p, 0, 0, WIDTH, HEIGHT);  
            g.DrawEllipse(p, 80, 80, WIDTH - 160, HEIGHT - 160);    


            g.DrawLine(p, new Point(cx, 0), new Point(cx, HEIGHT)); 
            g.DrawLine(p, new Point(0, cy), new Point(WIDTH, cy)); 

            g.DrawLine(new Pen(Color.Black, 1f), new Point(cx, cy), new Point(tx, ty));
            g.DrawLine(p, new Point(cx, cy), new Point(x, y));

            pictureBox1.Image = bmp;

            p.Dispose();
            g.Dispose();

            u++;
            if (u == 360)
            {
                u = 0;
            }
        }
    }
}
