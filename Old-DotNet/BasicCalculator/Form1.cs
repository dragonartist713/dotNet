namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(txtFirstNumber.Text);
            decimal secondNumber = Convert.ToDecimal(txtSecondNumber.Text);

            decimal myAnswer = firstNumber + secondNumber;
            txtAnswer.Text = myAnswer.ToString();
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(txtFirstNumber.Text);
            decimal secondNumber = Convert.ToDecimal(txtSecondNumber.Text);
            decimal myAnswer = firstNumber - secondNumber;
            txtAnswer.Text = myAnswer.ToString();
        }
    }
}