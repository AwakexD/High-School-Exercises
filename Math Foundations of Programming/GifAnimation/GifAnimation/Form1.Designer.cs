namespace GifAnimation
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
            flyingBird = new PictureBox();
            birdTimer = new System.Windows.Forms.Timer(components);
            flyingBird2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)flyingBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flyingBird2).BeginInit();
            SuspendLayout();
            // 
            // flyingBird
            // 
            flyingBird.BackColor = Color.Transparent;
            flyingBird.Image = Properties.Resources.bird_wings_flying;
            flyingBird.Location = new Point(-25, 33);
            flyingBird.Name = "flyingBird";
            flyingBird.Size = new Size(199, 128);
            flyingBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flyingBird.TabIndex = 0;
            flyingBird.TabStop = false;
            // 
            // birdTimer
            // 
            birdTimer.Interval = 10;
            birdTimer.Tick += birdTimer_Tick;
            // 
            // flyingBird2
            // 
            flyingBird2.Image = Properties.Resources.giphy;
            flyingBird2.Location = new Point(1, 196);
            flyingBird2.Name = "flyingBird2";
            flyingBird2.Size = new Size(98, 99);
            flyingBird2.SizeMode = PictureBoxSizeMode.StretchImage;
            flyingBird2.TabIndex = 1;
            flyingBird2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(174, 207, 227);
            ClientSize = new Size(894, 511);
            Controls.Add(flyingBird2);
            Controls.Add(flyingBird);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AParvanov Animation";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)flyingBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)flyingBird2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox flyingBird;
        private System.Windows.Forms.Timer birdTimer;
        private PictureBox flyingBird2;
    }
}