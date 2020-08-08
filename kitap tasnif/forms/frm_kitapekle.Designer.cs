namespace kitap_tasnif.newforms
{
    partial class frm_kitapekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kitapekle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbx_yayinevleri = new System.Windows.Forms.ComboBox();
            this.cmbx_yazarlar = new System.Windows.Forms.ComboBox();
            this.txt_kitapkodu = new DevExpress.XtraEditors.TextEdit();
            this.check_yayineviekle = new System.Windows.Forms.CheckBox();
            this.txt_yayineviadi = new DevExpress.XtraEditors.TextEdit();
            this.check_yazarekle = new System.Windows.Forms.CheckBox();
            this.txt_yazaradi = new DevExpress.XtraEditors.TextEdit();
            this.txt_kitapadi = new DevExpress.XtraEditors.TextEdit();
            this.btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kitapEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitapkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yayineviadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yazaradi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitapadi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.cmbx_yayinevleri);
            this.groupControl1.Controls.Add(this.cmbx_yazarlar);
            this.groupControl1.Controls.Add(this.txt_kitapkodu);
            this.groupControl1.Controls.Add(this.check_yayineviekle);
            this.groupControl1.Controls.Add(this.txt_yayineviadi);
            this.groupControl1.Controls.Add(this.check_yazarekle);
            this.groupControl1.Controls.Add(this.txt_yazaradi);
            this.groupControl1.Controls.Add(this.txt_kitapadi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(618, 232);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Kitap Ekle";
            // 
            // cmbx_yayinevleri
            // 
            this.cmbx_yayinevleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_yayinevleri.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cmbx_yayinevleri.FormattingEnabled = true;
            this.cmbx_yayinevleri.IntegralHeight = false;
            this.cmbx_yayinevleri.Location = new System.Drawing.Point(6, 136);
            this.cmbx_yayinevleri.Name = "cmbx_yayinevleri";
            this.cmbx_yayinevleri.Size = new System.Drawing.Size(376, 36);
            this.cmbx_yayinevleri.TabIndex = 11;
            // 
            // cmbx_yazarlar
            // 
            this.cmbx_yazarlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_yazarlar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cmbx_yazarlar.FormattingEnabled = true;
            this.cmbx_yazarlar.IntegralHeight = false;
            this.cmbx_yazarlar.Location = new System.Drawing.Point(6, 95);
            this.cmbx_yazarlar.Name = "cmbx_yazarlar";
            this.cmbx_yazarlar.Size = new System.Drawing.Size(376, 36);
            this.cmbx_yazarlar.TabIndex = 10;
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
            this.txt_kitapkodu.Enter += new System.EventHandler(this.txt_kitapkodu_Enter);
            this.txt_kitapkodu.Leave += new System.EventHandler(this.txt_kitapkodu_Leave);
            // 
            // check_yayineviekle
            // 
            this.check_yayineviekle.AutoSize = true;
            this.check_yayineviekle.Font = new System.Drawing.Font("Tahoma", 14F);
            this.check_yayineviekle.Location = new System.Drawing.Point(387, 137);
            this.check_yayineviekle.Name = "check_yayineviekle";
            this.check_yayineviekle.Size = new System.Drawing.Size(226, 33);
            this.check_yayineviekle.TabIndex = 5;
            this.check_yayineviekle.Text = "Yeni Yayınevi Ekle";
            this.check_yayineviekle.UseVisualStyleBackColor = true;
            this.check_yayineviekle.CheckedChanged += new System.EventHandler(this.check_yayineviekle_CheckedChanged);
            // 
            // txt_yayineviadi
            // 
            this.txt_yayineviadi.EditValue = "Yayınevi ismini girin.";
            this.txt_yayineviadi.Location = new System.Drawing.Point(5, 134);
            this.txt_yayineviadi.Name = "txt_yayineviadi";
            this.txt_yayineviadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txt_yayineviadi.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_yayineviadi.Properties.Appearance.Options.UseFont = true;
            this.txt_yayineviadi.Properties.Appearance.Options.UseForeColor = true;
            this.txt_yayineviadi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_yayineviadi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_yayineviadi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_yayineviadi.Properties.ContextImageOptions.Image")));
            this.txt_yayineviadi.Size = new System.Drawing.Size(376, 36);
            this.txt_yayineviadi.TabIndex = 4;
            this.txt_yayineviadi.Visible = false;
            this.txt_yayineviadi.Enter += new System.EventHandler(this.txt_yayineviadi_Enter);
            this.txt_yayineviadi.Leave += new System.EventHandler(this.txt_yayineviadi_Leave);
            // 
            // check_yazarekle
            // 
            this.check_yazarekle.AutoSize = true;
            this.check_yazarekle.Font = new System.Drawing.Font("Tahoma", 14F);
            this.check_yazarekle.Location = new System.Drawing.Point(387, 97);
            this.check_yazarekle.Name = "check_yazarekle";
            this.check_yazarekle.Size = new System.Drawing.Size(199, 33);
            this.check_yazarekle.TabIndex = 2;
            this.check_yazarekle.Text = "Yeni Yazar Ekle";
            this.check_yazarekle.UseVisualStyleBackColor = true;
            this.check_yazarekle.CheckedChanged += new System.EventHandler(this.check_yazarekle_CheckedChanged);
            // 
            // txt_yazaradi
            // 
            this.txt_yazaradi.EditValue = "Yazar ismini girin.";
            this.txt_yazaradi.Location = new System.Drawing.Point(5, 94);
            this.txt_yazaradi.Name = "txt_yazaradi";
            this.txt_yazaradi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txt_yazaradi.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_yazaradi.Properties.Appearance.Options.UseFont = true;
            this.txt_yazaradi.Properties.Appearance.Options.UseForeColor = true;
            this.txt_yazaradi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_yazaradi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_yazaradi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_yazaradi.Properties.ContextImageOptions.Image")));
            this.txt_yazaradi.Size = new System.Drawing.Size(376, 36);
            this.txt_yazaradi.TabIndex = 1;
            this.txt_yazaradi.Visible = false;
            this.txt_yazaradi.Enter += new System.EventHandler(this.txt_yazaradi_Enter);
            this.txt_yazaradi.Leave += new System.EventHandler(this.txt_yazaradi_Leave);
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
            this.txt_kitapadi.Enter += new System.EventHandler(this.txt_kitapadi_Enter);
            this.txt_kitapadi.Leave += new System.EventHandler(this.txt_kitapadi_Leave);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_iptal.Appearance.Options.UseFont = true;
            this.btn_iptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_iptal.ImageOptions.Image")));
            this.btn_iptal.Location = new System.Drawing.Point(435, 250);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(195, 52);
            this.btn_iptal.TabIndex = 5;
            this.btn_iptal.Text = "İptal";
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_kitapEkle.Appearance.Options.UseFont = true;
            this.btn_kitapEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_kitapEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitapEkle.ImageOptions.Image")));
            this.btn_kitapEkle.Location = new System.Drawing.Point(12, 250);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(195, 52);
            this.btn_kitapEkle.TabIndex = 4;
            this.btn_kitapEkle.Text = "Ekle";
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_yazarekle_Click);
            // 
            // frm_kitapekle
            // 
            this.AcceptButton = this.btn_kitapEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_iptal;
            this.ClientSize = new System.Drawing.Size(642, 313);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kitapEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_kitapekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Tasnif Programı";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitapkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yayineviadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yazaradi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitapadi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_kitapadi;
        private DevExpress.XtraEditors.SimpleButton btn_iptal;
        private DevExpress.XtraEditors.SimpleButton btn_kitapEkle;
        private DevExpress.XtraEditors.TextEdit txt_yazaradi;
        private DevExpress.XtraEditors.TextEdit txt_kitapkodu;
        private System.Windows.Forms.CheckBox check_yayineviekle;
        private DevExpress.XtraEditors.TextEdit txt_yayineviadi;
        private System.Windows.Forms.CheckBox check_yazarekle;
        private System.Windows.Forms.ComboBox cmbx_yayinevleri;
        private System.Windows.Forms.ComboBox cmbx_yazarlar;
    }
}