namespace LimonOtomasyon1.Formlar.KucukFormlar
{
    partial class personel_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel_giris));
            this.pl_text = new System.Windows.Forms.Panel();
            this.lb_text = new System.Windows.Forms.Label();
            this.btn_girisyap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bmt_sifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_yoneticigirisi = new System.Windows.Forms.Label();
            this.lb_hak = new System.Windows.Forms.Label();
            this.pl_yonetici = new System.Windows.Forms.Panel();
            this.bmt_personelkapa = new Bunifu.Framework.UI.BunifuImageButton();
            this.pl_uyari = new System.Windows.Forms.Panel();
            this.lb_yuyari = new System.Windows.Forms.Label();
            this.bfb_pgirisyap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bmt_yoneticisifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bmt_eposta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bmt_panelkapa = new Bunifu.Framework.UI.BunifuImageButton();
            this.pl_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.pl_yonetici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmt_personelkapa)).BeginInit();
            this.pl_uyari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmt_panelkapa)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_text
            // 
            this.pl_text.Controls.Add(this.lb_text);
            this.pl_text.Location = new System.Drawing.Point(57, 22);
            this.pl_text.Name = "pl_text";
            this.pl_text.Size = new System.Drawing.Size(371, 59);
            this.pl_text.TabIndex = 0;
            // 
            // lb_text
            // 
            this.lb_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_text.Location = new System.Drawing.Point(0, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(371, 59);
            this.lb_text.TabIndex = 0;
            this.lb_text.Text = "Lütfen işlem yapabilmek için öncelikle size verilen Personel şifrenizi giriniz.";
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Activecolor = System.Drawing.Color.DarkBlue;
            this.btn_girisyap.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_girisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_girisyap.BorderRadius = 0;
            this.btn_girisyap.ButtonText = "Giriş Yap";
            this.btn_girisyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_girisyap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_girisyap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_girisyap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_girisyap.Iconimage")));
            this.btn_girisyap.Iconimage_right = null;
            this.btn_girisyap.Iconimage_right_Selected = null;
            this.btn_girisyap.Iconimage_Selected = null;
            this.btn_girisyap.IconMarginLeft = 0;
            this.btn_girisyap.IconMarginRight = 0;
            this.btn_girisyap.IconRightVisible = true;
            this.btn_girisyap.IconRightZoom = 0D;
            this.btn_girisyap.IconVisible = true;
            this.btn_girisyap.IconZoom = 90D;
            this.btn_girisyap.IsTab = false;
            this.btn_girisyap.Location = new System.Drawing.Point(99, 161);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Normalcolor = System.Drawing.Color.OrangeRed;
            this.btn_girisyap.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btn_girisyap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_girisyap.selected = false;
            this.btn_girisyap.Size = new System.Drawing.Size(315, 48);
            this.btn_girisyap.TabIndex = 1;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_girisyap.Textcolor = System.Drawing.Color.White;
            this.btn_girisyap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // bmt_sifre
            // 
            this.bmt_sifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmt_sifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_sifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmt_sifre.BorderThickness = 3;
            this.bmt_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_sifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_sifre.isPassword = false;
            this.bmt_sifre.Location = new System.Drawing.Point(99, 97);
            this.bmt_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_sifre.Name = "bmt_sifre";
            this.bmt_sifre.Size = new System.Drawing.Size(315, 44);
            this.bmt_sifre.TabIndex = 2;
            this.bmt_sifre.Text = "Personel Şifreniz";
            this.bmt_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_sifre.Enter += new System.EventHandler(this.bmt_sifre_Enter);
            this.bmt_sifre.Leave += new System.EventHandler(this.bmt_sifre_Leave);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageActive = null;
            this.btn_kapat.Location = new System.Drawing.Point(456, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(26, 24);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_kapat.TabIndex = 3;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lb_yoneticigirisi
            // 
            this.lb_yoneticigirisi.AutoSize = true;
            this.lb_yoneticigirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_yoneticigirisi.Location = new System.Drawing.Point(350, 223);
            this.lb_yoneticigirisi.Name = "lb_yoneticigirisi";
            this.lb_yoneticigirisi.Size = new System.Drawing.Size(123, 17);
            this.lb_yoneticigirisi.TabIndex = 4;
            this.lb_yoneticigirisi.Text = "Yönetici Girişi Yap";
            this.lb_yoneticigirisi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_yoneticigirisi_MouseClick);
            // 
            // lb_hak
            // 
            this.lb_hak.AutoSize = true;
            this.lb_hak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_hak.Location = new System.Drawing.Point(12, 222);
            this.lb_hak.Name = "lb_hak";
            this.lb_hak.Size = new System.Drawing.Size(108, 17);
            this.lb_hak.TabIndex = 5;
            this.lb_hak.Text = "5 Hakkınız Kaldı";
            // 
            // pl_yonetici
            // 
            this.pl_yonetici.BackColor = System.Drawing.Color.Crimson;
            this.pl_yonetici.Controls.Add(this.bmt_personelkapa);
            this.pl_yonetici.Controls.Add(this.pl_uyari);
            this.pl_yonetici.Controls.Add(this.bfb_pgirisyap);
            this.pl_yonetici.Controls.Add(this.bmt_yoneticisifre);
            this.pl_yonetici.Controls.Add(this.bmt_eposta);
            this.pl_yonetici.Controls.Add(this.bmt_panelkapa);
            this.pl_yonetici.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_yonetici.Location = new System.Drawing.Point(0, 266);
            this.pl_yonetici.Name = "pl_yonetici";
            this.pl_yonetici.Size = new System.Drawing.Size(484, 27);
            this.pl_yonetici.TabIndex = 6;
            this.pl_yonetici.Visible = false;
            // 
            // bmt_personelkapa
            // 
            this.bmt_personelkapa.BackColor = System.Drawing.Color.Transparent;
            this.bmt_personelkapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmt_personelkapa.Image = ((System.Drawing.Image)(resources.GetObject("bmt_personelkapa.Image")));
            this.bmt_personelkapa.ImageActive = null;
            this.bmt_personelkapa.Location = new System.Drawing.Point(453, 3);
            this.bmt_personelkapa.Name = "bmt_personelkapa";
            this.bmt_personelkapa.Size = new System.Drawing.Size(26, 24);
            this.bmt_personelkapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bmt_personelkapa.TabIndex = 9;
            this.bmt_personelkapa.TabStop = false;
            this.bmt_personelkapa.Zoom = 10;
            this.bmt_personelkapa.Click += new System.EventHandler(this.bmt_personelkapa_Click);
            // 
            // pl_uyari
            // 
            this.pl_uyari.Controls.Add(this.lb_yuyari);
            this.pl_uyari.Location = new System.Drawing.Point(57, 193);
            this.pl_uyari.Name = "pl_uyari";
            this.pl_uyari.Size = new System.Drawing.Size(370, 35);
            this.pl_uyari.TabIndex = 8;
            // 
            // lb_yuyari
            // 
            this.lb_yuyari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_yuyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_yuyari.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_yuyari.Location = new System.Drawing.Point(0, 0);
            this.lb_yuyari.Name = "lb_yuyari";
            this.lb_yuyari.Size = new System.Drawing.Size(370, 35);
            this.lb_yuyari.TabIndex = 0;
            this.lb_yuyari.Text = "5 Hakkınız Kaldı";
            this.lb_yuyari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bfb_pgirisyap
            // 
            this.bfb_pgirisyap.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.bfb_pgirisyap.BackColor = System.Drawing.Color.DarkOrange;
            this.bfb_pgirisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_pgirisyap.BorderRadius = 0;
            this.bfb_pgirisyap.ButtonText = "Giriş Yap";
            this.bfb_pgirisyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfb_pgirisyap.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_pgirisyap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bfb_pgirisyap.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_pgirisyap.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_pgirisyap.Iconimage")));
            this.bfb_pgirisyap.Iconimage_right = null;
            this.bfb_pgirisyap.Iconimage_right_Selected = null;
            this.bfb_pgirisyap.Iconimage_Selected = null;
            this.bfb_pgirisyap.IconMarginLeft = 0;
            this.bfb_pgirisyap.IconMarginRight = 0;
            this.bfb_pgirisyap.IconRightVisible = false;
            this.bfb_pgirisyap.IconRightZoom = 0D;
            this.bfb_pgirisyap.IconVisible = false;
            this.bfb_pgirisyap.IconZoom = 100D;
            this.bfb_pgirisyap.IsTab = false;
            this.bfb_pgirisyap.Location = new System.Drawing.Point(57, 138);
            this.bfb_pgirisyap.Name = "bfb_pgirisyap";
            this.bfb_pgirisyap.Normalcolor = System.Drawing.Color.DarkOrange;
            this.bfb_pgirisyap.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.bfb_pgirisyap.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_pgirisyap.selected = false;
            this.bfb_pgirisyap.Size = new System.Drawing.Size(370, 48);
            this.bfb_pgirisyap.TabIndex = 7;
            this.bfb_pgirisyap.Text = "Giriş Yap";
            this.bfb_pgirisyap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfb_pgirisyap.Textcolor = System.Drawing.Color.White;
            this.bfb_pgirisyap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_pgirisyap.Click += new System.EventHandler(this.bfb_pgirisyap_Click);
            // 
            // bmt_yoneticisifre
            // 
            this.bmt_yoneticisifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmt_yoneticisifre.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.bmt_yoneticisifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmt_yoneticisifre.BorderThickness = 3;
            this.bmt_yoneticisifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_yoneticisifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_yoneticisifre.ForeColor = System.Drawing.Color.White;
            this.bmt_yoneticisifre.isPassword = false;
            this.bmt_yoneticisifre.Location = new System.Drawing.Point(57, 86);
            this.bmt_yoneticisifre.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_yoneticisifre.Name = "bmt_yoneticisifre";
            this.bmt_yoneticisifre.Size = new System.Drawing.Size(370, 44);
            this.bmt_yoneticisifre.TabIndex = 6;
            this.bmt_yoneticisifre.Text = "Şifreniz";
            this.bmt_yoneticisifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_yoneticisifre.Enter += new System.EventHandler(this.bmt_sifre_Enter);
            this.bmt_yoneticisifre.Leave += new System.EventHandler(this.bmt_sifre_Leave);
            // 
            // bmt_eposta
            // 
            this.bmt_eposta.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmt_eposta.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.bmt_eposta.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmt_eposta.BorderThickness = 3;
            this.bmt_eposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_eposta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_eposta.ForeColor = System.Drawing.Color.White;
            this.bmt_eposta.isPassword = false;
            this.bmt_eposta.Location = new System.Drawing.Point(57, 26);
            this.bmt_eposta.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_eposta.Name = "bmt_eposta";
            this.bmt_eposta.Size = new System.Drawing.Size(370, 44);
            this.bmt_eposta.TabIndex = 5;
            this.bmt_eposta.Text = "E-posta Adresiniz";
            this.bmt_eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_eposta.Enter += new System.EventHandler(this.bmt_sifre_Enter);
            this.bmt_eposta.Leave += new System.EventHandler(this.bmt_sifre_Leave);
            // 
            // bmt_panelkapa
            // 
            this.bmt_panelkapa.BackColor = System.Drawing.Color.Transparent;
            this.bmt_panelkapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmt_panelkapa.Image = ((System.Drawing.Image)(resources.GetObject("bmt_panelkapa.Image")));
            this.bmt_panelkapa.ImageActive = null;
            this.bmt_panelkapa.Location = new System.Drawing.Point(451, 220);
            this.bmt_panelkapa.Name = "bmt_panelkapa";
            this.bmt_panelkapa.Size = new System.Drawing.Size(26, 24);
            this.bmt_panelkapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bmt_panelkapa.TabIndex = 4;
            this.bmt_panelkapa.TabStop = false;
            this.bmt_panelkapa.Zoom = 10;
            this.bmt_panelkapa.Click += new System.EventHandler(this.btm_panelkapa_Click);
            // 
            // personel_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 293);
            this.Controls.Add(this.pl_yonetici);
            this.Controls.Add(this.lb_hak);
            this.Controls.Add(this.lb_yoneticigirisi);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.bmt_sifre);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.pl_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "personel_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personel_giris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.personel_giris_KeyDown);
            this.pl_text.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.pl_yonetici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bmt_personelkapa)).EndInit();
            this.pl_uyari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bmt_panelkapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_text;
        private Bunifu.Framework.UI.BunifuFlatButton btn_girisyap;
        private System.Windows.Forms.Label lb_text;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmt_sifre;
        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
        private System.Windows.Forms.Label lb_yoneticigirisi;
        private System.Windows.Forms.Label lb_hak;
        private System.Windows.Forms.Panel pl_yonetici;
        private Bunifu.Framework.UI.BunifuImageButton bmt_panelkapa;
        private System.Windows.Forms.Panel pl_uyari;
        private System.Windows.Forms.Label lb_yuyari;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_pgirisyap;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmt_yoneticisifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmt_eposta;
        private Bunifu.Framework.UI.BunifuImageButton bmt_personelkapa;
    }
}