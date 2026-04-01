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

        // Stage 3 / ICA 7
        private decimal regularPrice = 3.49m;
        private decimal premiumPrice = 4.09m;
        private decimal dieselPrice = 3.89m;

        string logFile = "GasTransactionLog.txt";
        string configFile = "GasConfig.txt";

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
                            pricePerGallon = regularPrice;
                            break;
                        }

                    case PREMIUM:
                        {
                            pricePerGallon = premiumPrice;
                            break;
                        }

                    case DIESEL:
                        {
                            pricePerGallon = dieselPrice;
                            break;
                        }

                    default:
                        {
                            lstOutput.Items.Add("Error in Switch statement - This should not happen");
                            break;
                        }
                }

                totalCost = pricePerGallon * gallons;

                lstOutput.Items.Add("Gas Price Calculator");
                lstOutput.Items.Add("Customer Name: " + customerName);
                lstOutput.Items.Add("Gas Type: " + gasType);
                lstOutput.Items.Add("Gallons: " + gallons.ToString("N2"));
                lstOutput.Items.Add("Price Per Gallon: " + pricePerGallon.ToString("C"));
                lstOutput.Items.Add("Total Cost: " + totalCost.ToString("C"));

                StreamWriter sw;

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

            StreamReader sr;
            OpenFileDialog ofd;
            bool goodFile;

            ofd = new OpenFileDialog();
            ofd.FileName = configFile;
            ofd.Title = "Select Gas Configuration File";

            do
            {
                goodFile = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sr = File.OpenText(ofd.FileName);

                        regularPrice = decimal.Parse(sr.ReadLine());
                        premiumPrice = decimal.Parse(sr.ReadLine());
                        dieselPrice = decimal.Parse(sr.ReadLine());

                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        goodFile = false;
                        MessageBox.Show("There was a problem reading the configuration file.\n" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must select a configuration file for the program to continue.");
                    goodFile = false;
                }

            } while (!goodFile);
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