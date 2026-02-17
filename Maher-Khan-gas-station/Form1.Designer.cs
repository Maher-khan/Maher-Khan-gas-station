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
            txtName = new Label();
            txtGallons = new Label();
            lstBox = new ListBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(217, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 25);
            txtName.TabIndex = 0;
            txtName.Text = "Customer Name";
            // 
            // txtGallons
            // 
            txtGallons.AutoSize = true;
            txtGallons.Location = new Point(217, 138);
            txtGallons.Name = "txtGallons";
            txtGallons.Size = new Size(70, 25);
            txtGallons.TabIndex = 1;
            txtGallons.Text = "Gallons";
            txtGallons.Click += txtGallons_Click;
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.Location = new Point(217, 227);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(625, 279);
            lstBox.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(217, 570);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(112, 34);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "&Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(473, 570);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(730, 570);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 671);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lstBox);
            Controls.Add(txtGallons);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName;
        private Label txtGallons;
        private ListBox lstBox;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
    }
}
