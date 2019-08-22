namespace Ajanda
{
    partial class Form1
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
            this.tad = new System.Windows.Forms.TextBox();
            this.tsoy = new System.Windows.Forms.TextBox();
            this.bekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lkisiler = new System.Windows.Forms.ListView();
            this.bduz = new System.Windows.Forms.Button();
            this.bsil = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bsec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tad
            // 
            this.tad.Location = new System.Drawing.Point(78, 35);
            this.tad.Name = "tad";
            this.tad.Size = new System.Drawing.Size(144, 20);
            this.tad.TabIndex = 0;
            // 
            // tsoy
            // 
            this.tsoy.Location = new System.Drawing.Point(78, 75);
            this.tsoy.Name = "tsoy";
            this.tsoy.Size = new System.Drawing.Size(144, 20);
            this.tsoy.TabIndex = 1;
            // 
            // bekle
            // 
            this.bekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bekle.Location = new System.Drawing.Point(78, 112);
            this.bekle.Name = "bekle";
            this.bekle.Size = new System.Drawing.Size(145, 23);
            this.bekle.TabIndex = 2;
            this.bekle.Text = "KAYDET";
            this.bekle.UseVisualStyleBackColor = true;
            this.bekle.Click += new System.EventHandler(this.bekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SOYAD:";
            // 
            // lkisiler
            // 
            this.lkisiler.Location = new System.Drawing.Point(229, 32);
            this.lkisiler.Name = "lkisiler";
            this.lkisiler.Size = new System.Drawing.Size(339, 223);
            this.lkisiler.TabIndex = 7;
            this.lkisiler.UseCompatibleStateImageBehavior = false;
            // 
            // bduz
            // 
            this.bduz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bduz.Location = new System.Drawing.Point(77, 190);
            this.bduz.Name = "bduz";
            this.bduz.Size = new System.Drawing.Size(145, 23);
            this.bduz.TabIndex = 8;
            this.bduz.Text = "DÜZENLE";
            this.bduz.UseVisualStyleBackColor = true;
            this.bduz.Click += new System.EventHandler(this.bduz_Click);
            // 
            // bsil
            // 
            this.bsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bsil.Location = new System.Drawing.Point(78, 150);
            this.bsil.Name = "bsil";
            this.bsil.Size = new System.Drawing.Size(145, 23);
            this.bsil.TabIndex = 9;
            this.bsil.Text = "SİL";
            this.bsil.UseVisualStyleBackColor = true;
            this.bsil.Click += new System.EventHandler(this.bsil_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(590, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // bsec
            // 
            this.bsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bsec.Location = new System.Drawing.Point(78, 232);
            this.bsec.Name = "bsec";
            this.bsec.Size = new System.Drawing.Size(145, 23);
            this.bsec.TabIndex = 11;
            this.bsec.Text = "SEÇ";
            this.bsec.UseVisualStyleBackColor = true;
            this.bsec.Click += new System.EventHandler(this.bsec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 388);
            this.Controls.Add(this.bsec);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bsil);
            this.Controls.Add(this.bduz);
            this.Controls.Add(this.lkisiler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bekle);
            this.Controls.Add(this.tsoy);
            this.Controls.Add(this.tad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "AJANDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tad;
        private System.Windows.Forms.TextBox tsoy;
        private System.Windows.Forms.Button bekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lkisiler;
        private System.Windows.Forms.Button bduz;
        private System.Windows.Forms.Button bsil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bsec;
    }
}

