namespace WindowsFormsApp1
{
    partial class FrmFaturaUrunDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaUrunDuzenleme));
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtFıyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtURUNID = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunad = new DevExpress.XtraEditors.TextEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtMıktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFıyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURUNID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMıktar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.groupControl5.Appearance.Options.UseBackColor = true;
            this.groupControl5.Controls.Add(this.BtnSil);
            this.groupControl5.Controls.Add(this.BtnGuncelle);
            this.groupControl5.Controls.Add(this.txtFıyat);
            this.groupControl5.Controls.Add(this.labelControl9);
            this.groupControl5.Controls.Add(this.labelControl1);
            this.groupControl5.Controls.Add(this.txtURUNID);
            this.groupControl5.Controls.Add(this.txtUrunad);
            this.groupControl5.Controls.Add(this.txtTutar);
            this.groupControl5.Controls.Add(this.labelControl12);
            this.groupControl5.Controls.Add(this.txtMıktar);
            this.groupControl5.Controls.Add(this.labelControl10);
            this.groupControl5.Controls.Add(this.labelControl4);
            this.groupControl5.Location = new System.Drawing.Point(12, 12);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(293, 321);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "groupControl5";
            // 
            // txtFıyat
            // 
            this.txtFıyat.Location = new System.Drawing.Point(125, 103);
            this.txtFıyat.Name = "txtFıyat";
            this.txtFıyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFıyat.Properties.Appearance.Options.UseFont = true;
            this.txtFıyat.Size = new System.Drawing.Size(160, 28);
            this.txtFıyat.TabIndex = 40;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(65, 106);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 22);
            this.labelControl9.TabIndex = 39;
            this.labelControl9.Text = "Fiyat :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 22);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "ÜRÜN ID :";
            // 
            // txtURUNID
            // 
            this.txtURUNID.Location = new System.Drawing.Point(125, 9);
            this.txtURUNID.Name = "txtURUNID";
            this.txtURUNID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtURUNID.Properties.Appearance.Options.UseFont = true;
            this.txtURUNID.Size = new System.Drawing.Size(160, 28);
            this.txtURUNID.TabIndex = 35;
            // 
            // txtUrunad
            // 
            this.txtUrunad.Location = new System.Drawing.Point(125, 40);
            this.txtUrunad.Name = "txtUrunad";
            this.txtUrunad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunad.Properties.Appearance.Options.UseFont = true;
            this.txtUrunad.Size = new System.Drawing.Size(160, 28);
            this.txtUrunad.TabIndex = 34;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(125, 133);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Properties.Appearance.Options.UseFont = true;
            this.txtTutar.Size = new System.Drawing.Size(160, 28);
            this.txtTutar.TabIndex = 33;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(65, 136);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(54, 22);
            this.labelControl12.TabIndex = 32;
            this.labelControl12.Text = "Tutar :";
            // 
            // txtMıktar
            // 
            this.txtMıktar.Location = new System.Drawing.Point(125, 72);
            this.txtMıktar.Name = "txtMıktar";
            this.txtMıktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMıktar.Properties.Appearance.Options.UseFont = true;
            this.txtMıktar.Size = new System.Drawing.Size(160, 28);
            this.txtMıktar.TabIndex = 30;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(50, 43);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(71, 22);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Ürün Ad:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(59, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 22);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Miktar :";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.Appearance.Options.UseForeColor = true;
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(115, 167);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(152, 43);
            this.BtnGuncelle.TabIndex = 41;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Appearance.Options.UseForeColor = true;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(115, 216);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(152, 43);
            this.BtnSil.TabIndex = 42;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // FrmFaturaUrunDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.groupControl5);
            this.Name = "FrmFaturaUrunDuzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Urun Duzenleme";
            this.Load += new System.EventHandler(this.FrmFaturaUrunDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFıyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURUNID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMıktar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.TextEdit txtFıyat;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtURUNID;
        private DevExpress.XtraEditors.TextEdit txtUrunad;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtMıktar;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
    }
}