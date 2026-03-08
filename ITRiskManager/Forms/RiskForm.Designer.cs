namespace ITRiskManager.Forms
{
    partial class RiskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAsset = new System.Windows.Forms.ComboBox();
            this.cmbThreat = new System.Windows.Forms.ComboBox();
            this.cmbVul = new System.Windows.Forms.ComboBox();
            this.txtProbability = new System.Windows.Forms.TextBox();
            this.txtImpact = new System.Windows.Forms.TextBox();
            this.btnRiskKaydet = new System.Windows.Forms.Button();
            this.dgvRisks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varlık Seç";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tehdit Seç";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zaafiyet Seç";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Etki (1-5):";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Olasılık (1-5):";
            // 
            // cmbAsset
            // 
            this.cmbAsset.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.cmbAsset.FormattingEnabled = true;
            this.cmbAsset.Location = new System.Drawing.Point(210, 38);
            this.cmbAsset.Name = "cmbAsset";
            this.cmbAsset.Size = new System.Drawing.Size(121, 29);
            this.cmbAsset.TabIndex = 5;
            // 
            // cmbThreat
            // 
            this.cmbThreat.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.cmbThreat.FormattingEnabled = true;
            this.cmbThreat.Location = new System.Drawing.Point(210, 98);
            this.cmbThreat.Name = "cmbThreat";
            this.cmbThreat.Size = new System.Drawing.Size(121, 29);
            this.cmbThreat.TabIndex = 6;
            // 
            // cmbVul
            // 
            this.cmbVul.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.cmbVul.FormattingEnabled = true;
            this.cmbVul.Location = new System.Drawing.Point(210, 155);
            this.cmbVul.Name = "cmbVul";
            this.cmbVul.Size = new System.Drawing.Size(121, 29);
            this.cmbVul.TabIndex = 7;
            // 
            // txtProbability
            // 
            this.txtProbability.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.txtProbability.Location = new System.Drawing.Point(624, 36);
            this.txtProbability.Name = "txtProbability";
            this.txtProbability.Size = new System.Drawing.Size(100, 29);
            this.txtProbability.TabIndex = 8;
            // 
            // txtImpact
            // 
            this.txtImpact.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.txtImpact.Location = new System.Drawing.Point(624, 91);
            this.txtImpact.Name = "txtImpact";
            this.txtImpact.Size = new System.Drawing.Size(100, 29);
            this.txtImpact.TabIndex = 9;
            // 
            // btnRiskKaydet
            // 
            this.btnRiskKaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRiskKaydet.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.btnRiskKaydet.Location = new System.Drawing.Point(591, 155);
            this.btnRiskKaydet.Name = "btnRiskKaydet";
            this.btnRiskKaydet.Size = new System.Drawing.Size(133, 47);
            this.btnRiskKaydet.TabIndex = 10;
            this.btnRiskKaydet.Text = "Kaydet";
            this.btnRiskKaydet.UseVisualStyleBackColor = false;
            this.btnRiskKaydet.Click += new System.EventHandler(this.btnRiskKaydet_Click);
            // 
            // dgvRisks
            // 
            this.dgvRisks.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRisks.Location = new System.Drawing.Point(53, 247);
            this.dgvRisks.Name = "dgvRisks";
            this.dgvRisks.Size = new System.Drawing.Size(691, 150);
            this.dgvRisks.TabIndex = 11;
            // 
            // RiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRisks);
            this.Controls.Add(this.btnRiskKaydet);
            this.Controls.Add(this.txtImpact);
            this.Controls.Add(this.txtProbability);
            this.Controls.Add(this.cmbVul);
            this.Controls.Add(this.cmbThreat);
            this.Controls.Add(this.cmbAsset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RiskForm";
            this.Text = "RiskForm";
            this.Load += new System.EventHandler(this.RiskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAsset;
        private System.Windows.Forms.ComboBox cmbThreat;
        private System.Windows.Forms.ComboBox cmbVul;
        private System.Windows.Forms.TextBox txtProbability;
        private System.Windows.Forms.TextBox txtImpact;
        private System.Windows.Forms.Button btnRiskKaydet;
        private System.Windows.Forms.DataGridView dgvRisks;
    }
}