namespace TicTacToeGUI
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        public static int GameCount = 0;

        private void TopLeftBtn_Click(object sender, EventArgs e)
        {
            if (TopLeftBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    TopLeftBtn.Text = "X";
                }
                else
                {
                    TopLeftBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }

        private void TopMiddleBtn_Click(object sender, EventArgs e)
        {
            if (TopMiddleBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    TopMiddleBtn.Text = "X";
                }
                else
                {
                    TopMiddleBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }

        private void TopRightBtn_Click(object sender, EventArgs e)
        {
            if (TopRightBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    TopRightBtn.Text = "X";
                }
                else
                {
                    TopRightBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }

        private void MiddleLeftBtn_Click(object sender, EventArgs e)
        {
            if (MiddleLeftBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    MiddleLeftBtn.Text = "X";
                }
                else
                {
                    MiddleLeftBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }

        private void MiddleMiddleBtn_Click(object sender, EventArgs e)
        {
            if (MiddleMiddleBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    MiddleMiddleBtn.Text = "X";
                }
                else
                {
                    MiddleMiddleBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }

        private void MiddleRightBtn_Click(object sender, EventArgs e)
        {
            if (MiddleRightBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    MiddleRightBtn.Text = "X";
                }
                else
                {
                    MiddleRightBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }

        private void BottomLeftBtn_Click(object sender, EventArgs e)
        {
            if (BottomLeftBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    BottomLeftBtn.Text = "X";
                }
                else
                {
                    BottomLeftBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }

        private void BottomMiddleBtn_Click(object sender, EventArgs e)
        {
            if (BottomMiddleBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    BottomMiddleBtn.Text = "X";
                }
                else
                {
                    BottomMiddleBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }

        private void BottomRightBtn_Click(object sender, EventArgs e)
        {
            if (BottomRightBtn.Text != "")
            {
                MessageBox.Show("This spot is already taken.");
            }
            else
            {
                if (GameCount % 2 == 0)
                {
                    BottomRightBtn.Text = "X";
                }
                else
                {
                    BottomRightBtn.Text = "O";
                }

                GameCount++;
                CheckWinner();
            }
        }
        //check winner method (JS)
        private void CheckWinner()
        {
            string winner = "";

            // Check rows
            if (TopLeftBtn.Text != "" &&
                TopLeftBtn.Text == TopMiddleBtn.Text &&
                TopMiddleBtn.Text == TopRightBtn.Text)
            {
                winner = TopLeftBtn.Text;
            }
            else if (MiddleLeftBtn.Text != "" &&
                     MiddleLeftBtn.Text == MiddleMiddleBtn.Text &&
                     MiddleMiddleBtn.Text == MiddleRightBtn.Text)
            {
                winner = MiddleLeftBtn.Text;
            }
            else if (BottomLeftBtn.Text != "" &&
                     BottomLeftBtn.Text == BottomMiddleBtn.Text &&
                     BottomMiddleBtn.Text == BottomRightBtn.Text)
            {
                winner = BottomLeftBtn.Text;
            }

            // Check columns
            else if (TopLeftBtn.Text != "" &&
                     TopLeftBtn.Text == MiddleLeftBtn.Text &&
                     MiddleLeftBtn.Text == BottomLeftBtn.Text)
            {
                winner = TopLeftBtn.Text;
            }
            else if (TopMiddleBtn.Text != "" &&
                     TopMiddleBtn.Text == MiddleMiddleBtn.Text &&
                     MiddleMiddleBtn.Text == BottomMiddleBtn.Text)
            {
                winner = TopMiddleBtn.Text;
            }
            else if (TopRightBtn.Text != "" &&
                     TopRightBtn.Text == MiddleRightBtn.Text &&
                     MiddleRightBtn.Text == BottomRightBtn.Text)
            {
                winner = TopRightBtn.Text;
            }

            // Check diagonals
            else if (TopLeftBtn.Text != "" &&
                     TopLeftBtn.Text == MiddleMiddleBtn.Text &&
                     MiddleMiddleBtn.Text == BottomRightBtn.Text)
            {
                winner = TopLeftBtn.Text;
            }
            else if (TopRightBtn.Text != "" &&
                     TopRightBtn.Text == MiddleMiddleBtn.Text &&
                     MiddleMiddleBtn.Text == BottomLeftBtn.Text)
            {
                winner = TopRightBtn.Text;
            }

            if (winner != "")
            {
                GameLbl.Text = winner + " Wins!";
                DisableButtons();
            }
            else if (GameCount == 9)
            {
                GameLbl.Text = "Tie Game!";
                DisableButtons();
            }
        }

        private void DisableButtons()
        {
            TopLeftBtn.Enabled = false;
            TopMiddleBtn.Enabled = false;
            TopRightBtn.Enabled = false;

            MiddleLeftBtn.Enabled = false;
            MiddleMiddleBtn.Enabled = false;
            MiddleRightBtn.Enabled = false;

            BottomLeftBtn.Enabled = false;
            BottomMiddleBtn.Enabled = false;
            BottomRightBtn.Enabled = false;
        }
        //Needed to add a new game button (JS)
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            TopLeftBtn.Text = "";
            TopMiddleBtn.Text = "";
            TopRightBtn.Text = "";

            MiddleLeftBtn.Text = "";
            MiddleMiddleBtn.Text = "";
            MiddleRightBtn.Text = "";

            BottomLeftBtn.Text = "";
            BottomMiddleBtn.Text = "";
            BottomRightBtn.Text = "";

            TopLeftBtn.Enabled = true;
            TopMiddleBtn.Enabled = true;
            TopRightBtn.Enabled = true;

            MiddleLeftBtn.Enabled = true;
            MiddleMiddleBtn.Enabled = true;
            MiddleRightBtn.Enabled = true;

            BottomLeftBtn.Enabled = true;
            BottomMiddleBtn.Enabled = true;
            BottomRightBtn.Enabled = true;

            GameLbl.Text = "";
            GameCount = 0;
        }
    }
}