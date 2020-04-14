using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Bill
{
    public partial class Form1 : Form
    {
        // List to store input entries
        IList<double> billArray = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { // Close App
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {  // Reset entries
            firsttxt.Text = "";
            secondtxt.Text = "";
            thirdtxt.Text = "";
            fourthtxt.Text = "";
            totaltxt.Text = "";
            avgtxt.Text = "";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            // Exception handler to catch non numeric entries
            try
            {
                // checking that entries are not empty
                if (!string.IsNullOrEmpty(firsttxt.Text) && !string.IsNullOrEmpty(secondtxt.Text) && !string.IsNullOrEmpty(thirdtxt.Text) &&
                    !string.IsNullOrEmpty(fourthtxt.Text)) ;

                // Adding data from textbox in a list
                billArray.Add(Convert.ToDouble(firsttxt.Text) + Convert.ToDouble(secondtxt.Text) + Convert.ToDouble(thirdtxt.Text) +
                    Convert.ToDouble(fourthtxt.Text));

                // Total calculation
                double total = billArray.Sum();

                totaltxt.Text = total.ToString();

                // Average calculation
                avgtxt.Text = (total / 4).ToString();

            } // Exception message
            catch
            {
                MessageBox.Show("Numbers are required");
            }
        }
    }
}
