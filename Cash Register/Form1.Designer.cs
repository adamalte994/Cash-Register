namespace Cash_Register
{
    partial class Form1
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
            this.NumOfBurgersInput = new System.Windows.Forms.TextBox();
            this.NumOfFriesInput = new System.Windows.Forms.TextBox();
            this.NumOfDrinksInput = new System.Windows.Forms.TextBox();
            this.CalculateTotals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalWithTaxOutput = new System.Windows.Forms.Label();
            this.PrintReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumOfBurgersInput
            // 
            this.NumOfBurgersInput.Location = new System.Drawing.Point(246, 20);
            this.NumOfBurgersInput.Name = "NumOfBurgersInput";
            this.NumOfBurgersInput.Size = new System.Drawing.Size(49, 20);
            this.NumOfBurgersInput.TabIndex = 0;
            // 
            // NumOfFriesInput
            // 
            this.NumOfFriesInput.Location = new System.Drawing.Point(246, 62);
            this.NumOfFriesInput.Name = "NumOfFriesInput";
            this.NumOfFriesInput.Size = new System.Drawing.Size(49, 20);
            this.NumOfFriesInput.TabIndex = 1;
            // 
            // NumOfDrinksInput
            // 
            this.NumOfDrinksInput.Location = new System.Drawing.Point(246, 102);
            this.NumOfDrinksInput.Name = "NumOfDrinksInput";
            this.NumOfDrinksInput.Size = new System.Drawing.Size(49, 20);
            this.NumOfDrinksInput.TabIndex = 2;
            // 
            // CalculateTotals
            // 
            this.CalculateTotals.Location = new System.Drawing.Point(170, 141);
            this.CalculateTotals.Name = "CalculateTotals";
            this.CalculateTotals.Size = new System.Drawing.Size(98, 23);
            this.CalculateTotals.TabIndex = 3;
            this.CalculateTotals.Text = "CalculateTotals";
            this.CalculateTotals.UseVisualStyleBackColor = true;
            this.CalculateTotals.Click += new System.EventHandler(this.CalculateTotals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "numOfBurgers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "numOfFries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "numOfDrinks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SubTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.Location = new System.Drawing.Point(243, 206);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(35, 13);
            this.subTotalOutput.TabIndex = 10;
            this.subTotalOutput.Text = "label7";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(243, 249);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(35, 13);
            this.taxOutput.TabIndex = 11;
            this.taxOutput.Text = "label7";
            // 
            // totalWithTaxOutput
            // 
            this.totalWithTaxOutput.AutoSize = true;
            this.totalWithTaxOutput.Location = new System.Drawing.Point(243, 292);
            this.totalWithTaxOutput.Name = "totalWithTaxOutput";
            this.totalWithTaxOutput.Size = new System.Drawing.Size(35, 13);
            this.totalWithTaxOutput.TabIndex = 12;
            this.totalWithTaxOutput.Text = "label8";
            // 
            // PrintReceipt
            // 
            this.PrintReceipt.Location = new System.Drawing.Point(170, 331);
            this.PrintReceipt.Name = "PrintReceipt";
            this.PrintReceipt.Size = new System.Drawing.Size(98, 23);
            this.PrintReceipt.TabIndex = 13;
            this.PrintReceipt.Text = "Print receipt";
            this.PrintReceipt.UseVisualStyleBackColor = true;
            this.PrintReceipt.Click += new System.EventHandler(this.PrintReceipt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 426);
            this.Controls.Add(this.PrintReceipt);
            this.Controls.Add(this.totalWithTaxOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateTotals);
            this.Controls.Add(this.NumOfDrinksInput);
            this.Controls.Add(this.NumOfFriesInput);
            this.Controls.Add(this.NumOfBurgersInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumOfBurgersInput;
        private System.Windows.Forms.TextBox NumOfFriesInput;
        private System.Windows.Forms.TextBox NumOfDrinksInput;
        private System.Windows.Forms.Button CalculateTotals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalWithTaxOutput;
        private System.Windows.Forms.Button PrintReceipt;
    }
}

