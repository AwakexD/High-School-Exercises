namespace RacingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            car = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            overText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(204, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 78);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Location = new Point(204, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 78);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Location = new Point(204, 238);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 78);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Location = new Point(204, 371);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 78);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonHighlight;
            pictureBox5.Location = new Point(204, 501);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(10, 78);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonHighlight;
            pictureBox6.Location = new Point(419, -1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(10, 547);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ButtonHighlight;
            pictureBox7.Location = new Point(12, -1);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(10, 547);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // car
            // 
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(87, 351);
            car.Name = "car";
            car.Size = new Size(51, 123);
            car.SizeMode = PictureBoxSizeMode.Zoom;
            car.TabIndex = 7;
            car.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(69, 21);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(51, 87);
            enemy1.SizeMode = PictureBoxSizeMode.Zoom;
            enemy1.TabIndex = 8;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(282, 51);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(48, 84);
            enemy2.SizeMode = PictureBoxSizeMode.Zoom;
            enemy2.TabIndex = 9;
            enemy2.TabStop = false;
            // 
            // overText
            // 
            overText.AutoSize = true;
            overText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            overText.ForeColor = Color.Lime;
            overText.Location = new Point(140, 250);
            overText.Name = "overText";
            overText.Size = new Size(148, 32);
            overText.TabIndex = 10;
            overText.Text = "Game Over!";
            overText.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(441, 541);
            Controls.Add(overText);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(car);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "RacingGame";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer1;
        private PictureBox car;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private Label overText;
    }
}
