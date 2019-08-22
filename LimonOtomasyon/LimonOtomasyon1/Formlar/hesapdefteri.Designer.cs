namespace LimonOtomasyon1.Formlar
{
    partial class hesapdefteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesapdefteri));
            this.pl_footer = new System.Windows.Forms.Panel();
            this.flp_footerbutonlar = new System.Windows.Forms.Panel();
            this.tlp_butonheader = new System.Windows.Forms.TableLayoutPanel();
            this.tb_tutar = new System.Windows.Forms.TextBox();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.btn_urunekle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_harcamaturu = new System.Windows.Forms.ComboBox();
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.pl_main = new System.Windows.Forms.Panel();
            this.pl_mainorta = new System.Windows.Forms.Panel();
            this.lv_kasa = new System.Windows.Forms.ListView();
            this.k_aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori_adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.k_tur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.k_eklenmetarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.k_odemetarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.k_tutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.k_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.harcama_sil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pl_lvbaslik = new System.Windows.Forms.Panel();
            this.btn_kategoriekle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_baslik = new System.Windows.Forms.Label();
            this.pl_header = new System.Windows.Forms.Panel();
            this.lb_tutar = new System.Windows.Forms.Label();
            this.pl_aracizgi = new System.Windows.Forms.Panel();
            this.lb_aciklama = new System.Windows.Forms.Label();
            this.pl_kategoriekle = new System.Windows.Forms.Panel();
            this.tlb_kategoriler = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lv_kategoriler = new System.Windows.Forms.ListView();
            this.kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_kategoriekle = new System.Windows.Forms.TextBox();
            this.pl_footer.SuspendLayout();
            this.flp_footerbutonlar.SuspendLayout();
            this.tlp_butonheader.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.pl_mainorta.SuspendLayout();
            this.harcama_sil.SuspendLayout();
            this.pl_lvbaslik.SuspendLayout();
            this.pl_header.SuspendLayout();
            this.pl_aracizgi.SuspendLayout();
            this.pl_kategoriekle.SuspendLayout();
            this.tlb_kategoriler.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_footer
            // 
            this.pl_footer.BackColor = System.Drawing.Color.Transparent;
            this.pl_footer.Controls.Add(this.flp_footerbutonlar);
            this.pl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_footer.Location = new System.Drawing.Point(0, 509);
            this.pl_footer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pl_footer.Name = "pl_footer";
            this.pl_footer.Padding = new System.Windows.Forms.Padding(52, 5, 52, 5);
            this.pl_footer.Size = new System.Drawing.Size(862, 125);
            this.pl_footer.TabIndex = 1;
            // 
            // flp_footerbutonlar
            // 
            this.flp_footerbutonlar.Controls.Add(this.tlp_butonheader);
            this.flp_footerbutonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_footerbutonlar.Location = new System.Drawing.Point(52, 5);
            this.flp_footerbutonlar.Margin = new System.Windows.Forms.Padding(0);
            this.flp_footerbutonlar.Name = "flp_footerbutonlar";
            this.flp_footerbutonlar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flp_footerbutonlar.Size = new System.Drawing.Size(758, 115);
            this.flp_footerbutonlar.TabIndex = 1;
            // 
            // tlp_butonheader
            // 
            this.tlp_butonheader.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_butonheader.ColumnCount = 3;
            this.tlp_butonheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_butonheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_butonheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_butonheader.Controls.Add(this.tb_tutar, 1, 0);
            this.tlp_butonheader.Controls.Add(this.cb_kategori, 0, 1);
            this.tlp_butonheader.Controls.Add(this.btn_urunekle, 2, 1);
            this.tlp_butonheader.Controls.Add(this.cb_harcamaturu, 2, 0);
            this.tlp_butonheader.Controls.Add(this.dt_tarih, 0, 1);
            this.tlp_butonheader.Controls.Add(this.tb_aciklama, 0, 0);
            this.tlp_butonheader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_butonheader.Location = new System.Drawing.Point(0, 10);
            this.tlp_butonheader.Name = "tlp_butonheader";
            this.tlp_butonheader.RowCount = 2;
            this.tlp_butonheader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_butonheader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_butonheader.Size = new System.Drawing.Size(758, 105);
            this.tlp_butonheader.TabIndex = 0;
            // 
            // tb_tutar
            // 
            this.tb_tutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_tutar.Location = new System.Drawing.Point(252, 0);
            this.tb_tutar.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.tb_tutar.Name = "tb_tutar";
            this.tb_tutar.Size = new System.Drawing.Size(241, 38);
            this.tb_tutar.TabIndex = 25;
            this.tb_tutar.Text = "Tutar";
            this.tb_tutar.Enter += new System.EventHandler(this.tb_gelirgider_Enter);
            this.tb_tutar.Leave += new System.EventHandler(this.tb_tutar_Leave);
            // 
            // cb_kategori
            // 
            this.cb_kategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(252, 52);
            this.cb_kategori.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(241, 39);
            this.cb_kategori.TabIndex = 21;
            this.cb_kategori.Text = "Kategori Seç";
            // 
            // btn_urunekle
            // 
            this.btn_urunekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_urunekle.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_urunekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_urunekle.BorderRadius = 0;
            this.btn_urunekle.ButtonText = "Ekle";
            this.btn_urunekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_urunekle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_urunekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_urunekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_urunekle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_urunekle.Iconimage")));
            this.btn_urunekle.Iconimage_right = null;
            this.btn_urunekle.Iconimage_right_Selected = null;
            this.btn_urunekle.Iconimage_Selected = null;
            this.btn_urunekle.IconMarginLeft = 0;
            this.btn_urunekle.IconMarginRight = 0;
            this.btn_urunekle.IconRightVisible = true;
            this.btn_urunekle.IconRightZoom = 0D;
            this.btn_urunekle.IconVisible = false;
            this.btn_urunekle.IconZoom = 95D;
            this.btn_urunekle.IsTab = false;
            this.btn_urunekle.Location = new System.Drawing.Point(504, 52);
            this.btn_urunekle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_urunekle.Name = "btn_urunekle";
            this.btn_urunekle.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btn_urunekle.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btn_urunekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_urunekle.selected = false;
            this.btn_urunekle.Size = new System.Drawing.Size(254, 40);
            this.btn_urunekle.TabIndex = 20;
            this.btn_urunekle.Text = "Ekle";
            this.btn_urunekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_urunekle.Textcolor = System.Drawing.Color.White;
            this.btn_urunekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urunekle.Click += new System.EventHandler(this.btn_urunekle_Click);
            // 
            // cb_harcamaturu
            // 
            this.cb_harcamaturu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_harcamaturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_harcamaturu.FormattingEnabled = true;
            this.cb_harcamaturu.Location = new System.Drawing.Point(504, 0);
            this.cb_harcamaturu.Margin = new System.Windows.Forms.Padding(0);
            this.cb_harcamaturu.Name = "cb_harcamaturu";
            this.cb_harcamaturu.Size = new System.Drawing.Size(254, 39);
            this.cb_harcamaturu.TabIndex = 18;
            this.cb_harcamaturu.Text = "Türü Belirle";
            this.cb_harcamaturu.SelectedIndexChanged += new System.EventHandler(this.cb_harcamaturu_SelectedIndexChanged);
            // 
            // dt_tarih
            // 
            this.dt_tarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.dt_tarih.Enabled = false;
            this.dt_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tarih.Location = new System.Drawing.Point(0, 52);
            this.dt_tarih.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(241, 38);
            this.dt_tarih.TabIndex = 19;
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_aciklama.Location = new System.Drawing.Point(0, 0);
            this.tb_aciklama.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(241, 38);
            this.tb_aciklama.TabIndex = 24;
            this.tb_aciklama.Text = "Açıklama";
            this.tb_aciklama.Enter += new System.EventHandler(this.tb_gelirgider_Enter);
            this.tb_aciklama.Leave += new System.EventHandler(this.tb_tutar_Leave);
            // 
            // pl_main
            // 
            this.pl_main.BackColor = System.Drawing.Color.Transparent;
            this.pl_main.Controls.Add(this.pl_mainorta);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(0, 149);
            this.pl_main.Name = "pl_main";
            this.pl_main.Padding = new System.Windows.Forms.Padding(52, 0, 52, 0);
            this.pl_main.Size = new System.Drawing.Size(840, 360);
            this.pl_main.TabIndex = 2;
            // 
            // pl_mainorta
            // 
            this.pl_mainorta.BackColor = System.Drawing.Color.Transparent;
            this.pl_mainorta.Controls.Add(this.lv_kasa);
            this.pl_mainorta.Controls.Add(this.pl_lvbaslik);
            this.pl_mainorta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_mainorta.Location = new System.Drawing.Point(52, 0);
            this.pl_mainorta.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.pl_mainorta.Name = "pl_mainorta";
            this.pl_mainorta.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.pl_mainorta.Size = new System.Drawing.Size(736, 360);
            this.pl_mainorta.TabIndex = 1;
            // 
            // lv_kasa
            // 
            this.lv_kasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_kasa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.k_aciklama,
            this.kategori_adi,
            this.k_tur,
            this.k_eklenmetarihi,
            this.k_odemetarihi,
            this.k_tutar,
            this.k_id});
            this.lv_kasa.ContextMenuStrip = this.harcama_sil;
            this.lv_kasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_kasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_kasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lv_kasa.FullRowSelect = true;
            this.lv_kasa.GridLines = true;
            this.lv_kasa.Location = new System.Drawing.Point(0, 65);
            this.lv_kasa.Margin = new System.Windows.Forms.Padding(0);
            this.lv_kasa.Name = "lv_kasa";
            this.lv_kasa.Size = new System.Drawing.Size(736, 280);
            this.lv_kasa.TabIndex = 1;
            this.lv_kasa.UseCompatibleStateImageBehavior = false;
            this.lv_kasa.View = System.Windows.Forms.View.Details;
            this.lv_kasa.Click += new System.EventHandler(this.lv_kasa_Click);
            // 
            // k_aciklama
            // 
            this.k_aciklama.Text = "Açıklama";
            // 
            // kategori_adi
            // 
            this.kategori_adi.Text = "Kategori Adı";
            // 
            // k_tur
            // 
            this.k_tur.Text = "Tür";
            // 
            // k_eklenmetarihi
            // 
            this.k_eklenmetarihi.Text = "Eklenme Tarihi";
            // 
            // k_odemetarihi
            // 
            this.k_odemetarihi.Text = "Ödeme Tarihi";
            // 
            // k_tutar
            // 
            this.k_tutar.Text = "Tutar";
            // 
            // k_id
            // 
            this.k_id.Text = "ID";
            this.k_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.k_id.Width = 0;
            // 
            // harcama_sil
            // 
            this.harcama_sil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.harcama_sil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.harcama_sil.Name = "harcama_sil";
            this.harcama_sil.Size = new System.Drawing.Size(87, 26);
            this.harcama_sil.Text = "Sil";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // pl_lvbaslik
            // 
            this.pl_lvbaslik.BackColor = System.Drawing.Color.Crimson;
            this.pl_lvbaslik.Controls.Add(this.btn_kategoriekle);
            this.pl_lvbaslik.Controls.Add(this.lb_baslik);
            this.pl_lvbaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_lvbaslik.Location = new System.Drawing.Point(0, 15);
            this.pl_lvbaslik.Margin = new System.Windows.Forms.Padding(0);
            this.pl_lvbaslik.Name = "pl_lvbaslik";
            this.pl_lvbaslik.Size = new System.Drawing.Size(736, 50);
            this.pl_lvbaslik.TabIndex = 0;
            // 
            // btn_kategoriekle
            // 
            this.btn_kategoriekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_kategoriekle.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_kategoriekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kategoriekle.BorderRadius = 0;
            this.btn_kategoriekle.ButtonText = "Kategoriler";
            this.btn_kategoriekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kategoriekle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_kategoriekle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_kategoriekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_kategoriekle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_kategoriekle.Iconimage")));
            this.btn_kategoriekle.Iconimage_right = null;
            this.btn_kategoriekle.Iconimage_right_Selected = null;
            this.btn_kategoriekle.Iconimage_Selected = null;
            this.btn_kategoriekle.IconMarginLeft = 0;
            this.btn_kategoriekle.IconMarginRight = 0;
            this.btn_kategoriekle.IconRightVisible = true;
            this.btn_kategoriekle.IconRightZoom = 0D;
            this.btn_kategoriekle.IconVisible = true;
            this.btn_kategoriekle.IconZoom = 75D;
            this.btn_kategoriekle.IsTab = false;
            this.btn_kategoriekle.Location = new System.Drawing.Point(525, 0);
            this.btn_kategoriekle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kategoriekle.Name = "btn_kategoriekle";
            this.btn_kategoriekle.Normalcolor = System.Drawing.Color.OrangeRed;
            this.btn_kategoriekle.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btn_kategoriekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_kategoriekle.selected = false;
            this.btn_kategoriekle.Size = new System.Drawing.Size(211, 50);
            this.btn_kategoriekle.TabIndex = 2;
            this.btn_kategoriekle.Text = "Kategoriler";
            this.btn_kategoriekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_kategoriekle.Textcolor = System.Drawing.Color.White;
            this.btn_kategoriekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kategoriekle.Click += new System.EventHandler(this.btn_kategoriekle_Click);
            // 
            // lb_baslik
            // 
            this.lb_baslik.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_baslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_baslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_baslik.ForeColor = System.Drawing.Color.Orange;
            this.lb_baslik.Location = new System.Drawing.Point(0, 0);
            this.lb_baslik.Margin = new System.Windows.Forms.Padding(0);
            this.lb_baslik.Name = "lb_baslik";
            this.lb_baslik.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.lb_baslik.Size = new System.Drawing.Size(736, 50);
            this.lb_baslik.TabIndex = 0;
            this.lb_baslik.Text = "Kasa";
            this.lb_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.Color.DarkBlue;
            this.pl_header.Controls.Add(this.lb_tutar);
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header.Location = new System.Drawing.Point(0, 0);
            this.pl_header.Margin = new System.Windows.Forms.Padding(150, 3, 3, 3);
            this.pl_header.Name = "pl_header";
            this.pl_header.Padding = new System.Windows.Forms.Padding(200, 5, 200, 5);
            this.pl_header.Size = new System.Drawing.Size(862, 114);
            this.pl_header.TabIndex = 6;
            // 
            // lb_tutar
            // 
            this.lb_tutar.BackColor = System.Drawing.Color.Transparent;
            this.lb_tutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_tutar.ForeColor = System.Drawing.Color.AliceBlue;
            this.lb_tutar.Location = new System.Drawing.Point(200, 5);
            this.lb_tutar.Name = "lb_tutar";
            this.lb_tutar.Size = new System.Drawing.Size(462, 104);
            this.lb_tutar.TabIndex = 2;
            this.lb_tutar.Text = "Kasa 150 ₺";
            this.lb_tutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_aracizgi
            // 
            this.pl_aracizgi.BackColor = System.Drawing.Color.OrangeRed;
            this.pl_aracizgi.Controls.Add(this.lb_aciklama);
            this.pl_aracizgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_aracizgi.Location = new System.Drawing.Point(0, 114);
            this.pl_aracizgi.Name = "pl_aracizgi";
            this.pl_aracizgi.Size = new System.Drawing.Size(862, 35);
            this.pl_aracizgi.TabIndex = 7;
            // 
            // lb_aciklama
            // 
            this.lb_aciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_aciklama.ForeColor = System.Drawing.Color.White;
            this.lb_aciklama.Location = new System.Drawing.Point(0, 0);
            this.lb_aciklama.Name = "lb_aciklama";
            this.lb_aciklama.Size = new System.Drawing.Size(862, 35);
            this.lb_aciklama.TabIndex = 0;
            this.lb_aciklama.Text = "İşletmeniz hakkında ki gelir / gideri burada saklayabilirsiniz.";
            this.lb_aciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_kategoriekle
            // 
            this.pl_kategoriekle.BackColor = System.Drawing.Color.MediumVioletRed;
            this.pl_kategoriekle.Controls.Add(this.tlb_kategoriler);
            this.pl_kategoriekle.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_kategoriekle.Location = new System.Drawing.Point(840, 149);
            this.pl_kategoriekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_kategoriekle.Name = "pl_kategoriekle";
            this.pl_kategoriekle.Padding = new System.Windows.Forms.Padding(19, 15, 19, 15);
            this.pl_kategoriekle.Size = new System.Drawing.Size(22, 360);
            this.pl_kategoriekle.TabIndex = 9;
            this.pl_kategoriekle.Visible = false;
            // 
            // tlb_kategoriler
            // 
            this.tlb_kategoriler.ColumnCount = 1;
            this.tlb_kategoriler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlb_kategoriler.Controls.Add(this.bunifuFlatButton2, 0, 2);
            this.tlb_kategoriler.Controls.Add(this.lv_kategoriler, 0, 0);
            this.tlb_kategoriler.Controls.Add(this.tb_kategoriekle, 0, 1);
            this.tlb_kategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlb_kategoriler.Location = new System.Drawing.Point(19, 15);
            this.tlb_kategoriler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlb_kategoriler.Name = "tlb_kategoriler";
            this.tlb_kategoriler.RowCount = 3;
            this.tlb_kategoriler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.tlb_kategoriler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tlb_kategoriler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tlb_kategoriler.Size = new System.Drawing.Size(0, 330);
            this.tlb_kategoriler.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DarkBlue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Kategori Ekle";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 95D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 277);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DarkBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(1, 53);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "Kategori Ekle";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lv_kategoriler
            // 
            this.lv_kategoriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_kategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kategori,
            this.kategori_id});
            this.lv_kategoriler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_kategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_kategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lv_kategoriler.FullRowSelect = true;
            this.lv_kategoriler.GridLines = true;
            this.lv_kategoriler.Location = new System.Drawing.Point(0, 0);
            this.lv_kategoriler.Margin = new System.Windows.Forms.Padding(0);
            this.lv_kategoriler.MultiSelect = false;
            this.lv_kategoriler.Name = "lv_kategoriler";
            this.lv_kategoriler.Size = new System.Drawing.Size(1, 225);
            this.lv_kategoriler.TabIndex = 2;
            this.lv_kategoriler.UseCompatibleStateImageBehavior = false;
            this.lv_kategoriler.View = System.Windows.Forms.View.Details;
            // 
            // kategori
            // 
            this.kategori.Text = "Kategori Adı";
            // 
            // kategori_id
            // 
            this.kategori_id.Text = "Kategori ID";
            this.kategori_id.Width = 10;
            // 
            // tb_kategoriekle
            // 
            this.tb_kategoriekle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_kategoriekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_kategoriekle.Location = new System.Drawing.Point(0, 231);
            this.tb_kategoriekle.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tb_kategoriekle.Name = "tb_kategoriekle";
            this.tb_kategoriekle.Size = new System.Drawing.Size(1, 38);
            this.tb_kategoriekle.TabIndex = 5;
            this.tb_kategoriekle.Text = "Kategori Adı";
            this.tb_kategoriekle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_kategoriekle.Enter += new System.EventHandler(this.tb_gelirgider_Enter);
            this.tb_kategoriekle.Leave += new System.EventHandler(this.tb_tutar_Leave);
            // 
            // hesapdefteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 634);
            this.Controls.Add(this.pl_main);
            this.Controls.Add(this.pl_kategoriekle);
            this.Controls.Add(this.pl_aracizgi);
            this.Controls.Add(this.pl_header);
            this.Controls.Add(this.pl_footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hesapdefteri";
            this.Text = "hesapdefteri";
            this.SizeChanged += new System.EventHandler(this.hesapdefteri_SizeChanged);
            this.pl_footer.ResumeLayout(false);
            this.flp_footerbutonlar.ResumeLayout(false);
            this.tlp_butonheader.ResumeLayout(false);
            this.tlp_butonheader.PerformLayout();
            this.pl_main.ResumeLayout(false);
            this.pl_mainorta.ResumeLayout(false);
            this.harcama_sil.ResumeLayout(false);
            this.pl_lvbaslik.ResumeLayout(false);
            this.pl_header.ResumeLayout(false);
            this.pl_aracizgi.ResumeLayout(false);
            this.pl_kategoriekle.ResumeLayout(false);
            this.tlb_kategoriler.ResumeLayout(false);
            this.tlb_kategoriler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_footer;
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Panel pl_aracizgi;
        private System.Windows.Forms.Label lb_aciklama;
        private System.Windows.Forms.Panel pl_mainorta;
        private System.Windows.Forms.ListView lv_kasa;
        private System.Windows.Forms.Panel pl_lvbaslik;
        private System.Windows.Forms.Label lb_baslik;
        private System.Windows.Forms.Label lb_tutar;
        private System.Windows.Forms.Panel flp_footerbutonlar;
        private System.Windows.Forms.TableLayoutPanel tlp_butonheader;
        private System.Windows.Forms.ComboBox cb_harcamaturu;
        private System.Windows.Forms.ContextMenuStrip harcama_sil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dt_tarih;
        private Bunifu.Framework.UI.BunifuFlatButton btn_kategoriekle;
        private System.Windows.Forms.Panel pl_kategoriekle;
        private System.Windows.Forms.TableLayoutPanel tlb_kategoriler;
        private System.Windows.Forms.ListView lv_kategoriler;
        private System.Windows.Forms.ColumnHeader kategori;
        private System.Windows.Forms.ColumnHeader kategori_id;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.ComboBox cb_kategori;
        private Bunifu.Framework.UI.BunifuFlatButton btn_urunekle;
        private System.Windows.Forms.TextBox tb_kategoriekle;
        private System.Windows.Forms.TextBox tb_tutar;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.ColumnHeader k_aciklama;
        private System.Windows.Forms.ColumnHeader kategori_adi;
        private System.Windows.Forms.ColumnHeader k_tur;
        private System.Windows.Forms.ColumnHeader k_eklenmetarihi;
        private System.Windows.Forms.ColumnHeader k_odemetarihi;
        private System.Windows.Forms.ColumnHeader k_tutar;
        private System.Windows.Forms.ColumnHeader k_id;
    }
}