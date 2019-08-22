namespace LimonOtomasyon1.Formlar.KucukFormlar
{
    partial class masa_tasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masa_tasi));
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_aciklama = new System.Windows.Forms.Label();
            this.btn_masatasi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bd_bosmasa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageActive = null;
            this.btn_kapat.Location = new System.Drawing.Point(471, 1);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(26, 24);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_kapat.TabIndex = 4;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_aciklama);
            this.panel1.Location = new System.Drawing.Point(39, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 81);
            this.panel1.TabIndex = 5;
            // 
            // lb_aciklama
            // 
            this.lb_aciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_aciklama.Location = new System.Drawing.Point(0, 0);
            this.lb_aciklama.Name = "lb_aciklama";
            this.lb_aciklama.Size = new System.Drawing.Size(406, 81);
            this.lb_aciklama.TabIndex = 0;
            this.lb_aciklama.Text = "label1";
            // 
            // btn_masatasi
            // 
            this.btn_masatasi.Activecolor = System.Drawing.Color.DarkBlue;
            this.btn_masatasi.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_masatasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_masatasi.BorderRadius = 0;
            this.btn_masatasi.ButtonText = "Masa Taşı";
            this.btn_masatasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_masatasi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_masatasi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_masatasi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_masatasi.Iconimage")));
            this.btn_masatasi.Iconimage_right = null;
            this.btn_masatasi.Iconimage_right_Selected = null;
            this.btn_masatasi.Iconimage_Selected = null;
            this.btn_masatasi.IconMarginLeft = 0;
            this.btn_masatasi.IconMarginRight = 0;
            this.btn_masatasi.IconRightVisible = true;
            this.btn_masatasi.IconRightZoom = 0D;
            this.btn_masatasi.IconVisible = true;
            this.btn_masatasi.IconZoom = 90D;
            this.btn_masatasi.IsTab = false;
            this.btn_masatasi.Location = new System.Drawing.Point(39, 182);
            this.btn_masatasi.Name = "btn_masatasi";
            this.btn_masatasi.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btn_masatasi.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btn_masatasi.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_masatasi.selected = false;
            this.btn_masatasi.Size = new System.Drawing.Size(406, 56);
            this.btn_masatasi.TabIndex = 7;
            this.btn_masatasi.Text = "Masa Taşı";
            this.btn_masatasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_masatasi.Textcolor = System.Drawing.Color.White;
            this.btn_masatasi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_masatasi.Click += new System.EventHandler(this.btn_masatasi_Click);
            // 
            // bd_bosmasa
            // 
            this.bd_bosmasa.BackColor = System.Drawing.Color.OrangeRed;
            this.bd_bosmasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bd_bosmasa.FormattingEnabled = true;
            this.bd_bosmasa.Location = new System.Drawing.Point(39, 110);
            this.bd_bosmasa.Name = "bd_bosmasa";
            this.bd_bosmasa.Size = new System.Drawing.Size(406, 33);
            this.bd_bosmasa.TabIndex = 8;
            // 
            // masa_tasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.bd_bosmasa);
            this.Controls.Add(this.btn_masatasi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_kapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "masa_tasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "masa_tasi";
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_aciklama;
        private Bunifu.Framework.UI.BunifuFlatButton btn_masatasi;
        private System.Windows.Forms.ComboBox bd_bosmasa;
    }
}