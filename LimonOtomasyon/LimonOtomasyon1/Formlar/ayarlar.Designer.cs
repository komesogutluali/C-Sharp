namespace LimonOtomasyon1.Formlar
{
    partial class ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            this.pl_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Baslik = new System.Windows.Forms.Label();
            this.pl_buton = new System.Windows.Forms.Panel();
            this.bfb_kaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pl_main = new System.Windows.Forms.Panel();
            this.pl_uyari = new System.Windows.Forms.Panel();
            this.lb_uyari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bmt_masasayisi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pl_buton.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.pl_uyari.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_header
            // 
            this.pl_header.Controls.Add(this.pictureBox1);
            this.pl_header.Controls.Add(this.lb_Baslik);
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header.Location = new System.Drawing.Point(75, 0);
            this.pl_header.Name = "pl_header";
            this.pl_header.Size = new System.Drawing.Size(712, 91);
            this.pl_header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Baslik
            // 
            this.lb_Baslik.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_Baslik.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_Baslik.Location = new System.Drawing.Point(124, 0);
            this.lb_Baslik.Name = "lb_Baslik";
            this.lb_Baslik.Size = new System.Drawing.Size(588, 91);
            this.lb_Baslik.TabIndex = 0;
            this.lb_Baslik.Text = "Ayarlar";
            this.lb_Baslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pl_buton
            // 
            this.pl_buton.Controls.Add(this.bfb_kaydet);
            this.pl_buton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_buton.Location = new System.Drawing.Point(75, 570);
            this.pl_buton.Name = "pl_buton";
            this.pl_buton.Size = new System.Drawing.Size(712, 64);
            this.pl_buton.TabIndex = 1;
            // 
            // bfb_kaydet
            // 
            this.bfb_kaydet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_kaydet.BackColor = System.Drawing.Color.DarkBlue;
            this.bfb_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_kaydet.BorderRadius = 0;
            this.bfb_kaydet.ButtonText = "Kaydet";
            this.bfb_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfb_kaydet.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_kaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bfb_kaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_kaydet.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_kaydet.Iconimage")));
            this.bfb_kaydet.Iconimage_right = null;
            this.bfb_kaydet.Iconimage_right_Selected = null;
            this.bfb_kaydet.Iconimage_Selected = null;
            this.bfb_kaydet.IconMarginLeft = 0;
            this.bfb_kaydet.IconMarginRight = 0;
            this.bfb_kaydet.IconRightVisible = true;
            this.bfb_kaydet.IconRightZoom = 0D;
            this.bfb_kaydet.IconVisible = false;
            this.bfb_kaydet.IconZoom = 90D;
            this.bfb_kaydet.IsTab = false;
            this.bfb_kaydet.Location = new System.Drawing.Point(0, 16);
            this.bfb_kaydet.Name = "bfb_kaydet";
            this.bfb_kaydet.Normalcolor = System.Drawing.Color.DarkBlue;
            this.bfb_kaydet.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.bfb_kaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_kaydet.selected = false;
            this.bfb_kaydet.Size = new System.Drawing.Size(712, 48);
            this.bfb_kaydet.TabIndex = 0;
            this.bfb_kaydet.Text = "Kaydet";
            this.bfb_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfb_kaydet.Textcolor = System.Drawing.Color.White;
            this.bfb_kaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_kaydet.Click += new System.EventHandler(this.bfb_kaydet_Click);
            // 
            // pl_main
            // 
            this.pl_main.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pl_main.Controls.Add(this.pl_uyari);
            this.pl_main.Controls.Add(this.label1);
            this.pl_main.Controls.Add(this.bmt_masasayisi);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(75, 91);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(712, 479);
            this.pl_main.TabIndex = 1;
            // 
            // pl_uyari
            // 
            this.pl_uyari.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pl_uyari.Controls.Add(this.lb_uyari);
            this.pl_uyari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_uyari.Location = new System.Drawing.Point(0, 443);
            this.pl_uyari.Name = "pl_uyari";
            this.pl_uyari.Size = new System.Drawing.Size(712, 36);
            this.pl_uyari.TabIndex = 3;
            // 
            // lb_uyari
            // 
            this.lb_uyari.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_uyari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_uyari.ForeColor = System.Drawing.Color.Crimson;
            this.lb_uyari.Location = new System.Drawing.Point(0, 0);
            this.lb_uyari.Name = "lb_uyari";
            this.lb_uyari.Size = new System.Drawing.Size(712, 36);
            this.lb_uyari.TabIndex = 2;
            this.lb_uyari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşletmenizde kaç tane masa olacağını belirtin.";
            // 
            // bmt_masasayisi
            // 
            this.bmt_masasayisi.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmt_masasayisi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_masasayisi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmt_masasayisi.BorderThickness = 3;
            this.bmt_masasayisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_masasayisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_masasayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_masasayisi.isPassword = false;
            this.bmt_masasayisi.Location = new System.Drawing.Point(394, 16);
            this.bmt_masasayisi.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_masasayisi.Name = "bmt_masasayisi";
            this.bmt_masasayisi.Size = new System.Drawing.Size(277, 44);
            this.bmt_masasayisi.TabIndex = 0;
            this.bmt_masasayisi.Text = "Masa Sayısı";
            this.bmt_masasayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_masasayisi.Enter += new System.EventHandler(this.bmt_masasayisi_Enter);
            this.bmt_masasayisi.Leave += new System.EventHandler(this.bmt_masasayisi_Leave);
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 634);
            this.Controls.Add(this.pl_main);
            this.Controls.Add(this.pl_buton);
            this.Controls.Add(this.pl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ayarlar";
            this.Padding = new System.Windows.Forms.Padding(75, 0, 75, 0);
            this.Text = "ayarlar";
            this.pl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pl_buton.ResumeLayout(false);
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
            this.pl_uyari.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Label lb_Baslik;
        private System.Windows.Forms.Panel pl_buton;
        private System.Windows.Forms.Panel pl_main;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmt_masasayisi;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_kaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pl_uyari;
        private System.Windows.Forms.Label lb_uyari;
    }
}