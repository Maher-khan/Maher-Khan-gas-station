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
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(206, 136);
            lblName.Name = "lblName";
            lblName.Size = new Size(141, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Customer Name";
            lblName.Click += lblName_Click;
            // 
            // lblGallons
            // 
            lblGallons.AutoSize = true;
            lblGallons.Location = new Point(206, 201);
            lblGallons.Name = "lblGallons";
            lblGallons.Size = new Size(70, 25);
            lblGallons.TabIndex = 4;
            lblGallons.Text = "Gallons";
            lblGallons.Click += txtGallons_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(206, 262);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(625, 279);
            lstOutput.TabIndex = 6;
            lstOutput.SelectedIndexChanged += lstOutput_SelectedIndexChanged;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(217, 565);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(134, 97);
            btnCalc.TabIndex = 7;
            btnCalc.Text = "&Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(447, 565);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 97);
            btnClear.TabIndex = 8;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(680, 565);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 97);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(382, 136);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(449, 31);
            txtCustomerName.TabIndex = 3;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // txtGallons
            // 
            txtGallons.Location = new Point(382, 201);
            txtGallons.Name = "txtGallons";
            txtGallons.Size = new Size(449, 31);
            txtGallons.TabIndex = 5;
            txtGallons.Enter += txtGallons_Enter;
            txtGallons.Leave += txtGallons_Leave;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbl1.Location = new Point(371, 52);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(336, 46);
            lbl1.TabIndex = 1;
            lbl1.Text = "Gas Price Calculator";
            lbl1.Click += Label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 717);
            Controls.Add(lbl1);
            Controls.Add(txtGallons);
            Controls.Add(txtCustomerName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lstOutput);
            Controls.Add(lblGallons);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Maher's Gas Price Calculator";
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
    }
}
