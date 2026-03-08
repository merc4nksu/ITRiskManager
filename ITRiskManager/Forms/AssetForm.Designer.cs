namespace ITRiskManager.Forms
{
    partial class AssetForm
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
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.txtAssetOwner = new System.Windows.Forms.TextBox();
            this.txtCriticalityScore = new System.Windows.Forms.TextBox();
            this.txtAssetType = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAssetName
            // 
            this.txtAssetName.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.txtAssetName.Location = new System.Drawing.Point(244, 32);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(100, 29);
            this.txtAssetName.TabIndex = 4;
            // 
            // txtAssetOwner
            // 
            this.txtAssetOwner.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.txtAssetOwner.Location = new System.Drawing.Point(244, 91);
            this.txtAssetOwner.Name = "txtAssetOwner";
            this.txtAssetOwner.Size = new System.Drawing.Size(100, 29);
            this.txtAssetOwner.TabIndex = 5;
            // 
            // txtCriticalityScore
            // 
            this.txtCriticalityScore.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.txtCriticalityScore.Location = new System.Drawing.Point(642, 94);
            this.txtCriticalityScore.Name = "txtCriticalityScore";
            this.txtCriticalityScore.Size = new System.Drawing.Size(100, 29);
            this.txtCriticalityScore.TabIndex = 6;
            // 
            // txtAssetType
            // 
            this.txtAssetType.Font = new System.Drawing.Font("Segoe UI Emoji", 12.25F);
            this.txtAssetType.Location = new System.Drawing.Point(642, 30);
            this.txtAssetType.Name = "txtAssetType";
            this.txtAssetType.Size = new System.Drawing.Size(100, 29);
            this.txtAssetType.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.btnKaydet.Location = new System.Drawing.Point(624, 155);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 42);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Varlık Adı: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Varlık Tipi:";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sahibi:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kritiklik (1-5):";
            // 
            // dgvAssets
            // 
            this.dgvAssets.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Location = new System.Drawing.Point(117, 239);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.Size = new System.Drawing.Size(545, 183);
            this.dgvAssets.TabIndex = 13;
            // 
            // AssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAssets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAssetType);
            this.Controls.Add(this.txtCriticalityScore);
            this.Controls.Add(this.txtAssetOwner);
            this.Controls.Add(this.txtAssetName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AssetForm";
            this.Text = "AssetForm";
            this.Load += new System.EventHandler(this.AssetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.TextBox txtAssetOwner;
        private System.Windows.Forms.TextBox txtCriticalityScore;
        private System.Windows.Forms.TextBox txtAssetType;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAssets;
    }
}