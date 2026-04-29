/*
 * Jorge Ortiz
 *CPT 185 - A01H
 *Lab 2
 */
namespace JOrtizLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pBoxKing_Click(object sender, EventArgs e)
        {
            lblNameofCard.Text = "King of Diamonds";
        }

        private void pBoxAce_Click(object sender, EventArgs e)
        {
            lblNameofCard.Text = "Ace of Spades";
        }

        private void pBoxQueen_Click(object sender, EventArgs e)
        {
            lblNameofCard.Text = "Queen of Spades";
        }

        private void pBoxJack_Click(object sender, EventArgs e)
        {
            lblNameofCard.Text = "Jack of Hearts";
        }

        private void pBoxClub_Click(object sender, EventArgs e)
        {
            lblNameofCard.Text = "Seven of Clubs";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
