namespace currConvCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountUSD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currList = new System.Windows.Forms.ComboBox();
            this.amountCurr = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount in $USD:";
            // 
            // txtAmountUSD
            // 
            this.txtAmountUSD.Location = new System.Drawing.Point(128, 44);
            this.txtAmountUSD.Name = "txtAmountUSD";
            this.txtAmountUSD.Size = new System.Drawing.Size(100, 23);
            this.txtAmountUSD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Converts to:";
            // 
            // currList
            // 
            this.currList.FormattingEnabled = true;
            this.currList.Items.AddRange(new object[] {
            "€EUR (Euro)",
            "¥JPY (Japanese Yen)",
            "£GBP (British Pound)",
            "$AUD (Australian Dollar)",
            "$CAD (Canadian Dollar)"});
            this.currList.Location = new System.Drawing.Point(128, 75);
            this.currList.Name = "currList";
            this.currList.Size = new System.Drawing.Size(100, 23);
            this.currList.TabIndex = 3;
            // 
            // amountCurr
            // 
            this.amountCurr.Location = new System.Drawing.Point(128, 104);
            this.amountCurr.Name = "amountCurr";
            this.amountCurr.Size = new System.Drawing.Size(100, 23);
            this.amountCurr.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(157, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 231);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.amountCurr);
            this.Controls.Add(this.currList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountUSD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Currency Conversion Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAmountUSD;
        private Label label2;
        private ComboBox currList;
        private TextBox amountCurr;
        private Button btnCalculate;
    }
}