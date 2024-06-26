namespace QuizGame
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
            textBox1 = new TextBox();
            option1 = new RadioButton();
            option2 = new RadioButton();
            option3 = new RadioButton();
            option4 = new RadioButton();
            nextBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(28, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(601, 176);
            textBox1.TabIndex = 0;
            // 
            // option1
            // 
            option1.AutoSize = true;
            option1.Font = new Font("Segoe UI", 12F);
            option1.Location = new Point(40, 242);
            option1.Name = "option1";
            option1.Size = new Size(119, 25);
            option1.TabIndex = 1;
            option1.TabStop = true;
            option1.Text = "radioButton1";
            option1.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            option2.AutoSize = true;
            option2.Font = new Font("Segoe UI", 12F);
            option2.Location = new Point(40, 290);
            option2.Name = "option2";
            option2.Size = new Size(119, 25);
            option2.TabIndex = 2;
            option2.TabStop = true;
            option2.Text = "radioButton2";
            option2.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            option3.AutoSize = true;
            option3.Font = new Font("Segoe UI", 12F);
            option3.Location = new Point(40, 340);
            option3.Name = "option3";
            option3.Size = new Size(119, 25);
            option3.TabIndex = 3;
            option3.TabStop = true;
            option3.Text = "radioButton3";
            option3.UseVisualStyleBackColor = true;
            // 
            // option4
            // 
            option4.AutoSize = true;
            option4.Font = new Font("Segoe UI", 12F);
            option4.Location = new Point(40, 389);
            option4.Name = "option4";
            option4.Size = new Size(119, 25);
            option4.TabIndex = 4;
            option4.TabStop = true;
            option4.Text = "radioButton4";
            option4.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextBtn.Location = new Point(223, 450);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(226, 64);
            nextBtn.TabIndex = 5;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 536);
            Controls.Add(nextBtn);
            Controls.Add(option4);
            Controls.Add(option3);
            Controls.Add(option2);
            Controls.Add(option1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RadioButton option1;
        private RadioButton option2;
        private RadioButton option3;
        private RadioButton option4;
        private Button nextBtn;
    }
}
