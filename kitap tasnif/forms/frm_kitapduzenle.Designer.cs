namespace kitap_tasnif.forms
{
    partial class frm_kitapduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kitapduzenle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbx_yayinevleri = new System.Windows.Forms.ComboBox();
            this.txt_kitapkodu = new DevExpress.XtraEditors.TextEdit();
            this.txt_kitapadi = new DevExpress.XtraEditors.TextEdit();
            this.btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kitapGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_yazarlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitapkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitapadi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cmbx_yayinevleri);
            this.groupControl1.Controls.Add(this.cmbx_yazarlar);
            this.groupControl1.Controls.Add(this.txt_kitapkodu);
            this.groupControl1.Controls.Add(this.txt_kitapadi);
            this.groupControl1.Location = new System.Drawing.Point(12, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(618, 232);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Kitap Düzenle";
            // 
            // cmbx_yayinevleri
            // 
            this.cmbx_yayinevleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_yayinevleri.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cmbx_yayinevleri.FormattingEnabled = true;
            this.cmbx_yayinevleri.Location = new System.Drawing.Point(6, 136);
            this.cmbx_yayinevleri.Name = "cmbx_yayinevleri";
            this.cmbx_yayinevleri.Size = new System.Drawing.Size(370, 36);
            this.cmbx_yayinevleri.TabIndex = 11;
            // 
            // txt_kitapkodu
            // 
            this.txt_kitapkodu.EditValue = "Kitap kodunu girin.";
            this.txt_kitapkodu.Location = new System.Drawing.Point(6, 179);
            this.txt_kitapkodu.Name = "txt_kitapkodu";
            this.txt_kitapkodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txt_kitapkodu.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_kitapkodu.Properties.Appearance.Options.UseFont = true;
            this.txt_kitapkodu.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kitapkodu.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_kitapkodu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_kitapkodu.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_kitapkodu.Properties.ContextImageOptions.Image")));
            this.txt_kitapkodu.Size = new System.Drawing.Size(607, 36);
            this.txt_kitapkodu.TabIndex = 7;
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.EditValue = "Kitap ismini girin.";
            this.txt_kitapadi.Location = new System.Drawing.Point(5, 52);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txt_kitapadi.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_kitapadi.Properties.Appearance.Options.UseFont = true;
            this.txt_kitapadi.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kitapadi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_kitapadi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_kitapadi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_kitapadi.Properties.ContextImageOptions.Image")));
            this.txt_kitapadi.Size = new System.Drawing.Size(607, 36);
            this.txt_kitapadi.TabIndex = 9;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_iptal.Appearance.Options.UseFont = true;
            this.btn_iptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_iptal.ImageOptions.Image")));
            this.btn_iptal.Location = new System.Drawing.Point(435, 249);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(195, 52);
            this.btn_iptal.TabIndex = 8;
            this.btn_iptal.Text = "İptal";
            // 
            // btn_kitapGuncelle
            // 
            this.btn_kitapGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_kitapGuncelle.Appearance.Options.UseFont = true;
            this.btn_kitapGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_kitapGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitapEkle.ImageOptions.Image")));
            this.btn_kitapGuncelle.Location = new System.Drawing.Point(12, 249);
            this.btn_kitapGuncelle.Name = "btn_kitapGuncelle";
            this.btn_kitapGuncelle.Size = new System.Drawing.Size(195, 52);
            this.btn_kitapGuncelle.TabIndex = 7;
            this.btn_kitapGuncelle.Text = "Güncelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(382, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 74);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kitap düzenleme sayfasında\r\nyazar isimleri ve yayınevi isimleri\r\neklemesi yapılam" +
    "az. Sadece \r\ndeğişiklik yapılabilir.";
            // 
            // cmbx_yazarlar
            // 
            this.cmbx_yazarlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_yazarlar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cmbx_yazarlar.FormattingEnabled = true;
            this.cmbx_yazarlar.Location = new System.Drawing.Point(6, 95);
            this.cmbx_yazarlar.Name = "cmbx_yazarlar";
            this.cmbx_yazarlar.Size = new System.Drawing.Size(370, 36);
            this.cmbx_yazarlar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(203, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "--> düzenlenecek_kitap_ismi";
            // 
            // frm_kitapduzenle
            // 
            this.AcceptButton = this.btn_kitapGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_iptal;
            this.ClientSize = new System.Drawing.Size(642, 313);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kitapGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_kitapduzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Tasnif Programı";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitapkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitapadi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_yayinevleri;
        private System.Windows.Forms.ComboBox cmbx_yazarlar;
        private DevExpress.XtraEditors.TextEdit txt_kitapkodu;
        private DevExpress.XtraEditors.TextEdit txt_kitapadi;
        private DevExpress.XtraEditors.SimpleButton btn_iptal;
        private DevExpress.XtraEditors.SimpleButton btn_kitapGuncelle;
        private System.Windows.Forms.Label label2;
    }
}