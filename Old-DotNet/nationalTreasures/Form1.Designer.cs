namespace nationalTreasures
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboContinent = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboAttraction = new System.Windows.Forms.ComboBox();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.imgPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Continent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Attraction:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Guests:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment Type:";
            // 
            // cboContinent
            // 
            this.cboContinent.FormattingEnabled = true;
            this.cboContinent.Location = new System.Drawing.Point(136, 41);
            this.cboContinent.Name = "cboContinent";
            this.cboContinent.Size = new System.Drawing.Size(193, 23);
            this.cboContinent.TabIndex = 5;
            this.cboContinent.SelectedIndexChanged += new System.EventHandler(this.cboContinent_SelectedIndexChanged);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(136, 105);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(193, 23);
            this.cboCountry.TabIndex = 6;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // cboAttraction
            // 
            this.cboAttraction.FormattingEnabled = true;
            this.cboAttraction.Location = new System.Drawing.Point(136, 175);
            this.cboAttraction.Name = "cboAttraction";
            this.cboAttraction.Size = new System.Drawing.Size(193, 23);
            this.cboAttraction.TabIndex = 7;
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(136, 232);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(193, 23);
            this.txtNumberOfPeople.TabIndex = 8;
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Location = new System.Drawing.Point(136, 285);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(193, 23);
            this.cboPaymentType.TabIndex = 9;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(89, 357);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(178, 23);
            this.btnPurchase.TabIndex = 10;
            this.btnPurchase.Text = "Purchase Tickets";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_MouseClick);
            this.btnPurchase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPurchase_MouseClick);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 487);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(846, 96);
            this.txtAnswer.TabIndex = 11;
            this.txtAnswer.Text = "Welcome to the trip planner!  Only $500 per person!";
            // 
            // imgPicture
            // 
            this.imgPicture.Image = ((System.Drawing.Image)(resources.GetObject("imgPicture.Image")));
            this.imgPicture.Location = new System.Drawing.Point(373, 41);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(485, 339);
            this.imgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPicture.TabIndex = 12;
            this.imgPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 595);
            this.Controls.Add(this.imgPicture);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.cboAttraction);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboContinent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Flights of Fancy Travel Agency";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboContinent;
        private ComboBox cboCountry;
        private ComboBox cboAttraction;
        private TextBox txtNumberOfPeople;
        private ComboBox cboPaymentType;
        private Button btnPurchase;
        private RichTextBox txtAnswer;
        private PictureBox imgPicture;
    }
}