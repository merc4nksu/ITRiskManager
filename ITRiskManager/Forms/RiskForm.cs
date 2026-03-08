using ITRiskManager.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRiskManager.Forms
{
    public partial class RiskForm : Form
    {
        public RiskForm()
        {
            InitializeComponent();
        }

        private void RiskForm_Load(object sender, EventArgs e)
        {
            LoadAssets();
            LoadThreats();
            LoadVulnerabilities();
            LoadRisks();
        }

        private void LoadAssets()
        {
            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();
            string query = "SELECT AssetID, AssetName FROM Assets";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt= new DataTable();
            da.Fill(dt);
            cmbAsset.DataSource= dt;
            cmbAsset.DisplayMember= "AssetName";
            cmbAsset.ValueMember = "AssetID";
            con.Close();
        }
        private void LoadThreats()
        {
            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();
            string query = "SELECT ThreatID, ThreatName FROM Threats";
            SqlDataAdapter da = new SqlDataAdapter( query, con);
            DataTable dt= new DataTable();
            da.Fill(dt);
            cmbThreat.DataSource= dt;
            cmbThreat.DisplayMember = "ThreatName";
            cmbThreat.ValueMember = "ThreatID";
            con.Close();
        }
        private void LoadVulnerabilities()
        {
            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();
            string query = "SELECT VulID, VulName FROM Vulnerabilities";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt= new DataTable();
            da.Fill(dt);
            cmbVul.DataSource= dt;
            cmbVul.DisplayMember = "VulName";
            cmbVul.ValueMember = "VulID";
            con.Close();
        }
        private void LoadRisks()
        {
            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();
            string query = @"SELECT a.AssetName, t.ThreatName, v.VulName, 
                     r.Probability, r.Impact, r.RiskScore, r.RiskLevel
                     FROM Risks r
                     JOIN Assets a ON r.AssetID = a.AssetID
                     JOIN Threats t ON r.ThreatID = t.ThreatID
                     JOIN Vulnerabilities v ON r.VulID = v.VulID";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRisks.DataSource = dt;
            con.Close();
        }

        private void btnRiskKaydet_Click(object sender, EventArgs e)
        {
            if(txtProbability.Text=="" || txtImpact.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }
            int probability, impact;
            if (!int.TryParse(txtProbability.Text, out probability) || !int.TryParse(txtImpact.Text, out impact))
            {
                MessageBox.Show("Olasılık ve etki sayı olmalıdır!");
                return;
            }
            if( probability <1 || probability>5 || impact<1 || impact > 5)
            {
                MessageBox.Show("Olasılık ve etki 1-5 arasında olmalıdır!");
                return;
            }

            int assetID= (int)cmbAsset.SelectedValue;
            int threatID= (int)cmbThreat.SelectedValue;
            int vulID= (int)cmbVul.SelectedValue;

            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();
            string query = "INSERT INTO Risks (AssetID, ThreatID, VulID, Probability, Impact)" + "VALUES (@AssetID, @ThreatID, @VulID, @Probability, @Impact)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@AssetID", assetID);
            cmd.Parameters.AddWithValue("@ThreatID", threatID);
            cmd.Parameters.AddWithValue("@VulID", vulID);
            cmd.Parameters.AddWithValue("@Probability", probability);
            cmd.Parameters.AddWithValue("@Impact", impact);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Risk kaydedildi!");
            // Alanları temizle
            txtProbability.Clear();
            txtImpact.Clear();
            cmbAsset.SelectedIndex = 0;
            cmbThreat.SelectedIndex = 0;
            cmbVul.SelectedIndex = 0;
            LoadRisks();
        }
    }
}
