namespace calcAreaPerim
{
    public partial class frmAreaPeri : Form
    {
        public frmAreaPeri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal width = Convert.ToDecimal(txtWidth.Text);
            decimal area = length * width;
            decimal perimeter = (length + width) + (length + width);

            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();
        }
    }
}