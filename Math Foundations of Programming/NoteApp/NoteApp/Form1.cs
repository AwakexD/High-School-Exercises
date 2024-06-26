using System.Data;

namespace NoteApp
{
    public partial class NoteApp : Form
    {
        private DataTable notesTable = new();
        bool editing = false;

        public NoteApp()
        {
            InitializeComponent();
        }

        private void NoteApp_Load(object sender, EventArgs e)
        {
            notesTable.Columns.Add("Title");
            notesTable.Columns.Add("Note");

            notesView.DataSource = notesTable;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                notesTable.Rows[notesView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Note not found!");
            }
        }

        private void NewNoteBtn_Click(object sender, EventArgs e)
        {
            titleBox.Text = string.Empty;
            noteBox.Text = string.Empty;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            titleBox.Text = notesTable.Rows[notesView.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notesTable.Rows[notesView.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notesTable.Rows[notesView.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notesTable.Rows[notesView.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notesTable.Rows.Add(titleBox.Text, noteBox.Text);
            }

            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void notesView_DoubleClick(object sender, EventArgs e)
        {
            titleBox.Text = notesTable.Rows[notesView.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notesTable.Rows[notesView.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
