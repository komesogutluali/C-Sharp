namespace Ajanda
{
    partial class rapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBLPUANTAJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AJANDADataSet = new Ajanda.AJANDADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBLPUANTAJTableAdapter = new Ajanda.AJANDADataSetTableAdapters.TBLPUANTAJTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBLPUANTAJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJANDADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TBLPUANTAJBindingSource
            // 
            this.TBLPUANTAJBindingSource.DataMember = "TBLPUANTAJ";
            this.TBLPUANTAJBindingSource.DataSource = this.AJANDADataSet;
            // 
            // AJANDADataSet
            // 
            this.AJANDADataSet.DataSetName = "AJANDADataSet";
            this.AJANDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBLPUANTAJBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ajanda.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1111, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // TBLPUANTAJTableAdapter
            // 
            this.TBLPUANTAJTableAdapter.ClearBeforeFill = true;
            // 
            // rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 505);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rapor";
            this.Text = "rapor";
            this.Load += new System.EventHandler(this.rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLPUANTAJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJANDADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBLPUANTAJBindingSource;
        private AJANDADataSet AJANDADataSet;
        public AJANDADataSetTableAdapters.TBLPUANTAJTableAdapter TBLPUANTAJTableAdapter;
    }
}