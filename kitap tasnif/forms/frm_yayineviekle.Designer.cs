namespace kitap_tasnif.newforms
{
    partial class frm_yayineviekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_yayineviekle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_yayineviadi = new DevExpress.XtraEditors.TextEdit();
            this.btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.btn_yayineviekle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yayineviadi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.txt_yayineviadi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(552, 103);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Yayınevi adını girin";
            // 
            // txt_yayineviadi
            // 
            this.txt_yayineviadi.Location = new System.Drawing.Point(5, 52);
            this.txt_yayineviadi.Name = "txt_yayineviadi";
            this.txt_yayineviadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txt_yayineviadi.Properties.Appearance.Options.UseFont = true;
            this.txt_yayineviadi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_yayineviadi.Properties.ContextImageOptions.Image")));
            this.txt_yayineviadi.Size = new System.Drawing.Size(542, 36);
            this.txt_yayineviadi.TabIndex = 0;
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
            this.btn_iptal.TabIndex = 5;
            this.btn_iptal.Text = "İptal";
            // 
            // btn_yayineviekle
            // 
            this.btn_yayineviekle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_yayineviekle.Appearance.Options.UseFont = true;
            this.btn_yayineviekle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_yayineviekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_yazarekle.ImageOptions.Image")));
            this.btn_yayineviekle.Location = new System.Drawing.Point(12, 121);
            this.btn_yayineviekle.Name = "btn_yayineviekle";
            this.btn_yayineviekle.Size = new System.Drawing.Size(195, 52);
            this.btn_yayineviekle.TabIndex = 4;
            this.btn_yayineviekle.Text = "Ekle";
            this.btn_yayineviekle.Click += new System.EventHandler(this.btn_yayineviekle_Click);
            // 
            // frm_yayineviekle
            // 
            this.AcceptButton = this.btn_yayineviekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_iptal;
            this.ClientSize = new System.Drawing.Size(573, 185);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_yayineviekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_yayineviekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Tasnif Programı";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_yayineviadi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_yayineviadi;
        private DevExpress.XtraEditors.SimpleButton btn_iptal;
        private DevExpress.XtraEditors.SimpleButton btn_yayineviekle;
    }
}