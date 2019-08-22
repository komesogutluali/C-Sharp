namespace LimonOtomasyon1.Formlar
{
    partial class Sonislemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sonislemler));
            this.pl_header = new System.Windows.Forms.Panel();
            this.pl_aracizgi = new System.Windows.Forms.Panel();
            this.lb_aciklama = new System.Windows.Forms.Label();
            this.pl_main = new System.Windows.Forms.Panel();
            this.lv_sonislemler = new System.Windows.Forms.ListView();
            this.islem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.islem_tarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personel_adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pl_baslik = new System.Windows.Forms.Panel();
            this.lb_baslik = new System.Windows.Forms.Label();
            this.yenile = new System.Windows.Forms.Timer(this.components);
            this.bfb_sonislemlerisil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pl_aracizgi.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.pl_baslik.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.Color.Crimson;
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pl_header.Location = new System.Drawing.Point(0, 0);
            this.pl_header.Name = "pl_header";
            this.pl_header.Padding = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.pl_header.Size = new System.Drawing.Size(862, 114);
            this.pl_header.TabIndex = 2;
            // 
            // pl_aracizgi
            // 
            this.pl_aracizgi.BackColor = System.Drawing.Color.OrangeRed;
            this.pl_aracizgi.Controls.Add(this.lb_aciklama);
            this.pl_aracizgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_aracizgi.Location = new System.Drawing.Point(0, 114);
            this.pl_aracizgi.Name = "pl_aracizgi";
            this.pl_aracizgi.Size = new System.Drawing.Size(862, 35);
            this.pl_aracizgi.TabIndex = 2;
            // 
            // lb_aciklama
            // 
            this.lb_aciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_aciklama.ForeColor = System.Drawing.Color.White;
            this.lb_aciklama.Location = new System.Drawing.Point(0, 0);
            this.lb_aciklama.Name = "lb_aciklama";
            this.lb_aciklama.Size = new System.Drawing.Size(862, 35);
            this.lb_aciklama.TabIndex = 1;
            this.lb_aciklama.Text = "Bu sayfada program üzerinde yapılan son işlemleri görebilirsiniz.";
            this.lb_aciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_main
            // 
            this.pl_main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pl_main.Controls.Add(this.lv_sonislemler);
            this.pl_main.Controls.Add(this.pl_baslik);
            this.pl_main.Controls.Add(this.bfb_sonislemlerisil);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(0, 149);
            this.pl_main.Margin = new System.Windows.Forms.Padding(2);
            this.pl_main.Name = "pl_main";
            this.pl_main.Padding = new System.Windows.Forms.Padding(94, 25, 94, 25);
            this.pl_main.Size = new System.Drawing.Size(862, 485);
            this.pl_main.TabIndex = 3;
            // 
            // lv_sonislemler
            // 
            this.lv_sonislemler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_sonislemler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.islem,
            this.islem_tarihi,
            this.personel_adi});
            this.lv_sonislemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_sonislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lv_sonislemler.FullRowSelect = true;
            this.lv_sonislemler.GridLines = true;
            this.lv_sonislemler.Location = new System.Drawing.Point(94, 67);
            this.lv_sonislemler.Margin = new System.Windows.Forms.Padding(2);
            this.lv_sonislemler.Name = "lv_sonislemler";
            this.lv_sonislemler.Size = new System.Drawing.Size(674, 345);
            this.lv_sonislemler.TabIndex = 0;
            this.lv_sonislemler.UseCompatibleStateImageBehavior = false;
            this.lv_sonislemler.View = System.Windows.Forms.View.Details;
            // 
            // islem
            // 
            this.islem.Text = "İşlem";
            this.islem.Width = 299;
            // 
            // islem_tarihi
            // 
            this.islem_tarihi.Text = "İşlem Tarihi";
            this.islem_tarihi.Width = 299;
            // 
            // personel_adi
            // 
            this.personel_adi.Text = "Personel Adı";
            this.personel_adi.Width = 299;
            // 
            // pl_baslik
            // 
            this.pl_baslik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pl_baslik.Controls.Add(this.lb_baslik);
            this.pl_baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_baslik.ForeColor = System.Drawing.Color.Coral;
            this.pl_baslik.Location = new System.Drawing.Point(94, 25);
            this.pl_baslik.Margin = new System.Windows.Forms.Padding(2);
            this.pl_baslik.Name = "pl_baslik";
            this.pl_baslik.Size = new System.Drawing.Size(674, 42);
            this.pl_baslik.TabIndex = 1;
            // 
            // lb_baslik
            // 
            this.lb_baslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_baslik.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_baslik.Location = new System.Drawing.Point(0, 0);
            this.lb_baslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_baslik.Name = "lb_baslik";
            this.lb_baslik.Size = new System.Drawing.Size(674, 42);
            this.lb_baslik.TabIndex = 0;
            this.lb_baslik.Text = "Son İşlemler";
            this.lb_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yenile
            // 
            this.yenile.Enabled = true;
            this.yenile.Interval = 10;
            this.yenile.Tick += new System.EventHandler(this.yenile_Tick);
            // 
            // bfb_sonislemlerisil
            // 
            this.bfb_sonislemlerisil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_sonislemlerisil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_sonislemlerisil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_sonislemlerisil.BorderRadius = 0;
            this.bfb_sonislemlerisil.ButtonText = "Son İşlemleri Sil";
            this.bfb_sonislemlerisil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfb_sonislemlerisil.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_sonislemlerisil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bfb_sonislemlerisil.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_sonislemlerisil.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_sonislemlerisil.Iconimage")));
            this.bfb_sonislemlerisil.Iconimage_right = null;
            this.bfb_sonislemlerisil.Iconimage_right_Selected = null;
            this.bfb_sonislemlerisil.Iconimage_Selected = null;
            this.bfb_sonislemlerisil.IconMarginLeft = 0;
            this.bfb_sonislemlerisil.IconMarginRight = 0;
            this.bfb_sonislemlerisil.IconRightVisible = true;
            this.bfb_sonislemlerisil.IconRightZoom = 0D;
            this.bfb_sonislemlerisil.IconVisible = false;
            this.bfb_sonislemlerisil.IconZoom = 90D;
            this.bfb_sonislemlerisil.IsTab = false;
            this.bfb_sonislemlerisil.Location = new System.Drawing.Point(94, 412);
            this.bfb_sonislemlerisil.Margin = new System.Windows.Forms.Padding(0);
            this.bfb_sonislemlerisil.Name = "bfb_sonislemlerisil";
            this.bfb_sonislemlerisil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_sonislemlerisil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfb_sonislemlerisil.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_sonislemlerisil.selected = false;
            this.bfb_sonislemlerisil.Size = new System.Drawing.Size(674, 48);
            this.bfb_sonislemlerisil.TabIndex = 2;
            this.bfb_sonislemlerisil.Text = "Son İşlemleri Sil";
            this.bfb_sonislemlerisil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfb_sonislemlerisil.Textcolor = System.Drawing.Color.White;
            this.bfb_sonislemlerisil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_sonislemlerisil.Click += new System.EventHandler(this.bfb_sonislemlerisil_Click);
            // 
            // Sonislemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 634);
            this.Controls.Add(this.pl_main);
            this.Controls.Add(this.pl_aracizgi);
            this.Controls.Add(this.pl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sonislemler";
            this.Text = "Sonislemler";
            this.SizeChanged += new System.EventHandler(this.Sonislemler_SizeChanged);
            this.pl_aracizgi.ResumeLayout(false);
            this.pl_main.ResumeLayout(false);
            this.pl_baslik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Panel pl_aracizgi;
        private System.Windows.Forms.Label lb_aciklama;
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.ListView lv_sonislemler;
        private System.Windows.Forms.ColumnHeader islem;
        private System.Windows.Forms.ColumnHeader islem_tarihi;
        private System.Windows.Forms.ColumnHeader personel_adi;
        private System.Windows.Forms.Panel pl_baslik;
        private System.Windows.Forms.Label lb_baslik;
        private System.Windows.Forms.Timer yenile;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_sonislemlerisil;
    }
}