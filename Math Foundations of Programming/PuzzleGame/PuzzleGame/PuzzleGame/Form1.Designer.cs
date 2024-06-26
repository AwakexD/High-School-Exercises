namespace PuzzleGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button9 = new Button();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(58, 328);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(191, 27);
            button9.TabIndex = 3;
            button9.Text = "Start Game";
            button9.UseVisualStyleBackColor = true;
            button9.Click += startButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(21, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 274);
            panel1.TabIndex = 2;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Enabled = false;
            button8.Location = new Point(90, 180);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(90, 90);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Enabled = false;
            button7.Location = new Point(0, 180);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(90, 90);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Enabled = false;
            button6.Location = new Point(180, 90);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(90, 90);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Enabled = false;
            button5.Location = new Point(90, 90);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(90, 90);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Enabled = false;
            button4.Location = new Point(0, 90);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Enabled = false;
            button3.Location = new Point(180, 0);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Enabled = false;
            button2.Location = new Point(90, 0);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Enabled = false;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 90);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(326, 402);
            Controls.Add(button9);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Picture Puzzle";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
