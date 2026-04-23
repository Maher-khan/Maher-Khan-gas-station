namespace Maher_Khan_gas_station
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblRegularPrice = new Label();
            lblPremiumPrice = new Label();
            lblDieselPrice = new Label();
            lblError = new Label();
            txtRegularPrice = new TextBox();
            txtPremiumPrice = new TextBox();
            btnReturn = new Button();
            txtDieselPrice = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(417, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(152, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gas Price Settings";
            // 
            // lblRegularPrice
            // 
            lblRegularPrice.AutoSize = true;
            lblRegularPrice.Location = new Point(190, 122);
            lblRegularPrice.Name = "lblRegularPrice";
            lblRegularPrice.Size = new Size(113, 25);
            lblRegularPrice.TabIndex = 1;
            lblRegularPrice.Text = "Regular Price";
            // 
            // lblPremiumPrice
            // 
            lblPremiumPrice.AutoSize = true;
            lblPremiumPrice.Location = new Point(190, 189);
            lblPremiumPrice.Name = "lblPremiumPrice";
            lblPremiumPrice.Size = new Size(125, 25);
            lblPremiumPrice.TabIndex = 2;
            lblPremiumPrice.Text = "Premium Price";
            // 
            // lblDieselPrice
            // 
            lblDieselPrice.AutoSize = true;
            lblDieselPrice.Location = new Point(190, 267);
            lblDieselPrice.Name = "lblDieselPrice";
            lblDieselPrice.Size = new Size(101, 25);
            lblDieselPrice.TabIndex = 3;
            lblDieselPrice.Text = "Diesel Price";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(375, 448);
            lblError.Name = "lblError";
            lblError.Size = new Size(194, 25);
            lblError.TabIndex = 4;
            lblError.Text = "Possible Error Message";
            lblError.Visible = false;
            // 
            // txtRegularPrice
            // 
            txtRegularPrice.Location = new Point(394, 116);
            txtRegularPrice.Name = "txtRegularPrice";
            txtRegularPrice.Size = new Size(255, 31);
            txtRegularPrice.TabIndex = 5;
            // 
            // txtPremiumPrice
            // 
            txtPremiumPrice.Location = new Point(394, 183);
            txtPremiumPrice.Name = "txtPremiumPrice";
            txtPremiumPrice.Size = new Size(255, 31);
            txtPremiumPrice.TabIndex = 6;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(457, 349);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "&Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtDieselPrice
            // 
            txtDieselPrice.Location = new Point(394, 261);
            txtDieselPrice.Name = "txtDieselPrice";
            txtDieselPrice.Size = new Size(255, 31);
            txtDieselPrice.TabIndex = 8;
            txtDieselPrice.TextChanged += txtDieselPrice_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 628);
            Controls.Add(txtDieselPrice);
            Controls.Add(btnReturn);
            Controls.Add(txtPremiumPrice);
            Controls.Add(txtRegularPrice);
            Controls.Add(lblError);
            Controls.Add(lblDieselPrice);
            Controls.Add(lblPremiumPrice);
            Controls.Add(lblRegularPrice);
            Controls.Add(lblTitle);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRegularPrice;
        private Label lblPremiumPrice;
        private Label lblDieselPrice;
        private Button btnReturn;
        public Label lblError;
        public TextBox txtRegularPrice;
        public TextBox txtPremiumPrice;
        public TextBox txtDieselPrice;
    }
}