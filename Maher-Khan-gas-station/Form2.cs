using System;
using System.IO;
using System.Windows.Forms;

namespace Maher_Khan_gas_station
{
    public partial class Form2 : Form
    {
        // ICA 9 - declare private Form1 variable
        private Form1 transactionForm;

        // ICA 9 - constructor takes Form1 parameter
        public Form2(Form1 frm1)
        {
            InitializeComponent();

            // ICA 9 - set private Form1 value to Form1 parameter
            transactionForm = frm1;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            decimal tempRegular;
            decimal tempPremium;
            decimal tempDiesel;

            bool regularGood;
            bool premiumGood;
            bool dieselGood;

            regularGood = decimal.TryParse(txtRegularPrice.Text, out tempRegular);
            premiumGood = decimal.TryParse(txtPremiumPrice.Text, out tempPremium);
            dieselGood = decimal.TryParse(txtDieselPrice.Text, out tempDiesel);

            if (regularGood && premiumGood && dieselGood)
            {
                // If they are valid
                transactionForm.RegularPrice = tempRegular;
                transactionForm.PremiumPrice = tempPremium;
                transactionForm.DieselPrice = tempDiesel;

                // Saves the values in the configuration file
                StreamWriter sw;
                sw = File.CreateText("GasConfig.txt");

                sw.WriteLine(transactionForm.RegularPrice.ToString("N2"));
                sw.WriteLine(transactionForm.PremiumPrice.ToString("N2"));
                sw.WriteLine(transactionForm.DieselPrice.ToString("N2"));

                sw.Close();

                // Returns to previous window
                this.Hide();
            }
            else
            {
                // show old values again
                txtRegularPrice.Text = transactionForm.RegularPrice.ToString("N2");
                txtPremiumPrice.Text = transactionForm.PremiumPrice.ToString("N2");
                txtDieselPrice.Text = transactionForm.DieselPrice.ToString("N2");

                lblError.Text = "Please enter valid numeric prices.";
                lblError.Visible = true;
            }
        }

        private void txtDieselPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}