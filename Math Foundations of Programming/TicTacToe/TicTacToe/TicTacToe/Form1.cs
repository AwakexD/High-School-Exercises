namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int turn = 0;
        private Button[,] buttons = new Button[3, 3];

        public Form1()
        {
            InitializeComponent();

            int i = 0;
            foreach (Control x in Controls)
            {
                if (x is Button && i < 9)
                {
                    int row = i / 3;
                    int col = i % 3;
                    buttons[row, col] = (Button)x;
                    x.Click += X_Click;
                    i++;
                }
            }
        }

        private void CheckWin()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text != "" &&
                    buttons[i, 0].Text == buttons[i, 1].Text &&
                    buttons[i, 0].Text == buttons[i, 2].Text)
                {
                    MessageBox.Show(buttons[i, 0].Text + " wins!");
                    ResetGame();
                    return;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0, i].Text != "" &&
                    buttons[0, i].Text == buttons[1, i].Text &&
                    buttons[0, i].Text == buttons[2, i].Text)
                {
                    MessageBox.Show(buttons[0, i].Text + " wins!");
                    ResetGame();
                    return;
                }
            }

            // Check diagonals
            if (buttons[0, 0].Text != "" &&
                buttons[0, 0].Text == buttons[1, 1].Text &&
                buttons[0, 0].Text == buttons[2, 2].Text)
            {
                MessageBox.Show(buttons[0, 0].Text + " wins!");
                ResetGame();
                return;
            }

            if (buttons[0, 2].Text != "" &&
                buttons[0, 2].Text == buttons[1, 1].Text &&
                buttons[0, 2].Text == buttons[2, 0].Text)
            {
                MessageBox.Show(buttons[0, 2].Text + " wins!");
                ResetGame();
                return;
            }

            // Check for draw
            bool allFilled = true;
            foreach (Button btn in buttons)
            {
                if (btn.Text == "")
                {
                    allFilled = false;
                    break;
                }
            }

            if (allFilled)
            {
                MessageBox.Show("It's a draw!");
                ResetGame();
            }
        }

        private void X_Click(object? sender, EventArgs e)
        {
            if (((Button)sender).Text != "") { return; }

            if (turn % 2 == 0)
            {
                ((Button)sender).Text = "X";
            }
            else
            {
                ((Button)sender).Text = "O";
            }

            turn++;
            CheckWin();
        }

        private void ResetGame()
        {
            foreach (Button btn in buttons)
            {
                btn.Text = "";
            }
            turn = 0;
        }
    }

}
