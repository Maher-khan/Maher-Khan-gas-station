using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Maher_Khan_gas_station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ICA 9 - create the form2 object
            settingForm = new Form2(this);
        }

        // ICA 7 constants
        const string REGULAR = "Regular";
        const string PREMIUM = "Premium";
        const string DIESEL = "Diesel";

        // ICA 11 - output locations
        const int OUTPUT_LISTBOX = 1;
        const int OUTPUT_LOGFILE = 2;
        const int OUTPUT_BOTH = 3;

        private string gasType = "";

        // ICA 7 backing fields
        private decimal regularPrice = 2.50m;
        private decimal premiumPrice = 3.00m;
        private decimal dieselPrice = 2.80m;

        // ICA 6
        private string logFile = "GasTransactionLog.txt";
        internal string cfgFile = "GasConfig.txt";

        // ICA 9
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

        public string ConfigFile
        {
            get { return cfgFile; }
            set { cfgFile = value; }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // ICA 3
            decimal pricePerGallon = 0m;
            decimal gallons;
            string customerName;
            decimal totalCost;

            // ICA 4
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
                        pricePerGallon = RegularPrice;
                        break;

                    case PREMIUM:
                        pricePerGallon = PremiumPrice;
                        break;

                    case DIESEL:
                        pricePerGallon = DieselPrice;
                        break;

                    default:
                        SendOutput(OUTPUT_LISTBOX, "Error in switch statement - This should not happen");
                        return;
                }

                totalCost = pricePerGallon * gallons;

                // ICA 11 - output to both listbox and log file
                SendOutput(OUTPUT_BOTH, "========== New Transaction ==========");
                SendOutput(OUTPUT_BOTH, "Date/Time: " + DateTime.Now.ToString());
                SendOutput(OUTPUT_BOTH, "Gas Price Calculator");
                SendOutput(OUTPUT_BOTH, "Customer Name: " + customerName);
                SendOutput(OUTPUT_BOTH, "Gas Type: " + gasType);
                SendOutput(OUTPUT_BOTH, "Gallons: " + gallons.ToString("N2"));
                SendOutput(OUTPUT_BOTH, "Price Per Gallon: " + pricePerGallon.ToString("C"));
                SendOutput(OUTPUT_BOTH, "Total Cost: " + totalCost.ToString("C"));
                SendOutput(OUTPUT_BOTH, "--------------------------------------");

                btnClear.Focus();
            }
            else
            {
                if (!customerNameGood)
                {
                    SendOutput(OUTPUT_LISTBOX, "Please enter Customer Name.");
                }

                if (!gallonsGood)
                {
                    SendOutput(OUTPUT_LISTBOX, "Gallons must be a number.");
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
                    sr = File.OpenText(cfgFile);

                    do
                    {
                        temp = sr.ReadLine() ?? "";
                    } while (temp.StartsWith(COMMENT));

                    if (decimal.TryParse(temp, out tempValue))
                    {
                        RegularPrice = tempValue;
                    }
                    else
                    {
                        MessageBox.Show("Problem reading Regular price. Default value will be used.");
                    }

                    do
                    {
                        temp = sr.ReadLine() ?? "";
                    } while (temp.StartsWith(COMMENT));

                    if (decimal.TryParse(temp, out tempValue))
                    {
                        PremiumPrice = tempValue;
                    }
                    else
                    {
                        MessageBox.Show("Problem reading Premium price. Default value will be used.");
                    }

                    do
                    {
                        temp = sr.ReadLine() ?? "";
                    } while (temp.StartsWith(COMMENT));

                    if (decimal.TryParse(temp, out tempValue))
                    {
                        DieselPrice = tempValue;
                    }
                    else
                    {
                        MessageBox.Show("Problem reading Diesel price. Default value will be used.");
                    }

                    sr.Close();
                }
                catch (FileNotFoundException)
                {
                    fileGood = false;

                    MessageBox.Show("Config file not found. Please select it.");

                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Text Files|*.txt|All Files|*.*";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        cfgFile = ofd.FileName;
                    }
                    else
                    {
                        fileGood = true;
                        MessageBox.Show("Default prices will be used.");
                    }
                }
                catch
                {
                    fileGood = true;
                    MessageBox.Show("Problem reading config file. Default prices will be used.");
                }

            } while (!fileGood);

            rdoRegular.Checked = true;
        }

        // ICA 9
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

        private void printLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ICA 10 - Arrays
            string[] gasLogEntries;
            const int MAX_ENTRIES = 2000;
            gasLogEntries = new string[MAX_ENTRIES];

            StreamReader sr;
            int numEntries = 0;

            try
            {
                sr = File.OpenText(logFile);

                while (!sr.EndOfStream && numEntries < MAX_ENTRIES)
                {
                    gasLogEntries[numEntries] = sr.ReadLine();
                    numEntries++;
                }

                sr.Close();

                lstOutput.Items.Clear();

                string gasSearch = "Gas Type: " + gasType;

                for (int i = 0; i < numEntries; i++)
                {
                    if (gasLogEntries[i] == gasSearch)
                    {
                        for (int j = i - 3; j <= i + 5 && j < numEntries; j++)
                        {
                            if (j >= 0)
                            {
                                lstOutput.Items.Add(gasLogEntries[j]);
                            }
                        }

                        lstOutput.Items.Add("");
                    }
                }

                if (lstOutput.Items.Count == 0)
                {
                    lstOutput.Items.Add("No transactions found for " + gasType + ".");
                }
            }
            catch (FileNotFoundException)
            {
                lstOutput.Items.Clear();
                lstOutput.Items.Add("The log file was not found.");
            }
        }

        // ICA 11 - Methods
        private void SendOutput(int outputLocation, string outputText)
        {
            StreamWriter sw;

            if (outputLocation == OUTPUT_LISTBOX || outputLocation == OUTPUT_BOTH)
            {
                lstOutput.Items.Add(outputText);
            }

            if (outputLocation == OUTPUT_LOGFILE || outputLocation == OUTPUT_BOTH)
            {
                sw = File.AppendText(logFile);
                sw.WriteLine(outputText);
                sw.Close();
            }
        }
    }
}