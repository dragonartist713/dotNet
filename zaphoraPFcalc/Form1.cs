namespace zaphoraPFcalc
{
    public partial class frmZaphoraCalc : Form
    {
        public frmZaphoraCalc()
        {
            InitializeComponent();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculateSpellbook_Click(object sender, EventArgs e)
        {
            decimal level0num = Convert.ToDecimal(txtLevel0Spells.Text);
            decimal level1num = Convert.ToDecimal(txtLevel1Spells.Text);
            decimal level2num = Convert.ToDecimal(txtLevel2Spells.Text);
            decimal level3num = Convert.ToDecimal(txtLevel3Spells.Text);
            decimal level4num = Convert.ToDecimal(txtLevel4Spells.Text);
            decimal level5num = Convert.ToDecimal(txtLevel5Spells.Text);
            decimal level6num = Convert.ToDecimal(txtLevel6Spells.Text);
            decimal level7num = Convert.ToDecimal(txtLevel7Spells.Text);
            decimal level8num = Convert.ToDecimal(txtLevel8Spells.Text);
            decimal level9num = Convert.ToDecimal(txtLevel9Spells.Text);

         
            //determine true value of the spellbook
            decimal total = 15;

            if(radFancy.Checked == true)
            {
                total += 85;
            }

            total += (level0num * 7.5m) + (level1num * 15) + (level2num * 60) + (level3num * 135) + (level4num * 240) + (level5num * 325) + (level6num * 540) + (level7num * 735) + (level8num * 960) + (level9num * 1215);

            txtTrueValue.Text = Convert.ToString(total);
            txtTrueSell.Text = Convert.ToString(total/2);

            //determine what player thinks its worth base on appraise check
            int appraiseCheck = Convert.ToInt32(txtAppraiseCheck.Text);
            int appraiseDC = Convert.ToInt32(txtAppraiseDC.Text);

            if(appraiseCheck >= appraiseDC)
            {
                txtPlayerValue.Text = txtTrueValue.Text;
                txtPlayerSell.Text = txtTrueSell.Text;
                txtWrongness.Text = Convert.ToString(1);
            }
            else if(appraiseCheck <= appraiseDC)
            {
                if (appraiseCheck >= (appraiseDC - 5))
                {
                    Random rnd = new Random();
                    decimal wrongness = Convert.ToDecimal(rnd.NextDouble() * 0.4 + 0.8);
                    decimal playerValueFail1 = total * wrongness;
                    txtPlayerValue.Text = Convert.ToString(playerValueFail1);
                    txtPlayerSell.Text = Convert.ToString(playerValueFail1 / 2);
                    txtWrongness.Text = Convert.ToString(wrongness);
                }
                else
                {
                    Random rnd = new Random();
                    decimal wrongness = Convert.ToDecimal(rnd.NextDouble() * 1.5 + 0.5);
                    decimal playerValueFail2 = total * wrongness;
                    txtPlayerValue.Text = Convert.ToString(playerValueFail2);
                    txtPlayerSell.Text = Convert.ToString(playerValueFail2 / 2);
                    txtWrongness.Text = Convert.ToString(wrongness);
                }
            }
            
        }

        private void tabPage2_Load(object sender, EventArgs e)
        {

        }
    }
}