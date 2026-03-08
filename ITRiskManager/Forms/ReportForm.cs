using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ITRiskManager.Database;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace ITRiskManager.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        // Form açılınca raporu yükle
        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        // Tüm riskleri JOIN ile çekip DataGridView'a yükler
        private void LoadReport()
        {
            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();

            // Varlık, tehdit, zafiyet bilgilerini risk tablosuyla birleştir
            string query = @"SELECT 
                        a.AssetName AS 'Varlık',
                        t.ThreatName AS 'Tehdit',
                        v.VulName AS 'Zafiyet',
                        r.Probability AS 'Olasılık',
                        r.Impact AS 'Etki',
                        r.RiskScore AS 'Risk Skoru',
                        r.RiskLevel AS 'Risk Seviyesi',
                        r.CreatedAt AS 'Tarih'
                    FROM Risks r
                    JOIN Assets a ON r.AssetID = a.AssetID
                    JOIN Threats t ON r.ThreatID = t.ThreatID
                    JOIN Vulnerabilities v ON r.VulID = v.VulID
                    ORDER BY r.RiskScore DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReport.DataSource = dt;
            con.Close();

            // Satırları renge göre renklendir
            ColorRows();
        }

        // Risk seviyesine göre satır arka plan rengini ayarlar
        private void ColorRows()
        {
            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                string level = row.Cells["Risk Seviyesi"].Value?.ToString();

                if (level == "Kritik")
                    row.DefaultCellStyle.BackColor = Color.Red;
                else if (level == "Yüksek")
                    row.DefaultCellStyle.BackColor = Color.Orange;
                else if (level == "Orta")
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                else if (level == "Düşük")
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        // Raporu yeniden yükler
        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        // Raporu Excel dosyasına aktarır
        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Kullanıcıya kayıt yeri sor
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "RiskRaporu";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("Risk Raporu");

                // Başlık satırını yaz ve kalın yap
                ws.Cells[1, 1].Value = "Varlık";
                ws.Cells[1, 2].Value = "Tehdit";
                ws.Cells[1, 3].Value = "Zafiyet";
                ws.Cells[1, 4].Value = "Olasılık";
                ws.Cells[1, 5].Value = "Etki";
                ws.Cells[1, 6].Value = "Risk Skoru";
                ws.Cells[1, 7].Value = "Risk Seviyesi";
                ws.Cells[1, 8].Value = "Tarih";
                ws.Cells[1, 1, 1, 8].Style.Font.Bold = true;

                // DataGridView'daki verileri Excel'e aktar
                int row = 2;
                foreach (DataGridViewRow dgvRow in dgvReport.Rows)
                {
                    if (dgvRow.IsNewRow) continue;

                    ws.Cells[row, 1].Value = dgvRow.Cells["Varlık"].Value;
                    ws.Cells[row, 2].Value = dgvRow.Cells["Tehdit"].Value;
                    ws.Cells[row, 3].Value = dgvRow.Cells["Zafiyet"].Value;
                    ws.Cells[row, 4].Value = dgvRow.Cells["Olasılık"].Value;
                    ws.Cells[row, 5].Value = dgvRow.Cells["Etki"].Value;
                    ws.Cells[row, 6].Value = dgvRow.Cells["Risk Skoru"].Value;
                    ws.Cells[row, 7].Value = dgvRow.Cells["Risk Seviyesi"].Value;
                    ws.Cells[row, 8].Value = dgvRow.Cells["Tarih"].Value;
                    ws.Cells[row, 8].Style.Numberformat.Format = "dd/MM/yyyy HH:mm";
                    row++;
                }

                // Sütun genişliklerini otomatik ayarla
                ws.Cells.AutoFitColumns();

                FileInfo fi = new FileInfo(sfd.FileName);
                package.SaveAs(fi);
            }

            MessageBox.Show("Excel raporu oluşturuldu!");
        }
    }
}