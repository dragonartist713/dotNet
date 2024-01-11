namespace currConvCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {           
            decimal dollar = Convert.ToDecimal(txtAmountUSD.Text);
            decimal currency;

            if (cmbCurrList.Text == "Euro (EUR)")
            {
                currency = dollar * 0.88m;
                txtResults.Text = ("€" + Convert.ToString(Math.Round(currency, 2)));
            }
            else if (cmbCurrList.Text == "Japanese Yen (JPY)")
            {
                currency = dollar * 115.48m;
                txtResults.Text = ("¥" + Convert.ToString(Math.Round(currency, 2)));
            }
            else if (cmbCurrList.Text == "Mexican Peso (MXN)")
            {
                currency = dollar * 20.31m;
                txtResults.Text = ("Mex$" + Convert.ToString(Math.Round(currency, 2)));
            }
            else if (cmbCurrList.Text == "Canadian Dollar (CAD)")
            {
                currency = dollar * 1.27m;
                txtResults.Text = ("C$" + Convert.ToString(Math.Round(currency, 2)));
            }
            else if (cmbCurrList.Text == "Indian Rupee (INR)")
            {
                currency = dollar * 75.01m;
                txtResults.Text = ("₹" + Convert.ToString(Math.Round(currency, 2)));
            }
        }
    }
}