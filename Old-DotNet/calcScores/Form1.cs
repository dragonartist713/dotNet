namespace calcScores
{
    public partial class frmScoreCalc : Form
    {
        public frmScoreCalc()
        {
            InitializeComponent();
        }

        int numberOfScores = 0;
        decimal totalOfScores = 0m;
        decimal scoreAverage = 0m;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal score = Convert.ToDecimal(txtScore.Text);
            
            numberOfScores++;
            totalOfScores += score;
            scoreAverage = totalOfScores / numberOfScores;

            txtScoreTotal.Text = totalOfScores.ToString();
            txtScoreCount.Text = numberOfScores.ToString();
            txtAverage.Text = scoreAverage.ToString();
           
            txtScore.Text = "";
            txtScore.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numberOfScores = 0;
            totalOfScores = 0m;
            scoreAverage = 0m;

            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();
        }
    }
}