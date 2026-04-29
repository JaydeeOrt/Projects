/*
 * Jorge Ortiz
 *CPT 185 - A01H
 *Lab 1
 */
namespace JOrtizLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcGrade_Click(object sender, EventArgs e)
        {
            double exams = 0.0;    //#4 45%
            double labs = 0.0;     //#5 35%
            double quizzes = 0.0;  //#5 20%
            double calcGrade = 0.0;
            char letterGrade = ' ';

            //Adds exam from exam textbox to exams variable and gets weight
            //exams = double.Parse(txtBoxExam1.Text,txtBoxExam2.Text,txtBoxExam3.Text,txtBoxExam4.Text);
            //i got confused and didnt remember how to intake everything in one line and split it up after 
            exams = double.Parse(txtBoxExam1.Text);
            exams += double.Parse(txtBoxExam2.Text);
            exams += double.Parse(txtBoxExam3.Text);
            exams += double.Parse(txtBoxExam4.Text);
            exams = exams / 4;
            exams *= 0.45;

            //Adds labs from labs textbox to labs variable and gets weight
            labs = double.Parse(txtBoxLab1.Text);
            labs += double.Parse(txtBoxLab2.Text);
            labs += double.Parse(txtBoxLab3.Text);
            labs += double.Parse(txtBoxLab4.Text);
            labs += double.Parse(txtBoxLab5.Text);
            labs = labs / 5;
            labs *= 0.35;

            //Adds quizzes from quizzes textbox to quizzes variable and gets weight
            quizzes = double.Parse(txtBoxQuiz1.Text);
            quizzes += double.Parse(txtBoxQuiz2.Text);
            quizzes += double.Parse(txtBoxQuiz3.Text);
            quizzes += double.Parse(txtBoxQuiz4.Text);
            quizzes += double.Parse(txtBoxQuiz5.Text);
            quizzes = quizzes / 5;
            quizzes *= 0.20;

            //Calc
            calcGrade = exams + quizzes + labs;
            //If statement to get letter grade
            if (calcGrade >= 89.5)
                letterGrade = 'A';
            else if (calcGrade >= 79.5)
                letterGrade = 'B';
            else if (calcGrade >= 69.5)
                letterGrade = 'C';
            else if (calcGrade >= 59.5)
                letterGrade = 'D';
            else if (calcGrade >= 0)
                letterGrade = 'F';
            //endif

            //Output message for user changes the final label
            lblFinal.Text = $"Your letter grade  is {letterGrade} and final average score is {calcGrade:F2}!";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears every text box one by one ?? i didnt remember how to do it there is definietly a better way
            txtBoxExam1.Clear();
            txtBoxExam2.Clear();
            txtBoxExam3.Clear();
            txtBoxExam4.Clear();
            txtBoxLab1.Clear();
            txtBoxLab2.Clear();
            txtBoxLab3.Clear();
            txtBoxLab4.Clear();
            txtBoxLab5.Clear();
            txtBoxQuiz1.Clear();
            txtBoxQuiz2.Clear();
            txtBoxQuiz3.Clear();
            txtBoxQuiz4.Clear();
            txtBoxQuiz5.Clear();

            lblFinal.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits form
            this.Close();
        }
    }
}
