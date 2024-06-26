namespace GifAnimation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birdTimer.Enabled = true;
        }
        private void birdTimer_Tick(object sender, EventArgs e)
        {
            flyingBird.Left += 1;
            flyingBird2.Left += 1;
            flyingBird2.Top += 1;
        }
    }
}