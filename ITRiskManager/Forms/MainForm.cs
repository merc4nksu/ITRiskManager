using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITRiskManager.Forms;

namespace ITRiskManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAsset_Click(object sender, EventArgs e)
        {
            AssetForm assetForm=new AssetForm();
            assetForm.Show();
        }

        private void btnRisk_Click(object sender, EventArgs e)
        {
            RiskForm riskForm=new RiskForm();
            riskForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm=new ReportForm();
            reportForm.Show();
        }
    }
}
