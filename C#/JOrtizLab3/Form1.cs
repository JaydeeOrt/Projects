/*
 * Jorge Ortiz
 * CPT 185 - A01H
 * In Class Lab 3
 */
using Microsoft.VisualBasic;

namespace JOrtizLab3
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int classA = 0;
            int classB = 0;
            int classC = 0;
            double classARev = 0;
            double classBRev = 0;
            double classCRev = 0;
            double total = 0;
            //Checks that a number is entered
            try
            {
                classA = int.Parse(txtBoxClassA.Text);
                classB = int.Parse(txtBoxClassB.Text);
                classC = int.Parse(txtBoxClassC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Input Wrong Data! Please Enter a Whole number!");
            }

            classARev = classA * 15;
            classBRev = classB * 12;
            classCRev = classC * 9;
            total = classARev + classBRev + classCRev;

            txtBoxClassARev.Text = $"${classARev:N2}";
            txtBoxClassBRev.Text = $"${classBRev:N2}";
            txtBoxClassCRev.Text = $"${classCRev:N2}";
            txtBoxTotal.Text = $"${total:N2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxClassA.Clear();
            txtBoxClassB.Clear();
            txtBoxClassC.Clear();
            txtBoxClassARev.Clear();
            txtBoxClassBRev.Clear();
            txtBoxClassCRev.Clear();
            txtBoxTotal.Clear();
        }
    }
}
