/*
 * Jorge Ortiz
 * CPT 185 - A01H
 * Lab 10
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOrtizLab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cityTableAdapter.SumCity().ToString());
        }

        private void btnAvgPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cityTableAdapter.AveragePop().ToString());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cityTableAdapter.MaxCity().ToString());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cityTableAdapter.MinCity().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
