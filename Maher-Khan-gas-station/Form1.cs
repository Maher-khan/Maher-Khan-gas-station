using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Maher_Khan_gas_station
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            RegularPrice = 2.5m;

            // ICA 9 - create the form2 object
            settingForm = new Form2(this);
        }

        // ICA 7 constants
        const string REGULAR = "Regular";
        const string PREMIUM = "Premium";
        const string DIESEL = "Diesel";

        private string gasType = "";

        // ICA 7 backing fields (config values)
        private decimal regularPrice = 2.50m;
        private decimal premiumPrice = 3.00m;
        private decimal dieselPrice = 2.80m;

        // ICA 6
        private string logFile = "GasTransactionLog.txt";
        internal string cfgFile = "GasConfig.txt";

        // ICA 9 - declare the form2 variable
        private Form2 settingForm;

        // ICA 8 - Properties
      
        public decimal RegularPrice
        {
            get { return regularPrice; }
            set { regularPrice = value; }
        }

        public decimal PremiumPrice
        {
            get { return premiumPrice; }
            set { premiumPrice = value; }
        }

       
        public decimal DieselPrice
        {
            get { return dieselPrice; }
            set { dieselPrice = value; }
        }

      
     
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // ICA 3
            // Declare Variables
            decimal pricePerGallon = 0m;
            decimal gallons;
            string customerName;
            decimal totalCost;

            // ICA 4
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

            // For numerics you must convert a string to a number
            gallonsGood = decimal.TryParse(txtGallons.Text, out gallons);

            if (gallonsGood && customerNameGood)
            {
                switch (gasType)
                {
                    case REGULAR:
                        pricePerGallon = RegularPrice;
                        break;

                    case PREMIUM:
                        pricePerGallon = PremiumPrice;
                        break;

                    case DIESEL:
                        pricePerGallon = DieselPrice;
                        break;

                    default:
                        lstOutput.Items.Add("Error in switch statement - This should not happen");
                        return;
                }

                // do calculation
                totalCost = pricePerGallon * gallons;

                // output all variables to list box and make sure it is formatted
                lstOutput.Items.Add("Gas Price Calculator");
                lstOutput.Items.Add("Customer Name: " + customerName);
                lstOutput.Items.Add("Gas Type: " + gasType);
                lstOutput.Items.Add("Gallons: " + gallons.ToString("N2"));
                lstOutput.Items.Add("Price Per Gallon: " + pricePerGallon.ToString("C"));
                lstOutput.Items.Add("Total Cost: " + totalCost.ToString("C"));

                // ICA 6 - writing output to a file
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

                // this gives the clear button the focus
                btnClear.Focus();
            }
            else // error processing
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
            // ICA 2
            txtCustomerName.Clear();
            txtGallons.Clear();
            lstOutput.Items.Clear();
            txtCustomerName.Focus();

            // ICA 5
            rdoRegular.Checked = true;
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
            // ICA 7
            const string COMMENT = "#";

            StreamReader sr;
            bool fileGood;
            decimal tempValue;
            string temp = "";

            do
            {
                fileGood = true;

                try
                {
                    // normal situation - open the file directly first
                    sr = File.OpenText(cfgFile);

                    // REGULAR
                    do
                    {
                        temp = sr.ReadLine() ?? "";
                        if (temp == "")
                        {
                            throw new Exception("Configuration file is missing the Regular price.");
                        }
                    } while (temp.StartsWith(COMMENT));

                    decimal.TryParse(temp, out tempValue);
                    RegularPrice = tempValue;

                    // PREMIUM
                    do
                    {
                        temp = sr.ReadLine() ?? "";
                        if (temp == "")
                        {
                            throw new Exception("Configuration file is missing the Premium price.");
                        }
                    } while (temp.StartsWith(COMMENT));

                    decimal.TryParse(temp, out tempValue);
                    PremiumPrice = tempValue;

                    // DIESEL
                    do
                    {
                        temp = sr.ReadLine() ?? "";
                        if (temp == "")
                        {
                            throw new Exception("Configuration file is missing the Diesel price.");
                        }
                    } while (temp.StartsWith(COMMENT));

                    decimal.TryParse(temp, out tempValue);
                    DieselPrice = tempValue;

                    sr.Close();
                }
                catch (FileNotFoundException)
                {
                    // only if missing, ask the user to find it
                    fileGood = false;

                    MessageBox.Show("Config file not found. Please select it.");

                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Text Files|*.txt|All Files|*.*";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        cfgFile = ofd.FileName;
                    }
                }
                catch (Exception ex)
                {
                    fileGood = false;
                    MessageBox.Show(ex.Message);
                }
            } while (!fileGood);

            rdoRegular.Checked = true;
        }

        // ICA 9 - menu item click to show second form
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingForm.txtRegularPrice.Text = RegularPrice.ToString("N2");
            settingForm.txtPremiumPrice.Text = PremiumPrice.ToString("N2");
            settingForm.txtDieselPrice.Text = DieselPrice.ToString("N2");
            settingForm.lblError.Visible = false;
            settingForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}