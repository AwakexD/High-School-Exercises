using System.Windows.Forms;

namespace DrawRandomLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawRandomLines();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawRandomLines()
        {
            Random random = new Random();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.White); // Фон

            for (int i = 0; i < 10; i++)
            {
                int x = i * 50; // Позиция на линията
                int lineHeight = random.Next(100, 300); // Генериране на случайна дълцина
                Color lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // Генериране на случаен цвят

                using (Pen pen = new Pen(lineColor, 2))
                {
                    graphics.DrawLine(pen, x, 0, x, lineHeight);
                }
            }

            pictureBox1.Image = bitmap;
            graphics.Dispose();
        }
    }
}