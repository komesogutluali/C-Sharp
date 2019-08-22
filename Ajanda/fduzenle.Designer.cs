namespace Ajanda
{
    partial class fduzenle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsoy = new System.Windows.Forms.TextBox();
            this.tad = new System.Windows.Forms.TextBox();
            this.bekle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btarih = new System.Windows.Forms.Button();
            this.btrhkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "AD:";
            // 
            // tsoy
            // 
            this.tsoy.Location = new System.Drawing.Point(94, 70);
            this.tsoy.Name = "tsoy";
            this.tsoy.Size = new System.Drawing.Size(144, 20);
            this.tsoy.TabIndex = 7;
            // 
            // tad
            // 
            this.tad.Location = new System.Drawing.Point(94, 30);
            this.tad.Name = "tad";
            this.tad.Size = new System.Drawing.Size(144, 20);
            this.tad.TabIndex = 6;
            // 
            // bekle
            // 
            this.bekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bekle.Location = new System.Drawing.Point(93, 121);
            this.bekle.Name = "bekle";
            this.bekle.Size = new System.Drawing.Size(145, 23);
            this.bekle.TabIndex = 10;
            this.bekle.Text = "KAYDET";
            this.bekle.UseVisualStyleBackColor = true;
            this.bekle.Click += new System.EventHandler(this.bekle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "İŞEBASLANGIC TARİHİ::";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // btarih
            // 
            this.btarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btarih.Location = new System.Drawing.Point(265, 70);
            this.btarih.Name = "btarih";
            this.btarih.Size = new System.Drawing.Size(145, 23);
            this.btarih.TabIndex = 14;
            this.btarih.Text = "TARİHİ DÜZENLE";
            this.btarih.UseVisualStyleBackColor = true;
            this.btarih.Click += new System.EventHandler(this.btarih_Click);
            // 
            // btrhkaydet
            // 
            this.btrhkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btrhkaydet.Location = new System.Drawing.Point(357, 150);
            this.btrhkaydet.Name = "btrhkaydet";
            this.btrhkaydet.Size = new System.Drawing.Size(108, 42);
            this.btrhkaydet.TabIndex = 16;
            this.btrhkaydet.Text = "TARİHİ KAYDET";
            this.btrhkaydet.UseVisualStyleBackColor = true;
            this.btrhkaydet.Click += new System.EventHandler(this.btrhkaydet_Click);
            // 
            // fduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 295);
            this.Controls.Add(this.btrhkaydet);
            this.Controls.Add(this.btarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsoy);
            this.Controls.Add(this.tad);
            this.Name = "fduzenle";
            this.Text = "fduzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsoy;
        private System.Windows.Forms.TextBox tad;
        private System.Windows.Forms.Button bekle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btarih;
        private System.Windows.Forms.Button btrhkaydet;
    }
}