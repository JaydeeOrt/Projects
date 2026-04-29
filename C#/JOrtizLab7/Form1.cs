/*
 * Jorge Ortiz
 * CPT 185 - A01H
 * Lab 7
 */
using System.Security.Policy;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.LinkLabel;

namespace JOrtizLab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string[] answers = {"1.B", "2. D", "3. A", "4. A", "5. C", "6. A",
            "7.B", "8.A", "9.C", "10. D", "11. B", "12. C", "13. D", "14. A",
            "15. D", "16. C", "17. C", "18. B", "19. D", "20. A" };
            string[] userAnswers = new string[20];
            int correctCount = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string fileLocation = openFileDialog.FileName;
                try
                {
                    //tries to read file into array
                    userAnswers = File.ReadAllLines(fileLocation);


                }
                catch
                {
                    MessageBox.Show("Error opening answer text file");
                }
                lstBoxUserAnswers.Items.Add("New File");
                for (int i = 0; i < 20; i++)
                {
                    //Checks if last letter of the string in the array is the same as the answer array
                    if (userAnswers[i][userAnswers[i].Length - 1] == answers[i][answers[i].Length - 1])
                    {
                        lstBoxUserAnswers.Items.Add(answers[i]);
                        //count how many you get right
                        correctCount++;
                    }
                    else
                    {
                        //tells you which you got wrong
                        lstBoxUserAnswers.Items.Add("X " + answers[i] + " Incorrect");
                    }//endif

                }

                if (correctCount >= 15)
                {
                    lblCorrectCount.Text = $"You got {correctCount}/20 correct";
                    lblPassFail.Text = "You Pass!";
                    lblCorrectCount.Visible = true;
                    lblPassFail.Visible = true;
                    picBoxHappy.Visible = true;
                    picBoxSad.Visible = false;
                }
                else if (correctCount < 15)
                {
                    lblCorrectCount.Text = $"You got {correctCount}/20 correct";
                    lblPassFail.Text = "You Failed!";
                    lblCorrectCount.Visible = true;
                    lblPassFail.Visible = true;
                    picBoxHappy.Visible = false;
                    picBoxSad.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error Something went wrong ??");
                }//endif
                lblWrong.Text = $"You got {20 - correctCount} wrong";
                lblWrong.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxUserAnswers.Items.Clear();
            lblCorrectCount.Text = "";
            lblPassFail.Text = "";
            lblWrong.Text = "";
            lblCorrectCount.Visible = false;
            lblPassFail.Visible = false;
            lblWrong.Visible = false;
            picBoxHappy.Visible = false;
            picBoxSad.Visible = false;
        }
    }
}
