using System;
using System.Windows.Forms;

namespace ForexLotCalculation
{
    public partial class Form1 : Form
    {
        const int BrokerLotValue = 100000;

        public Form1()
        {
            InitializeComponent();

            txtInfo.Clear();
            txtRiskManagementInfo.Clear();
            SetDefaultInfo(txtInvestments.Text);
            SetDefaultInfoLot(txtInvestments.Text);
        }

        private void SetDefaultInfoLot(string value)
        {
            var investmentValue = decimal.Parse(value);

        }

        private void SetDefaultInfo(string value)
        {
           
            var investmentValue = double.Parse(value);

            var riskLimite = investmentValue * 0.01;

            txtInfo.Text = "Risk Limite is " + riskLimite.ToString() + " $" ?? "";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            SetRiskManagementInformation(txtStoplossPerPip.Text, txtProfitPerPip.Text);

            SetSpreadBetting(txtStoplossPerPip.Text, txtProfitPerPip.Text, txtInvestments.Text);

            SetCFD(txtStoplossPerPip.Text, txtProfitPerPip.Text, txtInvestments.Text);
        }

        private void SetCFD(string txtStoplossPerPip, string txtProfitPerPip, string txtInvestments)
        {
            txtMaxLoss_CFD.Text = Convert.ToString(decimal.Parse(txtInvestments) * (decimal)0.01);

            txtMinProfit_CFD.Text = Convert.ToString(decimal.Parse(txtMaxLoss_CFD.Text) * 3);

            var volume = decimal.Parse(txtMaxLoss_CFD.Text) / decimal.Parse(txtStoplossPerPip);

            /********************************************/
            var lot = BrokerLotValue * (decimal)0.0001;

            txtQuantity_CFD.Text = String.Format("{0:0.000}", volume / lot);
        }

        private void SetSpreadBetting(string txtStoplossPerPip, string txtProfitPerPip, string txtInvestments)
        {
            txtMaxLoss.Text = Convert.ToString(decimal.Parse(txtInvestments) * (decimal)0.01);

            txtMinProfit.Text = Convert.ToString(decimal.Parse(txtMaxLoss.Text) * 3);

            txtQuantity.Text = String.Format("{0:0.000}", decimal.Parse(txtMaxLoss.Text) / decimal.Parse(txtStoplossPerPip)); 
        }

        private void SetRiskManagementInformation(string txtStoplossPerPip, string txtProfitPerPip)
        {
            var result = decimal.Parse(txtProfitPerPip) / decimal.Parse(txtStoplossPerPip);

            txtRiskManagementInfo.Clear();
            txtRiskManagementInfo.Text = string.Format(" Risk to Riward is = {0} \r\n", result);

            if (result < 3)
            {
                txtRiskManagementInfo.Text += string.Format(" *** YOUR DEAL WITH RISK *** ");
            }
            else
            {
                txtRiskManagementInfo.Text += string.Format(" *** Your deal is safe from risk *** ");
            }
        }

        private void txtInvestments_TextChanged(object sender, EventArgs e)
        {
            SetDefaultInfo(txtInvestments.Text);
        }

        private void txtInvestments_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
