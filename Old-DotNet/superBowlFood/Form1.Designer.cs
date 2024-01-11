namespace superBowlFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPizzaQty = new System.Windows.Forms.ComboBox();
            this.cmbNachoQty = new System.Windows.Forms.ComboBox();
            this.cmbSaladQty = new System.Windows.Forms.ComboBox();
            this.cmbWingQty = new System.Windows.Forms.ComboBox();
            this.cmbVeggieQty = new System.Windows.Forms.ComboBox();
            this.txtPizzaSubtotal = new System.Windows.Forms.TextBox();
            this.txtNachoSubtotal = new System.Windows.Forms.TextBox();
            this.txtSaladSubtotal = new System.Windows.Forms.TextBox();
            this.txtWingSubtotal = new System.Windows.Forms.TextBox();
            this.txtVeggieSubtotal = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGratuityAmt = new System.Windows.Forms.ComboBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtGratuity = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pizza by the Slice ($4.00)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nacho Basket ($8.00)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Large Salad ($7.00)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chicken Wings per lb. ($9.00)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Veggie Tray with dip ($12.00)";
            // 
            // cmbPizzaQty
            // 
            this.cmbPizzaQty.FormattingEnabled = true;
            this.cmbPizzaQty.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbPizzaQty.Location = new System.Drawing.Point(580, 41);
            this.cmbPizzaQty.Name = "cmbPizzaQty";
            this.cmbPizzaQty.Size = new System.Drawing.Size(49, 23);
            this.cmbPizzaQty.TabIndex = 7;
            this.cmbPizzaQty.Text = "0";
            // 
            // cmbNachoQty
            // 
            this.cmbNachoQty.FormattingEnabled = true;
            this.cmbNachoQty.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNachoQty.Location = new System.Drawing.Point(580, 89);
            this.cmbNachoQty.Name = "cmbNachoQty";
            this.cmbNachoQty.Size = new System.Drawing.Size(49, 23);
            this.cmbNachoQty.TabIndex = 8;
            this.cmbNachoQty.Text = "0";
            // 
            // cmbSaladQty
            // 
            this.cmbSaladQty.FormattingEnabled = true;
            this.cmbSaladQty.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbSaladQty.Location = new System.Drawing.Point(580, 134);
            this.cmbSaladQty.Name = "cmbSaladQty";
            this.cmbSaladQty.Size = new System.Drawing.Size(49, 23);
            this.cmbSaladQty.TabIndex = 9;
            this.cmbSaladQty.Text = "0";
            // 
            // cmbWingQty
            // 
            this.cmbWingQty.FormattingEnabled = true;
            this.cmbWingQty.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbWingQty.Location = new System.Drawing.Point(580, 184);
            this.cmbWingQty.Name = "cmbWingQty";
            this.cmbWingQty.Size = new System.Drawing.Size(49, 23);
            this.cmbWingQty.TabIndex = 10;
            this.cmbWingQty.Text = "0";
            // 
            // cmbVeggieQty
            // 
            this.cmbVeggieQty.FormattingEnabled = true;
            this.cmbVeggieQty.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbVeggieQty.Location = new System.Drawing.Point(580, 228);
            this.cmbVeggieQty.Name = "cmbVeggieQty";
            this.cmbVeggieQty.Size = new System.Drawing.Size(49, 23);
            this.cmbVeggieQty.TabIndex = 11;
            this.cmbVeggieQty.Text = "0";
            // 
            // txtPizzaSubtotal
            // 
            this.txtPizzaSubtotal.Location = new System.Drawing.Point(649, 41);
            this.txtPizzaSubtotal.Name = "txtPizzaSubtotal";
            this.txtPizzaSubtotal.Size = new System.Drawing.Size(73, 23);
            this.txtPizzaSubtotal.TabIndex = 12;
            this.txtPizzaSubtotal.TextChanged += new System.EventHandler(this.txtPizzaSubtotal_TextChanged);
            // 
            // txtNachoSubtotal
            // 
            this.txtNachoSubtotal.Location = new System.Drawing.Point(649, 89);
            this.txtNachoSubtotal.Name = "txtNachoSubtotal";
            this.txtNachoSubtotal.Size = new System.Drawing.Size(73, 23);
            this.txtNachoSubtotal.TabIndex = 13;
            // 
            // txtSaladSubtotal
            // 
            this.txtSaladSubtotal.Location = new System.Drawing.Point(649, 134);
            this.txtSaladSubtotal.Name = "txtSaladSubtotal";
            this.txtSaladSubtotal.Size = new System.Drawing.Size(73, 23);
            this.txtSaladSubtotal.TabIndex = 14;
            // 
            // txtWingSubtotal
            // 
            this.txtWingSubtotal.Location = new System.Drawing.Point(649, 184);
            this.txtWingSubtotal.Name = "txtWingSubtotal";
            this.txtWingSubtotal.Size = new System.Drawing.Size(73, 23);
            this.txtWingSubtotal.TabIndex = 15;
            // 
            // txtVeggieSubtotal
            // 
            this.txtVeggieSubtotal.Location = new System.Drawing.Point(649, 228);
            this.txtVeggieSubtotal.Name = "txtVeggieSubtotal";
            this.txtVeggieSubtotal.Size = new System.Drawing.Size(73, 23);
            this.txtVeggieSubtotal.TabIndex = 16;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(785, 65);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(51, 15);
            this.Subtotal.TabIndex = 17;
            this.Subtotal.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(785, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tax (5.5%)";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(889, 62);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(785, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gratuity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(785, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Grand Total";
            // 
            // cmbGratuityAmt
            // 
            this.cmbGratuityAmt.FormattingEnabled = true;
            this.cmbGratuityAmt.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%"});
            this.cmbGratuityAmt.Location = new System.Drawing.Point(840, 164);
            this.cmbGratuityAmt.Name = "cmbGratuityAmt";
            this.cmbGratuityAmt.Size = new System.Drawing.Size(43, 23);
            this.cmbGratuityAmt.TabIndex = 22;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(889, 111);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 23);
            this.txtTax.TabIndex = 23;
            // 
            // txtGratuity
            // 
            this.txtGratuity.Location = new System.Drawing.Point(889, 164);
            this.txtGratuity.Name = "txtGratuity";
            this.txtGratuity.Size = new System.Drawing.Size(100, 23);
            this.txtGratuity.TabIndex = 24;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(889, 210);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 25;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(1043, 114);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 68);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calculate Total!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 279);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtGratuity);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.cmbGratuityAmt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.txtVeggieSubtotal);
            this.Controls.Add(this.txtWingSubtotal);
            this.Controls.Add(this.txtSaladSubtotal);
            this.Controls.Add(this.txtNachoSubtotal);
            this.Controls.Add(this.txtPizzaSubtotal);
            this.Controls.Add(this.cmbVeggieQty);
            this.Controls.Add(this.cmbWingQty);
            this.Controls.Add(this.cmbSaladQty);
            this.Controls.Add(this.cmbNachoQty);
            this.Controls.Add(this.cmbPizzaQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Super Bowl Food Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbPizzaQty;
        private ComboBox cmbNachoQty;
        private ComboBox cmbSaladQty;
        private ComboBox cmbWingQty;
        private ComboBox cmbVeggieQty;
        private TextBox txtPizzaSubtotal;
        private TextBox txtNachoSubtotal;
        private TextBox txtSaladSubtotal;
        private TextBox txtWingSubtotal;
        private TextBox txtVeggieSubtotal;
        private Label Subtotal;
        private Label label8;
        private TextBox txtSubtotal;
        private Label label9;
        private Label label10;
        private ComboBox cmbGratuityAmt;
        private TextBox txtTax;
        private TextBox txtGratuity;
        private TextBox txtTotal;
        private Button btnCalculate;
    }
}