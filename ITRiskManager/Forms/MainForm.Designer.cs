namespace ITRiskManager
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAsset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRisk = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsset
            // 
            this.btnAsset.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAsset.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsset.Location = new System.Drawing.Point(36, 144);
            this.btnAsset.Name = "btnAsset";
            this.btnAsset.Size = new System.Drawing.Size(156, 49);
            this.btnAsset.TabIndex = 0;
            this.btnAsset.Text = "Varlık Yönetimi";
            this.btnAsset.UseVisualStyleBackColor = false;
            this.btnAsset.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 16.75F);
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "IT Risk Yönetim Sistemi";
            // 
            // btnRisk
            // 
            this.btnRisk.BackColor = System.Drawing.Color.LightGray;
            this.btnRisk.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRisk.Location = new System.Drawing.Point(246, 144);
            this.btnRisk.Name = "btnRisk";
            this.btnRisk.Size = new System.Drawing.Size(199, 49);
            this.btnRisk.TabIndex = 2;
            this.btnRisk.Text = "Risk Değerlendirme";
            this.btnRisk.UseVisualStyleBackColor = false;
            this.btnRisk.Click += new System.EventHandler(this.btnRisk_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LightGray;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(508, 144);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(156, 49);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Raporlar";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 344);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsset);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRisk;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAsset;
    }
}

