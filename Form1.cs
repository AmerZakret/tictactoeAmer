using System.Numerics;

namespace tictactoeAmer
{
    public partial class Form1 : Form
    {
        Boolean turnChecker = true;
        int turnCounter = 0;
        Boolean ended = false;

        public void whoWins(String player)
        {
            if (player == "X")
            {
                MessageBox.Show("Player X wins");
                scoreX.Text = (Int32.Parse(scoreX.Text) + 1).ToString();
                ended = true;
            }
            else
            {
                MessageBox.Show("Player O wins");
                scoreO.Text = (Int32.Parse(scoreO.Text) + 1).ToString();
                ended = true;
            }

        }

        public void winCheck(String player)
        {
            if (button1.Text == player && button2.Text == player && button3.Text == player)
            {
                button1.BackColor = Color.Green; button2.BackColor = Color.Green; button3.BackColor = Color.Green;
                whoWins(player);
            }
            if (button4.Text == player && button5.Text == player && button6.Text == player)
            {
                button4.BackColor = Color.Green; button5.BackColor = Color.Green; button6.BackColor = Color.Green;
                whoWins(player);
            }
            if (button7.Text == player && button8.Text == player && button9.Text == player)
            {
                button7.BackColor = Color.Green; button8.BackColor = Color.Green; button9.BackColor = Color.Green;
                whoWins(player);
            }
            if (button1.Text == player && button4.Text == player && button7.Text == player)
            {
                button1.BackColor = Color.Green; button4.BackColor = Color.Green; button7.BackColor = Color.Green;
                whoWins(player);
            }
            if (button2.Text == player && button5.Text == player && button8.Text == player)
            {
                button2.BackColor = Color.Green; button5.BackColor = Color.Green; button8.BackColor = Color.Green;
                whoWins(player);
            }
            if (button3.Text == player && button6.Text == player && button9.Text == player)
            {
                button3.BackColor = Color.Green; button6.BackColor = Color.Green; button9.BackColor = Color.Green;
                whoWins(player);
            }
            if (button1.Text == player && button5.Text == player && button9.Text == player)
            {
                button1.BackColor = Color.Green; button5.BackColor = Color.Green; button9.BackColor = Color.Green;
                whoWins(player);
            }
            if (button3.Text == player && button5.Text == player && button7.Text == player)
            {
                button3.BackColor = Color.Green; button5.BackColor = Color.Green; button7.BackColor = Color.Green;
                whoWins(player);
            }
            if (turnCounter == 9 && !ended)
            {
                MessageBox.Show("Draw");
            }

        }

        public void lockBoard()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        public void boardClear()
        {
            ended = false;
            turnChecker = true;
            turnCounter = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


        }
        public void scoreClear()
        {
            scoreO.Text = "0";
            scoreX.Text = "0";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button1.Enabled = false;
            if (turnChecker)
            {
                button1.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button1.Text = "O";
                winCheck("O");
                turnChecker = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            boardClear();
            scoreClear();
        }

        private void nextRound_Click(object sender, EventArgs e)
        {
            boardClear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button2.Enabled = false;
            if (turnChecker)
            {
                button2.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button2.Text = "O";
                winCheck("O");
                turnChecker = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button3.Enabled = false;
            if (turnChecker)
            {
                button3.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button3.Text = "O";
                winCheck("O");
                turnChecker = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button4.Enabled = false;
            if (turnChecker)
            {
                button4.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button4.Text = "O";
                winCheck("O");
                turnChecker = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button5.Enabled = false;
            if (turnChecker)
            {
                button5.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button5.Text = "O";
                winCheck("O");
                turnChecker = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button6.Enabled = false;
            if (turnChecker)
            {
                button6.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button6.Text = "O";
                winCheck("O");
                turnChecker = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button7.Enabled = false;
            if (turnChecker)
            {
                button7.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button7.Text = "O";
                winCheck("O");
                turnChecker = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button8.Enabled = false;
            if (turnChecker)
            {
                button8.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button8.Text = "O";
                winCheck("O");
                turnChecker = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            turnCounter++;
            button9.Enabled = false;
            if (turnChecker)
            {
                button9.Text = "X";
                winCheck("X");
                turnChecker = false;
            }
            else
            {
                button9.Text = "O";
                winCheck("O");
                turnChecker = true;
            }
        }
    }
}
