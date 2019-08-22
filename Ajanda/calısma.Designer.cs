namespace Ajanda
{
    partial class calısma
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
            this.lgun = new System.Windows.Forms.ListBox();
            this.lmesai = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bsil = new System.Windows.Forms.Button();
            this.bduz = new System.Windows.Forms.Button();
            this.bekle = new System.Windows.Forms.Button();
            this.tmesai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tmaas = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bmashesapla = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mesaipa = new System.Windows.Forms.Label();
            this.cgunpa = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.toppa = new System.Windows.Forms.Label();
            this.brapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lgun
            // 
            this.lgun.FormattingEnabled = true;
            this.lgun.Location = new System.Drawing.Point(18, 26);
            this.lgun.Name = "lgun";
            this.lgun.Size = new System.Drawing.Size(116, 303);
            this.lgun.TabIndex = 0;
            this.lgun.SelectedIndexChanged += new System.EventHandler(this.lgun_SelectedIndexChanged);
            // 
            // lmesai
            // 
            this.lmesai.FormattingEnabled = true;
            this.lmesai.Location = new System.Drawing.Point(135, 26);
            this.lmesai.Name = "lmesai";
            this.lmesai.Size = new System.Drawing.Size(71, 303);
            this.lmesai.TabIndex = 1;
            this.lmesai.SelectedIndexChanged += new System.EventHandler(this.lgun_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÇALIŞMA GÜNLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MESAİ SAATİ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // bsil
            // 
            this.bsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bsil.Location = new System.Drawing.Point(213, 150);
            this.bsil.Name = "bsil";
            this.bsil.Size = new System.Drawing.Size(200, 36);
            this.bsil.TabIndex = 12;
            this.bsil.Text = "SİL";
            this.bsil.UseVisualStyleBackColor = true;
            this.bsil.Click += new System.EventHandler(this.bsil_Click);
            // 
            // bduz
            // 
            this.bduz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bduz.Location = new System.Drawing.Point(212, 189);
            this.bduz.Name = "bduz";
            this.bduz.Size = new System.Drawing.Size(200, 36);
            this.bduz.TabIndex = 11;
            this.bduz.Text = "DÜZENLE";
            this.bduz.UseVisualStyleBackColor = true;
            this.bduz.Click += new System.EventHandler(this.bduz_Click);
            // 
            // bekle
            // 
            this.bekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bekle.Location = new System.Drawing.Point(213, 111);
            this.bekle.Name = "bekle";
            this.bekle.Size = new System.Drawing.Size(200, 36);
            this.bekle.TabIndex = 10;
            this.bekle.Text = "GÜN/MESAİ EKLE";
            this.bekle.UseVisualStyleBackColor = true;
            this.bekle.Click += new System.EventHandler(this.bekle_Click);
            // 
            // tmesai
            // 
            this.tmesai.Location = new System.Drawing.Point(212, 85);
            this.tmesai.Name = "tmesai";
            this.tmesai.Size = new System.Drawing.Size(200, 20);
            this.tmesai.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(151, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "MESAİ TOPLAMI::";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(257, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "MESAİ SAATİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(101, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "GÜN TOPLAMI::";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(488, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "İSİM::";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(528, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // tmaas
            // 
            this.tmaas.Location = new System.Drawing.Point(548, 101);
            this.tmaas.Name = "tmaas";
            this.tmaas.Size = new System.Drawing.Size(100, 20);
            this.tmaas.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(548, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(0, 20);
            this.textBox4.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(497, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "MAAŞ::";
            // 
            // bmashesapla
            // 
            this.bmashesapla.Location = new System.Drawing.Point(548, 127);
            this.bmashesapla.Name = "bmashesapla";
            this.bmashesapla.Size = new System.Drawing.Size(100, 23);
            this.bmashesapla.TabIndex = 26;
            this.bmashesapla.Text = "HESAPLA";
            this.bmashesapla.UseVisualStyleBackColor = true;
            this.bmashesapla.Click += new System.EventHandler(this.bmashesapla_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(666, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "ÇALIŞTIĞIN GÜN TL::";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(666, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "MESAİ::";
            // 
            // mesaipa
            // 
            this.mesaipa.AutoSize = true;
            this.mesaipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaipa.Location = new System.Drawing.Point(720, 125);
            this.mesaipa.Name = "mesaipa";
            this.mesaipa.Size = new System.Drawing.Size(48, 13);
            this.mesaipa.TabIndex = 30;
            this.mesaipa.Text = "label13";
            // 
            // cgunpa
            // 
            this.cgunpa.AutoSize = true;
            this.cgunpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cgunpa.Location = new System.Drawing.Point(801, 101);
            this.cgunpa.Name = "cgunpa";
            this.cgunpa.Size = new System.Drawing.Size(48, 13);
            this.cgunpa.TabIndex = 29;
            this.cgunpa.Text = "label14";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(666, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "TOPLAM::";
            // 
            // toppa
            // 
            this.toppa.AutoSize = true;
            this.toppa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toppa.Location = new System.Drawing.Point(729, 147);
            this.toppa.Name = "toppa";
            this.toppa.Size = new System.Drawing.Size(48, 13);
            this.toppa.TabIndex = 32;
            this.toppa.Text = "label15";
            // 
            // brapor
            // 
            this.brapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brapor.Location = new System.Drawing.Point(212, 231);
            this.brapor.Name = "brapor";
            this.brapor.Size = new System.Drawing.Size(201, 35);
            this.brapor.TabIndex = 33;
            this.brapor.Text = "RAPORLA";
            this.brapor.UseVisualStyleBackColor = true;
            this.brapor.Click += new System.EventHandler(this.brapor_Click);
            // 
            // calısma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 404);
            this.Controls.Add(this.brapor);
            this.Controls.Add(this.toppa);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mesaipa);
            this.Controls.Add(this.cgunpa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bmashesapla);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tmaas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tmesai);
            this.Controls.Add(this.bsil);
            this.Controls.Add(this.bduz);
            this.Controls.Add(this.bekle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lmesai);
            this.Controls.Add(this.lgun);
            this.Name = "calısma";
            this.Text = "calısma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lgun;
        private System.Windows.Forms.ListBox lmesai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bsil;
        private System.Windows.Forms.Button bduz;
        private System.Windows.Forms.Button bekle;
        private System.Windows.Forms.TextBox tmesai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tmaas;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bmashesapla;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label mesaipa;
        public System.Windows.Forms.Label cgunpa;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label toppa;
        private System.Windows.Forms.Button brapor;
    }
}