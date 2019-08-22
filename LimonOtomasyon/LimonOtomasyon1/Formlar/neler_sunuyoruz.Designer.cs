namespace LimonOtomasyon1.Formlar
{
    partial class neler_sunuyoruz
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
            this.pl_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pl_sag = new System.Windows.Forms.Panel();
            this.pl_sol = new System.Windows.Forms.Panel();
            this.pl_metin = new System.Windows.Forms.Panel();
            this.lb_metin = new System.Windows.Forms.Label();
            this.pl_baslik = new System.Windows.Forms.Panel();
            this.lb_baslik = new System.Windows.Forms.Label();
            this.pl_header = new System.Windows.Forms.Panel();
            this.pl_main.SuspendLayout();
            this.pl_sol.SuspendLayout();
            this.pl_metin.SuspendLayout();
            this.pl_baslik.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_main
            // 
            this.pl_main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pl_main.Controls.Add(this.panel1);
            this.pl_main.Controls.Add(this.pl_sag);
            this.pl_main.Controls.Add(this.pl_sol);
            this.pl_main.Controls.Add(this.pl_header);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(25, 25);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(707, 457);
            this.pl_main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(378, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 341);
            this.panel1.TabIndex = 3;
            // 
            // pl_sag
            // 
            this.pl_sag.BackColor = System.Drawing.Color.Turquoise;
            this.pl_sag.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_sag.Location = new System.Drawing.Point(368, 116);
            this.pl_sag.Name = "pl_sag";
            this.pl_sag.Size = new System.Drawing.Size(339, 341);
            this.pl_sag.TabIndex = 1;
            // 
            // pl_sol
            // 
            this.pl_sol.BackColor = System.Drawing.Color.Violet;
            this.pl_sol.Controls.Add(this.pl_metin);
            this.pl_sol.Controls.Add(this.pl_baslik);
            this.pl_sol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_sol.Location = new System.Drawing.Point(0, 116);
            this.pl_sol.Name = "pl_sol";
            this.pl_sol.Padding = new System.Windows.Forms.Padding(3, 10, 0, 25);
            this.pl_sol.Size = new System.Drawing.Size(378, 341);
            this.pl_sol.TabIndex = 0;
            // 
            // pl_metin
            // 
            this.pl_metin.Controls.Add(this.lb_metin);
            this.pl_metin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_metin.Location = new System.Drawing.Point(3, 136);
            this.pl_metin.Name = "pl_metin";
            this.pl_metin.Size = new System.Drawing.Size(375, 180);
            this.pl_metin.TabIndex = 2;
            // 
            // lb_metin
            // 
            this.lb_metin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_metin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_metin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_metin.Location = new System.Drawing.Point(0, 0);
            this.lb_metin.Name = "lb_metin";
            this.lb_metin.Size = new System.Drawing.Size(375, 180);
            this.lb_metin.TabIndex = 0;
            this.lb_metin.Text = "label1";
            // 
            // pl_baslik
            // 
            this.pl_baslik.Controls.Add(this.lb_baslik);
            this.pl_baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_baslik.Location = new System.Drawing.Point(3, 10);
            this.pl_baslik.Name = "pl_baslik";
            this.pl_baslik.Size = new System.Drawing.Size(375, 132);
            this.pl_baslik.TabIndex = 1;
            // 
            // lb_baslik
            // 
            this.lb_baslik.BackColor = System.Drawing.Color.Transparent;
            this.lb_baslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_baslik.ForeColor = System.Drawing.Color.Crimson;
            this.lb_baslik.Location = new System.Drawing.Point(0, 0);
            this.lb_baslik.Name = "lb_baslik";
            this.lb_baslik.Size = new System.Drawing.Size(375, 132);
            this.lb_baslik.TabIndex = 0;
            this.lb_baslik.Text = "Her Şey Daha Düzenli";
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.SystemColors.ControlText;
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header.Location = new System.Drawing.Point(0, 0);
            this.pl_header.Name = "pl_header";
            this.pl_header.Size = new System.Drawing.Size(707, 116);
            this.pl_header.TabIndex = 2;
            // 
            // neler_sunuyoruz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 507);
            this.Controls.Add(this.pl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "neler_sunuyoruz";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "neler_sunuyoruz";
            this.pl_main.ResumeLayout(false);
            this.pl_sol.ResumeLayout(false);
            this.pl_metin.ResumeLayout(false);
            this.pl_baslik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pl_sag;
        private System.Windows.Forms.Panel pl_sol;
        private System.Windows.Forms.Panel pl_baslik;
        private System.Windows.Forms.Label lb_baslik;
        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Panel pl_metin;
        private System.Windows.Forms.Label lb_metin;
    }
}