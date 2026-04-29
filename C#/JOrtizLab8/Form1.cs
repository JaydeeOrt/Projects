/*
 * Jorge Ortiz
 * CPT 185 - A01H
 * Lab 8
 */
namespace JOrtizLab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Do the clear stuff
            rtxtBox.Clear();
            rtxtBoxTranslation.Clear();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> alphabet = new Dictionary<char, string>()
            {
                {' '," "}, {',',"--..--"}, {'.',".-.-.-"}, {'?',"..--.."}, {'0',"----"}, {'1',".----"}, {'2'," ..---"}, {'3',"...--"},
                {'4',"....-"}, {'5',"....."}, {'6',"-...."}, {'7',"--..."}, {'8',"---.."}, {'9',"----."}, {'\n',"\n"},
                {'A',".-"},{'B',"-..."},{'C',"-.-."},{'D',"-.."},{'E',"."},{'F',"..-."},{'G',"--."},{'H',"...."},{'I',".."},{'J',".---"},
                {'K',"-.-"},{'L',".-.."},{'M',"--"},{'N',"-."},{'O',"---"},{'P',".--."},{'Q',"--.-"},{'R',".-."},{'S',"..."},{'T',"-"},
                {'U',"..-"},{'V',"...-"},{'W',".--"},{'X',"-..-"},{'Y',"-.--"},{'Z',"--.."}
            };

            string userInput = rtxtBox.Text.TrimEnd('\n');
            try
            {
                for (int i = 0; i < userInput.Length; i++)
                {
                    char letter = userInput[i];

                    if (alphabet.ContainsKey(char.ToUpper(letter)))
                    {

                        rtxtBoxTranslation.AppendText(alphabet[char.ToUpper(letter)] + " ");
                    }
                    else 
                    {
                        MessageBox.Show($"+{letter}+");
                        throw new Exception();
                    }
                }
            }
            catch
            {
                MessageBox.Show("An error has occured please try again", "Error");
                rtxtBoxTranslation.Clear();
            }
        }
    }
}
