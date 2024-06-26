namespace NoteApp
{
    partial class NoteApp
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
            titleBox = new TextBox();
            noteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            notesView = new DataGridView();
            LoadBtn = new Button();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            NewNoteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)notesView).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(430, 34);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(358, 23);
            titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(430, 82);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(358, 284);
            noteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(430, 16);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(430, 64);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Note";
            // 
            // notesView
            // 
            notesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notesView.BackgroundColor = SystemColors.ButtonHighlight;
            notesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notesView.Location = new Point(12, 16);
            notesView.Name = "notesView";
            notesView.RowTemplate.Height = 25;
            notesView.Size = new Size(391, 350);
            notesView.TabIndex = 4;
            notesView.DoubleClick += notesView_DoubleClick;
            // 
            // LoadBtn
            // 
            LoadBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoadBtn.Location = new Point(27, 380);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(157, 58);
            LoadBtn.TabIndex = 5;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.Location = new Point(221, 380);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(170, 58);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Location = new Point(430, 380);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(173, 58);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // NewNoteBtn
            // 
            NewNoteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewNoteBtn.Location = new Point(623, 380);
            NewNoteBtn.Name = "NewNoteBtn";
            NewNoteBtn.Size = new Size(165, 58);
            NewNoteBtn.TabIndex = 8;
            NewNoteBtn.Text = "New Note";
            NewNoteBtn.UseVisualStyleBackColor = true;
            NewNoteBtn.Click += NewNoteBtn_Click;
            // 
            // NoteApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(NewNoteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(LoadBtn);
            Controls.Add(notesView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Name = "NoteApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteApp";
            Load += NoteApp_Load;
            ((System.ComponentModel.ISupportInitialize)notesView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label label1;
        private Label label2;
        private DataGridView notesView;
        private Button LoadBtn;
        private Button DeleteBtn;
        private Button SaveBtn;
        private Button NewNoteBtn;
    }
}
