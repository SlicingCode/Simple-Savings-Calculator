using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Savings_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int deposit;
        int weeks;
        int total;

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // Get deposit amount
            deposit = Convert.ToInt32(TxtDeposit.Text);
            
            // Get number of weeks
            weeks = Convert.ToInt32(TxtWeeks.Text);

            // Total Savings
            total = deposit * weeks;

            // Display Total
            TxtSavings.Text = "$" + Convert.ToString(total);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
