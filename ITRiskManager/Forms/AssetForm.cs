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
    public partial class AssetForm : Form
    {
        public AssetForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtAssetName.Text=="" || txtAssetType.Text=="" || txtAssetOwner.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }
            int CriticalityScore;
            if(!int.TryParse(txtCriticalityScore.Text, out CriticalityScore))
            {
                MessageBox.Show("Kritiklik skoru sayı olmalıdır!");
                return;
            }
            if (CriticalityScore<1 ||  CriticalityScore > 5)
            {
                MessageBox.Show("Kritiklik skoru 1 ve 5 arasında olmalıdır!");
                return;
            }
            SqlConnection con= DatabaseHelper.GetConnection();
            con.Open();
            string query = "INSERT INTO Assets (AssetName, AssetType, AssetOwner, CriticalityScore) " +
                 "VALUES (@AssetName, @AssetType, @AssetOwner, @CriticalityScore)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@AssetName", txtAssetName.Text);
            cmd.Parameters.AddWithValue("@AssetType", txtAssetType.Text);
            cmd.Parameters.AddWithValue("@AssetOwner", txtAssetOwner.Text);
            cmd.Parameters.AddWithValue("@CriticalityScore", CriticalityScore);

            // 5. Çalıştır
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Varlık eklendi!");
            // Alanları temizle
            txtAssetName.Clear();
            txtAssetType.Clear();
            txtAssetOwner.Clear();
            txtCriticalityScore.Clear();
            LoadAssets();
        }

        private void LoadAssets()
        {
            SqlConnection con= DatabaseHelper.GetConnection();
            con.Open();
            string query = "SELECT * FROM Assets";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dgvAssets.DataSource = dt;
            con.Close();
        }

        private void AssetForm_Load(object sender, EventArgs e)
        {
            LoadAssets();
        }
    }
}
