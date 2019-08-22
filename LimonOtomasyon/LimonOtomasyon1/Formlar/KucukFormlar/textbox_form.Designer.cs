namespace LimonOtomasyon1.Formlar.KucukFormlar
{
    partial class textbox_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textbox_form));
            this.pl_aciklama = new System.Windows.Forms.Panel();
            this.lbl_aciklama = new System.Windows.Forms.Label();
            this.bmt_personelad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bfb_personelsil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            this.pl_aciklama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_aciklama
            // 
            this.pl_aciklama.Controls.Add(this.lbl_aciklama);
            this.pl_aciklama.Location = new System.Drawing.Point(37, 30);
            this.pl_aciklama.Name = "pl_aciklama";
            this.pl_aciklama.Size = new System.Drawing.Size(411, 69);
            this.pl_aciklama.TabIndex = 0;
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aciklama.Location = new System.Drawing.Point(0, 0);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.Size = new System.Drawing.Size(411, 69);
            this.lbl_aciklama.TabIndex = 0;
            this.lbl_aciklama.Text = "Bilgilerinin silinmesini istediğiniz personelin lütfen adını yazınız.";
            // 
            // bmt_personelad
            // 
            this.bmt_personelad.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmt_personelad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_personelad.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmt_personelad.BorderThickness = 3;
            this.bmt_personelad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_personelad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_personelad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_personelad.isPassword = false;
            this.bmt_personelad.Location = new System.Drawing.Point(37, 115);
            this.bmt_personelad.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_personelad.Name = "bmt_personelad";
            this.bmt_personelad.Size = new System.Drawing.Size(407, 44);
            this.bmt_personelad.TabIndex = 1;
            this.bmt_personelad.Text = "Personel Adı";
            this.bmt_personelad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_personelad.Enter += new System.EventHandler(this.bmt_personelad_Enter);
            this.bmt_personelad.Leave += new System.EventHandler(this.bmt_personelad_Leave);
            // 
            // bfb_personelsil
            // 
            this.bfb_personelsil.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.bfb_personelsil.BackColor = System.Drawing.Color.DarkOrange;
            this.bfb_personelsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_personelsil.BorderRadius = 0;
            this.bfb_personelsil.ButtonText = "Personel Bilgilerini Kaldır";
            this.bfb_personelsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfb_personelsil.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_personelsil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bfb_personelsil.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_personelsil.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_personelsil.Iconimage")));
            this.bfb_personelsil.Iconimage_right = null;
            this.bfb_personelsil.Iconimage_right_Selected = null;
            this.bfb_personelsil.Iconimage_Selected = null;
            this.bfb_personelsil.IconMarginLeft = 0;
            this.bfb_personelsil.IconMarginRight = 0;
            this.bfb_personelsil.IconRightVisible = false;
            this.bfb_personelsil.IconRightZoom = 0D;
            this.bfb_personelsil.IconVisible = false;
            this.bfb_personelsil.IconZoom = 100D;
            this.bfb_personelsil.IsTab = false;
            this.bfb_personelsil.Location = new System.Drawing.Point(37, 175);
            this.bfb_personelsil.Name = "bfb_personelsil";
            this.bfb_personelsil.Normalcolor = System.Drawing.Color.DarkOrange;
            this.bfb_personelsil.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.bfb_personelsil.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_personelsil.selected = false;
            this.bfb_personelsil.Size = new System.Drawing.Size(407, 48);
            this.bfb_personelsil.TabIndex = 8;
            this.bfb_personelsil.Text = "Personel Bilgilerini Kaldır";
            this.bfb_personelsil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfb_personelsil.Textcolor = System.Drawing.Color.White;
            this.bfb_personelsil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_personelsil.Click += new System.EventHandler(this.bfb_personelsil_Click);
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
            this.btn_kapat.TabIndex = 9;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // textbox_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(485, 252);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.bfb_personelsil);
            this.Controls.Add(this.bmt_personelad);
            this.Controls.Add(this.pl_aciklama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "textbox_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "textbox_form";
            this.pl_aciklama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_aciklama;
        private System.Windows.Forms.Label lbl_aciklama;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmt_personelad;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_personelsil;
        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
    }
}