using System;
using System.IO;
using System.Windows.Forms;

namespace Maher_Khan_gas_station
{
    public partial class Form1 : Form
    {
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
        string logFile = "GasLog.txt";
        string cfgFile = "GasConfig.txt";

        // =========================
        // ICA 8 - Properties
        // =========================

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

        // =========================

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal pricePerGallon = 0;
            decimal gallons;
            decimal total;

            bool gallonsGood;

            string customerName = txtCustomerName.Text;

            // ICA 4 validation
            gallonsGood = decimal.TryParse(txtGallons.Text, out gallons);

            if (customerName == "" || !gallonsGood)
            {
                lstOutput.Items.Add("Error: Enter valid input.");
                return;
            }

            // ICA 7 switch using properties
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
                    lstOutput.Items.Add("Error selecting gas type.");
                    return;
            }

            total = pricePerGallon * gallons;

            // Output
            lstOutput.Items.Add("Customer: " + customerName);
            lstOutput.Items.Add("Gas Type: " + gasType);
            lstOutput.Items.Add("Gallons: " + gallons);
            lstOutput.Items.Add("Price per gallon: " + pricePerGallon.ToString("C"));
            lstOutput.Items.Add("Total: " + total.ToString("C"));

            // ICA 6 write to file
            StreamWriter sw = File.AppendText(logFile);

            sw.WriteLine("----- Transaction -----");
            sw.WriteLine("Date: " + DateTime.Now);
            sw.WriteLine("Customer: " + customerName);
            sw.WriteLine("Gas Type: " + gasType);
            sw.WriteLine("Gallons: " + gallons);
            sw.WriteLine("Total: " + total.ToString("C"));
            sw.WriteLine();

            sw.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtGallons.Clear();
            lstOutput.Items.Clear();

            rdoRegular.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRegular.Checked)
                gasType = REGULAR;
        }

        private void rdoPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPremium.Checked)
                gasType = PREMIUM;
        }

        private void rdoDiesel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDiesel.Checked)
                gasType = DIESEL;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string COMMENT = "#";

            StreamReader sr;
            bool fileGood;

            do
            {
                fileGood = true;

                try
                {
                    sr = File.OpenText(cfgFile);

                    string temp;

                    // REGULAR
                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.StartsWith(COMMENT));

                    decimal tempValue;
                    decimal.TryParse(temp, out tempValue);
                    RegularPrice = tempValue;

                    // PREMIUM
                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.StartsWith(COMMENT));

                    decimal.TryParse(temp, out tempValue);
                    PremiumPrice = tempValue;

                    // DIESEL
                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.StartsWith(COMMENT));

                    decimal.TryParse(temp, out tempValue);
                    DieselPrice = tempValue;

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
                }

            } while (!fileGood);

            rdoRegular.Checked = true;
        }
    }
}