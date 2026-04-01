using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Maher_Khan_gas_station
{
    public partial class Form1 : Form
    {
        private string gasType = "";

        const string REGULAR = "Regular";
        const string PREMIUM = "Premium";
        const string DIESEL = "Diesel";

        // ICA 6
        string logFile = "GasTransactionLog.txt";

        // ICA 7
        string cfgFile = "GasConfig.txt";
        private decimal regularPrice = 3.49m;
        private decimal premiumPrice = 4.09m;
        private decimal dieselPrice = 3.89m;

        public Form1()
        {
            InitializeComponent();
        }

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
                            lstOutput.Items.Add("Error in Switch statement.");
                            return;
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
            const string COMMENT_CHAR = "#";

            rdoRegular.Checked = true;

            StreamReader sr;
            bool fileGood = true;
            string temp = "";

            do
            {
                try
                {
                    sr = File.OpenText(cfgFile);
                    fileGood = true;

                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.Substring(0, 1) == COMMENT_CHAR);

                    regularPrice = decimal.Parse(temp);

                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.Substring(0, 1) == COMMENT_CHAR);

                    premiumPrice = decimal.Parse(temp);

                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.Substring(0, 1) == COMMENT_CHAR);

                    dieselPrice = decimal.Parse(temp);

                    sr.Close();
                }
                catch (FileNotFoundException fnf)
                {
                    fileGood = false;

                    MessageBox.Show(
                        fnf.Message + "\nPlease enter the Configuration File",
                        "Configuration File Not Found");

                    openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
                    openFileDialog1.ShowDialog(this);
                    cfgFile = openFileDialog1.FileName;
                }
            } while (!fileGood);
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

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}