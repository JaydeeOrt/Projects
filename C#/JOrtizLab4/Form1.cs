/*
 * Jorge Ortiz
 * CPT 185 - A01H
 * In Class Lab 4
 */
namespace JOrtizLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes form
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double inch = 0.0;
            double feet = 0.0;
            double yard = 0.0;

            //Checks that user inputed a positive number
            if (double.Parse(txtBoxDist.Text) >= 0)
            {   
                //Checks that both boxes have something selected
                if (lstBoxFrom.SelectedIndex != -1 && lstBoxTo.SelectedIndex != -1)
                {
                    //case calculates all options
                    switch (lstBoxFrom.SelectedItem.ToString())
                    {
                        case "Inches":
                            inch = double.Parse(txtBoxDist.Text);
                            feet = inch / 12;
                            yard = feet / 3;

                            break;
                        case "Feet":
                            feet = double.Parse(txtBoxDist.Text);
                            inch = feet * 12;
                            yard = feet / 3;
                            break;
                        case "Yards":
                            yard = double.Parse(txtBoxDist.Text);
                            feet = yard * 3;
                            inch = feet * 12;
                            break;
                    }//End Switch

                    //Selects which conversion you want to see
                    switch (lstBoxTo.SelectedItem.ToString())
                    {
                        case "Inches":
                            txtBoxFinalDist.Text = $"{inch}";
                            break;
                        case "Feet":
                            txtBoxFinalDist.Text = $"{feet}";
                            break;
                        case "Yards":
                            txtBoxFinalDist.Text = $"{yard}";
                            break;
                    }//End Switch
                }
                else
                {
                    //error message for when user does not select measurement in groupboxes
                    MessageBox.Show("Both boxes must be selected to convert your distance!", "###Error###");
                }//endif
            }
            else
            {
                //error message for if user enters a non positive number
                MessageBox.Show("The distance must be positive!", "###Error###");
                txtBoxDist.Clear();
            }//end if

        }
        
    }
}
