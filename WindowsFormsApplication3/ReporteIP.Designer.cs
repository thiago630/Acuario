namespace WindowsFormsApplication3
{
    partial class ReporteIP
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetIP = new WindowsFormsApplication3.DataSetIP();
            this.CAMA_IPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CAMA_IPTableAdapter = new WindowsFormsApplication3.DataSetIPTableAdapters.CAMA_IPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAMA_IPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CAMA_IPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportIP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(986, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetIP
            // 
            this.DataSetIP.DataSetName = "DataSetIP";
            this.DataSetIP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CAMA_IPBindingSource
            // 
            this.CAMA_IPBindingSource.DataMember = "CAMA_IP";
            this.CAMA_IPBindingSource.DataSource = this.DataSetIP;
            // 
            // CAMA_IPTableAdapter
            // 
            this.CAMA_IPTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 494);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteIP";
            this.Text = "ReporteIP";
            this.Load += new System.EventHandler(this.ReporteIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAMA_IPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CAMA_IPBindingSource;
        private DataSetIP DataSetIP;
        private DataSetIPTableAdapters.CAMA_IPTableAdapter CAMA_IPTableAdapter;
    }
}