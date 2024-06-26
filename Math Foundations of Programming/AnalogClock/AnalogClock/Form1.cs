using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        Timer clockTimer = new Timer();

        int clockWidth = 300, clockHeight = 300, secondHandLength = 140, minuteHandLength = 110, hourHandLength = 80;

        int centerX, centerY;

        Bitmap clockBitmap;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clockBitmap = new Bitmap(clockWidth + 1, clockHeight + 1);

            centerX = clockWidth / 2;
            centerY = clockHeight / 2;

            this.BackColor = Color.White;

            clockTimer.Interval = 1000;
            clockTimer.Tick += new EventHandler(this.ClockTimer_Tick);
            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(clockBitmap);

            int seconds = DateTime.Now.Second;
            int minutes = DateTime.Now.Minute;
            int hours = DateTime.Now.Hour;

            int[] handCoordinates = new int[2];

            graphics.Clear(Color.White);

            graphics.DrawEllipse(new Pen(Color.Black, 2), 0, 0, clockWidth, clockHeight);

            DrawClockNumbers(clockWidth, clockHeight);

            handCoordinates = MinuteSecondCoordinates(seconds, secondHandLength);
            graphics.DrawLine(new Pen(Color.Red, 1f), new Point(centerX, centerY), new Point(handCoordinates[0], handCoordinates[1]));

            handCoordinates = MinuteSecondCoordinates(minutes, minuteHandLength);
            graphics.DrawLine(new Pen(Color.Blue, 2f), new Point(centerX, centerY), new Point(handCoordinates[0], handCoordinates[1]));

            handCoordinates = HourCoordinates(hours % 12, minutes, hourHandLength);
            graphics.DrawLine(new Pen(Color.PaleGreen , 3f), new Point(centerX, centerY), new Point(handCoordinates[0], handCoordinates[1]));

            pictureBox1.Image = clockBitmap;

            this.Text = "Analog Clock -  " + hours + ":" + minutes + ":" + seconds;
            graphics.Dispose();
        }

        private void DrawClockNumbers(int width, int height)
        {
            width = width - 20;
            height = height - 20;

            using (Font numberFont = new Font("Arial", 12))
            {
                for (int i = 1; i <= 12; i++)
                {
                    double angle = Math.PI / 6 * (i - 3);
                    int x = (int)(centerX + width / 2 * Math.Cos(angle) - 8);
                    int y = (int)(centerY + height / 2 * Math.Sin(angle) - 8);
                    graphics.DrawString(i.ToString(), numberFont, Brushes.Black, new PointF(x, y));
                }
            }
        }

        private int[] MinuteSecondCoordinates(int value, int length)
        {
            int[] coordinates = new int[2];
            value *= 6;

            if (value >= 0 && value <= 180)
            {
                coordinates[0] = centerX + (int)(length * Math.Sin(Math.PI * value / 180));
                coordinates[1] = centerY - (int)(length * Math.Cos(Math.PI * value / 180));
            }
            else
            {
                coordinates[0] = centerX - (int)(length * -Math.Sin(Math.PI * value / 180));
                coordinates[1] = centerY - (int)(length * Math.Cos(Math.PI * value / 180));
            }
            return coordinates;
        }

        private int[] HourCoordinates(int hourValue, int minuteValue, int length)
        {
            int[] coordinates = new int[2];

            int value = (int)((hourValue * 30) + (minuteValue * 0.5));

            if (value >= 0 && value <= 180)
            {
                coordinates[0] = centerX + (int)(length * Math.Sin(Math.PI * value / 180));
                coordinates[1] = centerY - (int)(length * Math.Cos(Math.PI * value / 180));
            }
            else
            {
                coordinates[0] = centerX - (int)(length * -Math.Sin(Math.PI * value / 180));
                coordinates[1] = centerY - (int)(length * Math.Cos(Math.PI * value / 180));
            }
            return coordinates;
        }
    }
}