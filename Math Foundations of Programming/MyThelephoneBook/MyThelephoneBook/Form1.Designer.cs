namespace MyThelephoneBook
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
            newBtn = new Button();
            saveBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            firstNameInput = new TextBox();
            lastNameInput = new TextBox();
            phoneInput = new TextBox();
            emailInput = new TextBox();
            dataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // newBtn
            // 
            newBtn.Font = new Font("Arial Rounded MT Bold", 12F);
            newBtn.Location = new Point(187, 472);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(137, 51);
            newBtn.TabIndex = 0;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(357, 472);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(131, 51);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Arial Rounded MT Bold", 11.25F);
            editBtn.Location = new Point(513, 472);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(131, 51);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Arial Rounded MT Bold", 11.25F);
            deleteBtn.Location = new Point(663, 472);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(131, 51);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(58, 26);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(58, 56);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(58, 85);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(58, 114);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(178, 23);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(750, 23);
            firstNameInput.TabIndex = 8;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(178, 53);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(750, 23);
            lastNameInput.TabIndex = 9;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(178, 85);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(750, 23);
            phoneInput.TabIndex = 10;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(178, 115);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(750, 23);
            emailInput.TabIndex = 11;
            // 
            // dataView
            // 
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.BackgroundColor = SystemColors.ButtonHighlight;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(58, 159);
            dataView.Name = "dataView";
            dataView.Size = new Size(884, 292);
            dataView.TabIndex = 12;
            dataView.CellDoubleClick += dataView_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(987, 546);
            Controls.Add(dataView);
            Controls.Add(emailInput);
            Controls.Add(phoneInput);
            Controls.Add(lastNameInput);
            Controls.Add(firstNameInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(saveBtn);
            Controls.Add(newBtn);
            Name = "Form1";
            Text = "AlexParvanov TelephoneBook";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newBtn;
        private Button saveBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox firstNameInput;
        private TextBox lastNameInput;
        private TextBox phoneInput;
        private TextBox emailInput;
        private DataGridView dataView;
    }
}
