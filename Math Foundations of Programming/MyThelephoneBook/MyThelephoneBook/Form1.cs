using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace MyThelephoneBook
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        private bool editing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");

            dataView.DataSource = dt;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            firstNameInput.Text = string.Empty;
            lastNameInput.Text = string.Empty;
            phoneInput.Text = string.Empty;
            emailInput.Text = string.Empty;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            firstNameInput.Text = dt.Rows[dataView.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameInput.Text = dt.Rows[dataView.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneInput.Text = dt.Rows[dataView.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailInput.Text = dt.Rows[dataView.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                dt.Rows[dataView.CurrentCell.RowIndex]["First Name"] = firstNameInput.Text;
                dt.Rows[dataView.CurrentCell.RowIndex]["Last Name"] = lastNameInput.Text;
                dt.Rows[dataView.CurrentCell.RowIndex]["Phone"] = phoneInput.Text;
                dt.Rows[dataView.CurrentCell.RowIndex]["Email"] = emailInput.Text;
            }
            else
            {
                dt.Rows.Add(firstNameInput.Text, lastNameInput.Text, phoneInput.Text, emailInput.Text);
            }

            firstNameInput.Text = string.Empty;
            lastNameInput.Text = string.Empty;
            phoneInput.Text = string.Empty;
            emailInput.Text = string.Empty;
            editing = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows[dataView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void dataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            firstNameInput.Text = dt.Rows[dataView.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameInput.Text = dt.Rows[dataView.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneInput.Text = dt.Rows[dataView.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailInput.Text = dt.Rows[dataView.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }
    }
}
