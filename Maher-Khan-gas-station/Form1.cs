using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maher_Khan_gas_station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGallons_Click(object sender, EventArgs e)
        {

        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // ICA 2
            txtCustomerName.Clear();
            txtGallons.Clear();
            lstOutput.Items.Clear();
            txtCustomerName.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // ICA 4
            // Declare Variables

            // setting this value to a literal FOR NOW
            decimal pricePerGallon = 3.49m;

            // going to come from the user
            decimal gallons;
            string customerName;
            decimal totalCost;

            // validation variables
            // gallonsGood indicates whether gallons was entered as a valid number
            // customerNameGood indicates whether customer name was entered
            bool gallonsGood, customerNameGood;

            // For string variables just set variable to text property
            customerName = txtCustomerName.Text;

            if (customerName == "")
            {
                customerNameGood = false;
            }
            else
            {
                customerNameGood = true;
            }

            // For numeric you must convert a string to a number
            gallonsGood = decimal.TryParse(txtGallons.Text, out gallons);

            if (gallonsGood && customerNameGood)
            {
                // do calculation
                // for me that is price per gallon multiplied by gallons purchased
                totalCost = pricePerGallon * gallons;

                // output all variables to list box and make sure it is formatted
                lstOutput.Items.Clear();
                lstOutput.Items.Add("Gas Price Calculator");
                lstOutput.Items.Add("The Customer Name is: " + customerName);
                lstOutput.Items.Add("The Gallons Purchased is: " + gallons.ToString("N2"));
                lstOutput.Items.Add("The Price Per Gallon is: " + pricePerGallon.ToString("C"));
                lstOutput.Items.Add("The Total Cost is: " + totalCost.ToString("C"));

                // this gives the clear button the focus
                btnClear.Focus();
            }
            else // Error Processing
            {
                lstOutput.Items.Clear();

                if (!customerNameGood)
                {
                    lstOutput.Items.Add("Please enter a value for Customer Name.");
                }

                if (!gallonsGood)
                {
                    lstOutput.Items.Add("The gallons value was not entered as a number.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // ICA 4
            DialogResult buttonSelected;

            buttonSelected = MessageBox.Show("Do you really want to quit?",
                                             "Exiting...",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (buttonSelected == DialogResult.Yes)
            {
                // ICA 2
                this.Close();
            }
        }

        // ICA 2
        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.Beige;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

        // ICA 3
        private void txtGallons_Enter(object sender, EventArgs e)
        {
            txtGallons.BackColor = Color.Beige;
        }

        private void txtGallons_Leave(object sender, EventArgs e)
        {
            txtGallons.BackColor = SystemColors.Window;
        }
    }
}
