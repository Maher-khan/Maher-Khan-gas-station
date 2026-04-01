using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Maher_Khan_gas_station
{
    public partial class Form1 : Form
    {
        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtGallons_Click(object sender, EventArgs e)
        {

        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private string gasType = "";

        const string REGULAR = "Regular";
        const string PREMIUM = "Premium";
        const string DIESEL = "Diesel";

        // ICA 6 - class level file name
        string logFile = "GasTransactionLog.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal pricePerGallon = 0m;
            decimal gallons;
            string customerName;
            decimal totalCost;

            bool gallonsGood, customerNameGood;

            customerName = txtCustomerName.Text;

            if (customerName == "")
            {
                customerNameGood = false;
            }
            else
            {
                customerNameGood = true;
            }

            gallonsGood = decimal.TryParse(txtGallons.Text, out gallons);

            if (gallonsGood && customerNameGood)
            {
                switch (gasType)
                {
                    case REGULAR:
                        {
                            pricePerGallon = 3.49m;
                            break;
                        }

                    case PREMIUM:
                        {
                            pricePerGallon = 4.09m;
                            break;
                        }

                    case DIESEL:
                        {
                            pricePerGallon = 3.89m;
                            break;
                        }

                    default:
                        {
                            lstOutput.Items.Add("Error in Switch statement.");
                            return;
                        }
                }

                totalCost = pricePerGallon * gallons;

                // DO NOT CLEAR (per instruction)
                lstOutput.Items.Add("Gas Price Calculator");
                lstOutput.Items.Add("Customer Name: " + customerName);
                lstOutput.Items.Add("Gas Type: " + gasType);
                lstOutput.Items.Add("Gallons: " + gallons.ToString("N2"));
                lstOutput.Items.Add("Price Per Gallon: " + pricePerGallon.ToString("C"));
                lstOutput.Items.Add("Total Cost: " + totalCost.ToString("C"));

                // ICA 6 - WRITE TO FILE
                StreamWriter sw;

                // open log (append mode)
                sw = File.AppendText(logFile);

                sw.WriteLine("========== New Transaction ==========");
                sw.WriteLine("Date/Time: " + DateTime.Now.ToString());
                sw.WriteLine("Customer Name: " + customerName);
                sw.WriteLine("Gas Type: " + gasType);
                sw.WriteLine("Gallons: " + gallons.ToString("N2"));
                sw.WriteLine("Price Per Gallon: " + pricePerGallon.ToString("C"));
                sw.WriteLine("Total Cost: " + totalCost.ToString("C"));
                sw.WriteLine("--------------------------------------");

                sw.Close();

                btnClear.Focus();
            }
            else
            {
                if (!customerNameGood)
                {
                    lstOutput.Items.Add("Please enter Customer Name.");
                }

                if (!gallonsGood)
                {
                    lstOutput.Items.Add("Gallons must be a number.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtGallons.Clear();
            lstOutput.Items.Clear();
            txtCustomerName.Focus();
            rdoRegular.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected;

            buttonSelected = MessageBox.Show(
                "Do you really want to quit?",
                "Exiting...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (buttonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRegular.Checked)
            {
                gasType = REGULAR;
            }
        }

        private void rdoPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPremium.Checked)
            {
                gasType = PREMIUM;
            }
        }

        private void rdoDiesel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDiesel.Checked)
            {
                gasType = DIESEL;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoRegular.Checked = true;
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.Beige;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

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