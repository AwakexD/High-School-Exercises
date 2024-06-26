namespace DrawTriangle
{
    public partial class Form1 : Form
    {
        public static int x;
        public static int y;
        public static int p;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox1.Text);
            p = int.Parse(textBox1.Text);

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        
    }
}