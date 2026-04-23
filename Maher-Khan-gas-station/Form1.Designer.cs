namespace Maher_Khan_gas_station
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblGallons = new Label();
            lstOutput = new ListBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtCustomerName = new TextBox();
            txtGallons = new TextBox();
            lbl1 = new Label();
            grpGasType = new GroupBox();
            rdoDiesel = new RadioButton();
            rdoPremium = new RadioButton();
            rdoRegular = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            grpGasType.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(156, 137);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Customer Name";
            lblName.Click += lblName_Click;
            // 
            // lblGallons
            // 
            lblGallons.AutoSize = true;
            lblGallons.Location = new Point(156, 169);
            lblGallons.Margin = new Padding(2, 0, 2, 0);
            lblGallons.Name = "lblGallons";
            lblGallons.Size = new Size(46, 15);
            lblGallons.TabIndex = 4;
            lblGallons.Text = "Gallons";
            lblGallons.Click += txtGallons_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(156, 206);
            lstOutput.Margin = new Padding(2, 2, 2, 2);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(439, 169);
            lstOutput.TabIndex = 6;
            lstOutput.SelectedIndexChanged += lstOutput_SelectedIndexChanged;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(156, 389);
            btnCalc.Margin = new Padding(2, 2, 2, 2);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(94, 58);
            btnCalc.TabIndex = 7;
            btnCalc.Text = "&Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(320, 389);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 58);
            btnClear.TabIndex = 8;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(496, 389);
            btnExit.Margin = new Padding(2, 2, 2, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 58);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(279, 137);
            txtCustomerName.Margin = new Padding(2, 2, 2, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(316, 23);
            txtCustomerName.TabIndex = 3;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // txtGallons
            // 
            txtGallons.Location = new Point(279, 169);
            txtGallons.Margin = new Padding(2, 2, 2, 2);
            txtGallons.Name = "txtGallons";
            txtGallons.Size = new Size(316, 23);
            txtGallons.TabIndex = 5;
            txtGallons.Enter += txtGallons_Enter;
            txtGallons.Leave += txtGallons_Leave;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbl1.Location = new Point(267, 22);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(226, 31);
            lbl1.TabIndex = 1;
            lbl1.Text = "Gas Price Calculator";
            lbl1.Click += Label1_Click;
            // 
            // grpGasType
            // 
            grpGasType.Controls.Add(rdoDiesel);
            grpGasType.Controls.Add(rdoPremium);
            grpGasType.Controls.Add(rdoRegular);
            grpGasType.Location = new Point(156, 57);
            grpGasType.Margin = new Padding(2, 2, 2, 2);
            grpGasType.Name = "grpGasType";
            grpGasType.Padding = new Padding(2, 2, 2, 2);
            grpGasType.Size = new Size(438, 65);
            grpGasType.TabIndex = 10;
            grpGasType.TabStop = false;
            grpGasType.Text = "Gas Type";
            // 
            // rdoDiesel
            // 
            rdoDiesel.AutoSize = true;
            rdoDiesel.Location = new Point(326, 30);
            rdoDiesel.Margin = new Padding(2, 2, 2, 2);
            rdoDiesel.Name = "rdoDiesel";
            rdoDiesel.Size = new Size(56, 19);
            rdoDiesel.TabIndex = 2;
            rdoDiesel.TabStop = true;
            rdoDiesel.Text = "Diesel";
            rdoDiesel.UseVisualStyleBackColor = true;
            rdoDiesel.CheckedChanged += rdoDiesel_CheckedChanged;
            // 
            // rdoPremium
            // 
            rdoPremium.AutoSize = true;
            rdoPremium.Location = new Point(179, 30);
            rdoPremium.Margin = new Padding(2, 2, 2, 2);
            rdoPremium.Name = "rdoPremium";
            rdoPremium.Size = new Size(74, 19);
            rdoPremium.TabIndex = 1;
            rdoPremium.TabStop = true;
            rdoPremium.Text = "Premium";
            rdoPremium.UseVisualStyleBackColor = true;
            rdoPremium.CheckedChanged += rdoPremium_CheckedChanged;
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(57, 30);
            rdoRegular.Margin = new Padding(2, 2, 2, 2);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(65, 19);
            rdoRegular.TabIndex = 0;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            rdoRegular.CheckedChanged += rdoRegular_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 472);
            Controls.Add(grpGasType);
            Controls.Add(lbl1);
            Controls.Add(txtGallons);
            Controls.Add(txtCustomerName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lstOutput);
            Controls.Add(lblGallons);
            Controls.Add(lblName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Maher's Gas Price Calculator";
            Load += Form1_Load;
            grpGasType.ResumeLayout(false);
            grpGasType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblGallons;
        private ListBox lstOutput;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtCustomerName;
        private TextBox txtGallons;
        private Label lbl1;
        private GroupBox grpGasType;
        private RadioButton rdoDiesel;
        private RadioButton rdoPremium;
        private RadioButton rdoRegular;
        private OpenFileDialog openFileDialog1;
    }
}
