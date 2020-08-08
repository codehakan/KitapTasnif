namespace kitap_tasnif.newforms
{
    partial class frm_yazarekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_yazarekle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_yazaradi = new DevExpress.XtraEditors.TextEdit();
            this.btn_yazarekle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yazaradi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.txt_yazaradi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(552, 103);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Yazar adını girin";
            // 
            // txt_yazaradi
            // 
            this.txt_yazaradi.Location = new System.Drawing.Point(5, 52);
            this.txt_yazaradi.Name = "txt_yazaradi";
            this.txt_yazaradi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txt_yazaradi.Properties.Appearance.Options.UseFont = true;
            this.txt_yazaradi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_yazaradi.Properties.ContextImageOptions.Image")));
            this.txt_yazaradi.Size = new System.Drawing.Size(542, 36);
            this.txt_yazaradi.TabIndex = 0;
            // 
            // btn_yazarekle
            // 
            this.btn_yazarekle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_yazarekle.Appearance.Options.UseFont = true;
            this.btn_yazarekle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_yazarekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_yazarekle.ImageOptions.Image")));
            this.btn_yazarekle.Location = new System.Drawing.Point(12, 121);
            this.btn_yazarekle.Name = "btn_yazarekle";
            this.btn_yazarekle.Size = new System.Drawing.Size(195, 52);
            this.btn_yazarekle.TabIndex = 1;
            this.btn_yazarekle.Text = "Ekle";
            this.btn_yazarekle.Click += new System.EventHandler(this.btn_yazarekle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_iptal.Appearance.Options.UseFont = true;
            this.btn_iptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_iptal.ImageOptions.Image")));
            this.btn_iptal.Location = new System.Drawing.Point(369, 121);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(195, 52);
            this.btn_iptal.TabIndex = 2;
            this.btn_iptal.Text = "İptal";
            // 
            // frm_yazarekle
            // 
            this.AcceptButton = this.btn_yazarekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_iptal;
            this.ClientSize = new System.Drawing.Size(573, 185);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_yazarekle);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_yazarekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Tasnif Programı";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_yazaradi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_yazaradi;
        private DevExpress.XtraEditors.SimpleButton btn_yazarekle;
        private DevExpress.XtraEditors.SimpleButton btn_iptal;
    }
}