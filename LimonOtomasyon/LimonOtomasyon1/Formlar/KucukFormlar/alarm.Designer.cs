namespace LimonOtomasyon1.Formlar.KucukFormlar
{
    partial class alarm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alarm));
            this.icon = new System.Windows.Forms.PictureBox();
            this.pl_mesaj = new System.Windows.Forms.Panel();
            this.lb_metin = new System.Windows.Forms.Label();
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            this.elips = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.icon_list = new System.Windows.Forms.ImageList(this.components);
            this.frm_kapat = new System.Windows.Forms.Timer(this.components);
            this.frm_ac = new System.Windows.Forms.Timer(this.components);
            this.frm_cikis = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.pl_mesaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(0, 11);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(100, 71);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // pl_mesaj
            // 
            this.pl_mesaj.Controls.Add(this.lb_metin);
            this.pl_mesaj.Location = new System.Drawing.Point(116, 10);
            this.pl_mesaj.Name = "pl_mesaj";
            this.pl_mesaj.Size = new System.Drawing.Size(287, 71);
            this.pl_mesaj.TabIndex = 1;
            // 
            // lb_metin
            // 
            this.lb_metin.BackColor = System.Drawing.Color.Transparent;
            this.lb_metin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_metin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_metin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_metin.Location = new System.Drawing.Point(0, 0);
            this.lb_metin.Name = "lb_metin";
            this.lb_metin.Size = new System.Drawing.Size(287, 71);
            this.lb_metin.TabIndex = 0;
            this.lb_metin.Text = "Şifreniz başarı ile değiştirildi.Hemen giriş yaparak kaldığınız yerden devam edeb" +
    "ilirsiniz.";
            this.lb_metin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageActive = null;
            this.btn_kapat.Location = new System.Drawing.Point(406, 5);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(32, 26);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_kapat.TabIndex = 1;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // elips
            // 
            this.elips.ElipseRadius = 5;
            this.elips.TargetControl = this;
            // 
            // icon_list
            // 
            this.icon_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon_list.ImageStream")));
            this.icon_list.TransparentColor = System.Drawing.Color.Transparent;
            this.icon_list.Images.SetKeyName(0, "basarili.png");
            this.icon_list.Images.SetKeyName(1, "error.png");
            this.icon_list.Images.SetKeyName(2, "dikkat.png");
            this.icon_list.Images.SetKeyName(3, "eposta.png");
            // 
            // frm_kapat
            // 
            this.frm_kapat.Enabled = true;
            this.frm_kapat.Interval = 5000;
            this.frm_kapat.Tick += new System.EventHandler(this.frm_kapat_Tick);
            // 
            // frm_ac
            // 
            this.frm_ac.Enabled = true;
            this.frm_ac.Tick += new System.EventHandler(this.frm_ac_Tick);
            // 
            // frm_cikis
            // 
            this.frm_cikis.Tick += new System.EventHandler(this.frm_cikis_Tick);
            // 
            // alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(443, 93);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.pl_mesaj);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alarm";
            this.Opacity = 0.95D;
            this.Text = "alarm";
            this.Load += new System.EventHandler(this.alarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.pl_mesaj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel pl_mesaj;
        private System.Windows.Forms.Label lb_metin;
        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
        private Bunifu.Framework.UI.BunifuElipse elips;
        private System.Windows.Forms.ImageList icon_list;
        private System.Windows.Forms.Timer frm_kapat;
        private System.Windows.Forms.Timer frm_ac;
        private System.Windows.Forms.Timer frm_cikis;
    }
}