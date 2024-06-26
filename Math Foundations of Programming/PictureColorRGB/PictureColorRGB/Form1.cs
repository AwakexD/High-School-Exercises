namespace PictureColorRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string img = Path.Combine(Application.StartupPath, "snimka.jpg");

            Bitmap bmp = new Bitmap(img);

            pictureBox1.Image = Image.FromFile(img);

            int width = bmp.Width;
            int height = bmp.Height;

            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    Color p = bmp.GetPixel(x, y);


                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;


                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                }
            }

            pictureBox2.Image = rbmp;
            pictureBox3.Image = gbmp;
            pictureBox4.Image = bbmp;

            rbmp.Save(Path.Combine(Application.StartupPath, "Red.jpg"));
            gbmp.Save(Path.Combine(Application.StartupPath, "Green.jpg"));
            bbmp.Save(Path.Combine(Application.StartupPath, "Blue.jpg"));
        }
    }
}