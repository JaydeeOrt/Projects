/*
 * Jorge Ortiz
 * CPT 185 - A01H
 * Lab 6
 */
using System.IO;

namespace JortizLab6
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
        //Clear methods For each group
        public void ClearOilLube()
        {
            chkBoxOil.Checked = false;
            chkBoxLube.Checked = false;
        }
        public void ClearFlushes()
        {
            chkBoxRadiator.Checked = false;
            chkBoxTransmission.Checked = false;
        }
        public void ClearMisc()
        {
            chkBoxInspec.Checked = false;
            chkBoxMuffler.Checked = false;
            chkBoxTire.Checked = false;
        }
        public void ClearOther()
        { 
            txtBoxLabor.Clear();
            txtBoxParts.Clear();
        }
        public void ClearFees()
        {
            txtBoxService.Clear();
            txtBoxSumParts.Clear();
            txtBoxTax.Clear();
            txtBoxTotal.Clear();
        }

        //Calculation Methods
        private int OilLubeCharges()
        {
            int oil = 0;
            int lube = 0;
            //Checks which boxes are checked and returns sum of cost of oil and lube
            if (chkBoxOil.Checked == false && chkBoxLube.Checked == false)
            {
                oil = 0; lube = 0;
                return oil + lube;
            }
            else if (chkBoxOil.Checked == true && chkBoxLube.Checked == true)
            {
                oil = 26; lube = 18;
                return oil + lube;
            }
            else if (chkBoxOil.Checked == true)
            {
                oil = 26; lube = 0;
                return oil + lube;
            }
            else
            {
                oil = 0; lube = 18;
                return oil + lube;
            }//endif
        }

        private int FlushCharges()
        {
            int rad = 0;
            int tran = 0;
            //Checks which boxes are checked and returns sum of cost of flushes
            if (chkBoxRadiator.Checked == false && chkBoxTransmission.Checked == false)
            {
                rad = 0; tran = 0;
                return rad + tran;
            }
            else if (chkBoxRadiator.Checked == true && chkBoxTransmission.Checked == true)
            {
                rad = 30; tran = 80;
                return rad + tran;
            }
            else if (chkBoxRadiator.Checked == true)
            {
                rad = 30; tran = 0;
                return rad + tran;
            }
            else
            {
                rad = 0; tran = 80;
                return rad + tran;
            }//endif
        }

        private int MiscCharges()
        {
            int inspec = 0;
            int muff = 0;
            int tire = 0;
            //Checks which boxes are checked and returns sum of cost
            if (chkBoxInspec.Checked == true)
            {
                inspec = 15;
            }
            else
            {
                inspec = 0;
            }//endif

            if (chkBoxMuffler.Checked == true)
            {
                muff = 100;
            }
            else 
            {
                muff = 0;
            }//endif

            if (chkBoxTire.Checked == true)
            {
                tire = 20;
            }
            else
            {
                tire = 0;
            }//endif
            return inspec + muff + tire;
        }

        private (int, int) OtherCharges()
        {
            int par = 0;
            int lab = 0;
            //Grabs user entered numbers for parts and labor and returns them
            try
            {
                par = int.Parse(txtBoxParts.Text);
                lab = int.Parse(txtBoxLabor.Text);
                if (par >= 0 && lab >= 0)
                {
                    return (par, lab);
                }
                else
                {
                    MessageBox.Show("Make sure you enter a POSITIVE number for Parts and Labor", "!!!Error!!!");
                    return (0, 0);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Make sure you enter a NUMBER for Parts and Labor","!!!Error!!!");
                return (0, 0);

            }
        }

        private double TaxCharges(double tempTax)
        {
            tempTax = 0.06 * tempTax;
            return tempTax;
        }

        private double TotalCharges(double parts, double labor, double tax)
        {
            //calls other methods and gets final charge
            double sum = 0;

            int oilLube = OilLubeCharges();
            int flush = FlushCharges();
            int misc = MiscCharges();
            sum = oilLube+ flush + misc + labor + parts + tax;
            return sum;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double parts = 0;
            double labor = 0;
            double cost = 0;

            int oilLube = OilLubeCharges();
            int flush = FlushCharges();
            int misc = MiscCharges();
            (parts, labor) = OtherCharges();
            double tax = TaxCharges(parts);
            double total = TotalCharges(parts, labor,tax);
            cost = oilLube + flush + misc + labor;

            txtBoxService.Text = $"${cost:N2}";
            txtBoxSumParts.Text = $"${parts:N2}";
            txtBoxTax.Text = $"${tax:N2}";
            txtBoxTotal.Text =$"${total:N2}";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }
    }
}
