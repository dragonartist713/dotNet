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
            this.cmbCurrList = new System.Windows.Forms.ComboBox();
            this.txtResults = new System.Windows.Forms.TextBox();
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
            // cmbCurrList
            // 
            this.cmbCurrList.FormattingEnabled = true;
            this.cmbCurrList.Items.AddRange(new object[] {
            "Euro (EUR)",
            "Japanese Yen (JPY)",
            "Mexican Peso (MXN)",
            "Canadian Dollar (CAD)",
            "Indian Rupee (INR)"});
            this.cmbCurrList.Location = new System.Drawing.Point(128, 75);
            this.cmbCurrList.Name = "cmbCurrList";
            this.cmbCurrList.Size = new System.Drawing.Size(100, 23);
            this.cmbCurrList.TabIndex = 3;
            // 
            // txtResults
            // 
            this.txtResults.Enabled = false;
            this.txtResults.Location = new System.Drawing.Point(128, 104);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(100, 23);
            this.txtResults.TabIndex = 4;
            this.txtResults.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(139, 148);
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
            this.ClientSize = new System.Drawing.Size(279, 231);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.cmbCurrList);
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
        private ComboBox cmbCurrList;
        private TextBox txtResults;
        private Button btnCalculate;
    }
}