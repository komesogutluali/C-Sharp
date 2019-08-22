namespace LimonOtomasyon1.Formlar
{
    partial class Uyarı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uyarı));
            this.pl_main = new System.Windows.Forms.Panel();
            this.tb_mesaj = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_aciklama = new System.Windows.Forms.Label();
            this.pl_button = new System.Windows.Forms.Panel();
            this.btn_mesaj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_kapat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pl_main.SuspendLayout();
            this.pl_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_main
            // 
            this.pl_main.Controls.Add(this.tb_mesaj);
            this.pl_main.Controls.Add(this.lb_aciklama);
            this.pl_main.Controls.Add(this.pl_button);
            this.pl_main.Location = new System.Drawing.Point(45, 2);
            this.pl_main.Name = "pl_main";
            this.pl_main.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.pl_main.Size = new System.Drawing.Size(461, 197);
            this.pl_main.TabIndex = 0;
            // 
            // tb_mesaj
            // 
            this.tb_mesaj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mesaj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_mesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_mesaj.HintForeColor = System.Drawing.Color.Empty;
            this.tb_mesaj.HintText = "";
            this.tb_mesaj.isPassword = false;
            this.tb_mesaj.LineFocusedColor = System.Drawing.Color.Blue;
            this.tb_mesaj.LineIdleColor = System.Drawing.Color.White;
            this.tb_mesaj.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tb_mesaj.LineThickness = 3;
            this.tb_mesaj.Location = new System.Drawing.Point(42, 101);
            this.tb_mesaj.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mesaj.Name = "tb_mesaj";
            this.tb_mesaj.Size = new System.Drawing.Size(379, 33);
            this.tb_mesaj.TabIndex = 2;
            this.tb_mesaj.Text = "Masa Adını Yaz";
            this.tb_mesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_aciklama
            // 
            this.lb_aciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_aciklama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_aciklama.Location = new System.Drawing.Point(5, 15);
            this.lb_aciklama.Name = "lb_aciklama";
            this.lb_aciklama.Size = new System.Drawing.Size(451, 125);
            this.lb_aciklama.TabIndex = 1;
            this.lb_aciklama.Text = "label1";
            // 
            // pl_button
            // 
            this.pl_button.Controls.Add(this.btn_kapat);
            this.pl_button.Controls.Add(this.btn_mesaj);
            this.pl_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_button.Location = new System.Drawing.Point(5, 140);
            this.pl_button.Name = "pl_button";
            this.pl_button.Size = new System.Drawing.Size(451, 47);
            this.pl_button.TabIndex = 0;
            // 
            // btn_mesaj
            // 
            this.btn_mesaj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_mesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_mesaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mesaj.BorderRadius = 0;
            this.btn_mesaj.ButtonText = "Tamam";
            this.btn_mesaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mesaj.DisabledColor = System.Drawing.Color.Gray;
            this.btn_mesaj.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_mesaj.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_mesaj.Iconimage")));
            this.btn_mesaj.Iconimage_right = null;
            this.btn_mesaj.Iconimage_right_Selected = null;
            this.btn_mesaj.Iconimage_Selected = null;
            this.btn_mesaj.IconMarginLeft = 0;
            this.btn_mesaj.IconMarginRight = 0;
            this.btn_mesaj.IconRightVisible = true;
            this.btn_mesaj.IconRightZoom = 0D;
            this.btn_mesaj.IconVisible = true;
            this.btn_mesaj.IconZoom = 75D;
            this.btn_mesaj.IsTab = false;
            this.btn_mesaj.Location = new System.Drawing.Point(37, 6);
            this.btn_mesaj.Margin = new System.Windows.Forms.Padding(0);
            this.btn_mesaj.Name = "btn_mesaj";
            this.btn_mesaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_mesaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_mesaj.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_mesaj.selected = false;
            this.btn_mesaj.Size = new System.Drawing.Size(173, 41);
            this.btn_mesaj.TabIndex = 0;
            this.btn_mesaj.Text = "Tamam";
            this.btn_mesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mesaj.Textcolor = System.Drawing.Color.White;
            this.btn_mesaj.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_kapat
            // 
            this.btn_kapat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kapat.BorderRadius = 0;
            this.btn_kapat.ButtonText = "Kapat";
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.DisabledColor = System.Drawing.Color.Gray;
            this.btn_kapat.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_kapat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Iconimage")));
            this.btn_kapat.Iconimage_right = null;
            this.btn_kapat.Iconimage_right_Selected = null;
            this.btn_kapat.Iconimage_Selected = null;
            this.btn_kapat.IconMarginLeft = 0;
            this.btn_kapat.IconMarginRight = 0;
            this.btn_kapat.IconRightVisible = true;
            this.btn_kapat.IconRightZoom = 0D;
            this.btn_kapat.IconVisible = true;
            this.btn_kapat.IconZoom = 75D;
            this.btn_kapat.IsTab = false;
            this.btn_kapat.Location = new System.Drawing.Point(243, 6);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_kapat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_kapat.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_kapat.selected = false;
            this.btn_kapat.Size = new System.Drawing.Size(173, 41);
            this.btn_kapat.TabIndex = 1;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_kapat.Textcolor = System.Drawing.Color.White;
            this.btn_kapat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // Uyarı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(550, 200);
            this.Controls.Add(this.pl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Uyarı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uyarı";
            this.Load += new System.EventHandler(this.Uyarı_Load);
            this.pl_main.ResumeLayout(false);
            this.pl_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Label lb_aciklama;
        private System.Windows.Forms.Panel pl_button;
        private Bunifu.Framework.UI.BunifuFlatButton btn_mesaj;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_mesaj;
        private Bunifu.Framework.UI.BunifuFlatButton btn_kapat;
    }
}