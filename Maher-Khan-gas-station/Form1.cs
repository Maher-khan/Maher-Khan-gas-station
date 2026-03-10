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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //ICA 2
            txtCustomerName.Clear();
            txtGallons.Clear();
            lstOutput.Items.Clear();
            txtCustomerName.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //ICA 3
            // Declare variables

            // setting this value to a literal FOR NOW
            decimal pricePerGallon = 3.49m;

            // going to come from the user
            decimal gallons;
            string customerName;
            decimal totalCost;

            // For string variables just set variable to text property
            customerName = txtCustomerName.Text;


            //For Numeric you must convert a string to a number
            gallons = decimal.Parse(txtGallons.Text);


            // do calculation
            // for me that is price per gallon multiplied by gallons purchased
            totalCost = pricePerGallon * gallons;


            //output to list box and make sure it is formatted
            lstOutput.Items.Clear();
            lstOutput.Items.Add("The Customer Name is: " + customerName);
            lstOutput.Items.Add("The Gallons Purchased is: " + gallons.ToString("N2"));
            lstOutput.Items.Add("The Price Per Gallon is: " + pricePerGallon.ToString("C"));
            lstOutput.Items.Add("The Total Cost is: " + totalCost.ToString("C"));




        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //ICA 2
            this.Close();

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        //ICA 2
        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.Beige;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

        //ICA 3
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
