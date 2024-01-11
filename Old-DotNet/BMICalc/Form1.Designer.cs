namespace BMICalc
{
    partial class BMICalc
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
            this.Gender = new System.Windows.Forms.Label();
            this.cmbSexChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeightSmall = new System.Windows.Forms.TextBox();
            this.lblHeightSmall = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWeightNum = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMeasureStyle = new System.Windows.Forms.ComboBox();
            this.txtHeightBig = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(27, 128);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(35, 20);
            this.Gender.TabIndex = 0;
            this.Gender.Text = "Sex:";
            // 
            // cmbSexChoice
            // 
            this.cmbSexChoice.FormattingEnabled = true;
            this.cmbSexChoice.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.cmbSexChoice.Location = new System.Drawing.Point(93, 124);
            this.cmbSexChoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSexChoice.Name = "cmbSexChoice";
            this.cmbSexChoice.Size = new System.Drawing.Size(207, 28);
            this.cmbSexChoice.TabIndex = 1;
            this.cmbSexChoice.Text = "Choose One...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weight:";
            // 
            // txtHeightSmall
            // 
            this.txtHeightSmall.Location = new System.Drawing.Point(222, 166);
            this.txtHeightSmall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHeightSmall.Name = "txtHeightSmall";
            this.txtHeightSmall.Size = new System.Drawing.Size(78, 27);
            this.txtHeightSmall.TabIndex = 7;
            // 
            // lblHeightSmall
            // 
            this.lblHeightSmall.AutoSize = true;
            this.lblHeightSmall.Location = new System.Drawing.Point(306, 169);
            this.lblHeightSmall.Name = "lblHeightSmall";
            this.lblHeightSmall.Size = new System.Drawing.Size(47, 20);
            this.lblHeightSmall.TabIndex = 8;
            this.lblHeightSmall.Text = "in/cm";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(93, 206);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(114, 27);
            this.txtAge.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "years";
            // 
            // txtWeightNum
            // 
            this.txtWeightNum.Location = new System.Drawing.Point(93, 244);
            this.txtWeightNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeightNum.Name = "txtWeightNum";
            this.txtWeightNum.Size = new System.Drawing.Size(83, 27);
            this.txtWeightNum.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(36, 305);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(267, 31);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate your BMI!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Your BMI:";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(112, 344);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(114, 27);
            this.txtResult.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(126, 422);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(190, 248);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(50, 20);
            this.lblWeight.TabIndex = 17;
            this.lblWeight.Text = "lbs/kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Measurement Style: ";
            // 
            // cmbMeasureStyle
            // 
            this.cmbMeasureStyle.FormattingEnabled = true;
            this.cmbMeasureStyle.Items.AddRange(new object[] {
            "Imperial/English",
            "Metric"});
            this.cmbMeasureStyle.Location = new System.Drawing.Point(175, 75);
            this.cmbMeasureStyle.Name = "cmbMeasureStyle";
            this.cmbMeasureStyle.Size = new System.Drawing.Size(151, 28);
            this.cmbMeasureStyle.TabIndex = 20;
            this.cmbMeasureStyle.Text = "Choose One...";
            // 
            // txtHeightBig
            // 
            this.txtHeightBig.Location = new System.Drawing.Point(93, 166);
            this.txtHeightBig.Name = "txtHeightBig";
            this.txtHeightBig.Size = new System.Drawing.Size(83, 27);
            this.txtHeightBig.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "ft/m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "This counts as";
            // 
            // txtScale
            // 
            this.txtScale.Enabled = false;
            this.txtScale.Location = new System.Drawing.Point(112, 384);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(114, 27);
            this.txtScale.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "on the BMI scale.";
            // 
            // BMICalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 485);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHeightBig);
            this.Controls.Add(this.cmbMeasureStyle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeightNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblHeightSmall);
            this.Controls.Add(this.txtHeightSmall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSexChoice);
            this.Controls.Add(this.Gender);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BMICalc";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Gender;
        private ComboBox cmbSexChoice;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHeightSmall;
        private Label lblHeightSmall;
        private TextBox txtAge;
        private Label label6;
        private TextBox txtWeightNum;
        private Button btnCalculate;
        private Label label7;
        private TextBox txtResult;
        private Button btnClose;
        private Label lblWeight;
        private Label label4;
        private ComboBox cmbMeasureStyle;
        private TextBox txtHeightBig;
        private Label label5;
        private Label label8;
        private TextBox txtScale;
        private Label label9;
    }
}