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
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(217, 63);
            lblName.Name = "lblName";
            lblName.Size = new Size(141, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Customer Name";
            // 
            // lblGallons
            // 
            lblGallons.AutoSize = true;
            lblGallons.Location = new Point(217, 138);
            lblGallons.Name = "lblGallons";
            lblGallons.Size = new Size(70, 25);
            lblGallons.TabIndex = 1;
            lblGallons.Text = "Gallons";
            lblGallons.Click += txtGallons_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(217, 202);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(625, 279);
            lstOutput.TabIndex = 2;
            lstOutput.SelectedIndexChanged += lstOutput_SelectedIndexChanged;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(195, 543);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(156, 107);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "&Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(451, 543);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 107);
            btnClear.TabIndex = 4;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(708, 543);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(156, 107);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(393, 63);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(449, 31);
            txtCustomerName.TabIndex = 6;
            // 
            // txtGallons
            // 
            txtGallons.Location = new Point(393, 132);
            txtGallons.Name = "txtGallons";
            txtGallons.Size = new Size(449, 31);
            txtGallons.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 717);
            Controls.Add(txtGallons);
            Controls.Add(txtCustomerName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lstOutput);
            Controls.Add(lblGallons);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
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
    }
}
