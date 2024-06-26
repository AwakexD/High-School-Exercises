namespace DagaTask
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p1 = new Pen(Color.Blue, 10);
            Pen p2 = new Pen(Color.Red, 10);
            Pen p3 = new Pen(Color.Yellow, 10);
            Pen p4 = new Pen(Color.Green, 10);
            Pen p5 = new Pen(Color.Magenta, 10);
            Pen p6 = new Pen(Color.Violet, 10);

            gr.DrawArc(p1, 100, 100, 500, 600, 180, 180);
            gr.DrawArc(p2, 110, 110, 480, 580, 180, 180);
            gr.DrawArc(p3, 120, 120, 460, 560, 180, 180);
            gr.DrawArc(p4, 130, 130, 440, 540, 180, 180);
            gr.DrawArc(p5, 140, 140, 420, 520, 180, 180);
            gr.DrawArc(p6, 150, 150, 400, 500, 180, 180);

            base.OnPaint(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
