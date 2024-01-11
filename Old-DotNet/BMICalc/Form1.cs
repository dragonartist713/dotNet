using System;

namespace BMICalc
{
    public partial class BMICalc : Form
    {
        public BMICalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal bigHeight = Convert.ToDecimal(txtHeightBig.Text);
            decimal smHeight = Convert.ToDecimal(txtHeightSmall.Text);
            decimal weight = Convert.ToDecimal(txtWeightNum.Text);
            decimal myAnswer;

            if (cmbMeasureStyle.Text == "Metric")
            {
                decimal mHeight = bigHeight + (smHeight / 100);

                myAnswer = weight / (mHeight * mHeight);
                txtResult.Text = myAnswer.ToString();
            }
            else
            {
                decimal eHeight = (bigHeight * 12) + smHeight;

                myAnswer = Math.Round((weight / (eHeight * eHeight)) * 703);
                txtResult.Text = myAnswer.ToString();
            }

            if (myAnswer < 18.5m)
            {
                txtScale.Text = "Underweight";
            }
            else if (myAnswer <= 24.9m)
            {
                txtScale.Text = "Normal";
            }
            else if (myAnswer <= 29.9m)
            {
                txtScale.Text = "Overweight";
            }
            else if (myAnswer <= 35)
            {
                txtScale.Text = "Obese";
            }
            else
            {
                txtScale.Text = "Very Obese";
            };

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}