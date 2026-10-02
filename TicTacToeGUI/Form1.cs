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
            if (GameCount % 2 == 0)
            {
                TopLeftBtn.Text = "X";
            }
            else
            {
                TopLeftBtn.Text = "O";
            }
            if (TopLeftBtn.Text != "")
            {
                GameCount++;
            }
        }
        private void TopMiddleBtn_Click(object sender, EventArgs e)
        {
            if (GameCount % 2 == 0)
            {
                TopMiddleBtn.Text = "X";
            }
            else
            {
                TopMiddleBtn.Text = "O";
            }
            if (TopMiddleBtn.Text != "")
            {
                GameCount++;
            }
        }
        private void TopRightBtn_Click(object sender, EventArgs e)
        {
            if (GameCount % 2 == 0)
            {
                TopRightBtn.Text = "X";
            }
            else
            {
                TopRightBtn.Text = "O";
            }
            if (TopRightBtn.Text != "")
            {
                GameCount++;
            }
        }

        private void MiddleLeftBtn_Click(object sender, EventArgs e)
        {
            if (GameCount % 2 == 0)
            {
                MiddleLeftBtn.Text = "X";
            }
            else
            {
                MiddleLeftBtn.Text = "O";
            }
            if (MiddleLeftBtn.Text != "")
            {
                GameCount++;
            }

        }

        private void MiddleMiddleBtn_Click(object sender, EventArgs e)
        {
            if (GameCount % 2 == 0)
            {
                MiddleMiddleBtn.Text = "X";
            }
            else
            {
                MiddleMiddleBtn.Text = "O";
            }
            if (MiddleMiddleBtn.Text != "")
            {
                GameCount++;
            }
        }

        private void MiddleRightBtn_Click(object sender, EventArgs e)
        {
            if (GameCount % 2 == 0)
            {
                MiddleRightBtn.Text = "X";
            }
            else
            {
                MiddleRightBtn.Text = "O";
            }
            if (MiddleRightBtn.Text != "")
            {
                GameCount++;
            }
        }

        private void BottomLeftBtn_Click(object sender, EventArgs e)
        {
            if (GameCount % 2 == 0)
            {
                BottomLeftBtn.Text = "X";
            }
            else
            {
                BottomLeftBtn.Text = "O";
            }
            if (BottomLeftBtn.Text != "")
            {
                GameCount++;
            }
        }
        private void BottomMiddleBtn_Click(object sender, EventArgs e)
        {
            if (GameCount % 2 == 0)
            {
                BottomMiddleBtn.Text = "X";
            }
            else
            {
                BottomMiddleBtn.Text = "O";
            }
            if (BottomMiddleBtn.Text != "")
            {
                GameCount++;
            }

        }
        private void BottomRightBtn_Click(object sender, EventArgs e)
        {
            if (GameCount % 2 == 0)
            {
                BottomRightBtn.Text = "X";
            }
            else
            {
                BottomRightBtn.Text = "O";
            }
            if (BottomRightBtn.Text != "")
            {
                GameCount++;
            }

        }
    }
}
