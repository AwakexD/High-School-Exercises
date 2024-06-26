using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTriangle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int x1 = Form1.x;
            int y1 = Form1.y;
            int side = Form1.p;

            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.FromArgb(0, 0, 0), 2);
            int h = (int)(side * Math.Sqrt(3) / 2);
            int y3 = y1 - h;
            int x3 = x1 + side / 2;
            int x2 = x1 + side;
            int y2 = y1;

            g.DrawLine(myPen, x1, y1, x2, y2);
            g.DrawLine(myPen, x2, y2, x3, y3);
            g.DrawLine(myPen, x1, y1, x3, y3);

        }
    }
}
