namespace WindowsFormsApplication3
{
    partial class reporteDomo
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
            this.DataSetDomo = new WindowsFormsApplication3.DataSetDomo();
            this.CAMA_DOMOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CAMA_DOMOSTableAdapter = new WindowsFormsApplication3.DataSetDomoTableAdapters.CAMA_DOMOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDomo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAMA_DOMOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CAMA_DOMOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportDomo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1058, 547);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetDomo
            // 
            this.DataSetDomo.DataSetName = "DataSetDomo";
            this.DataSetDomo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CAMA_DOMOSBindingSource
            // 
            this.CAMA_DOMOSBindingSource.DataMember = "CAMA_DOMOS";
            this.CAMA_DOMOSBindingSource.DataSource = this.DataSetDomo;
            // 
            // CAMA_DOMOSTableAdapter
            // 
            this.CAMA_DOMOSTableAdapter.ClearBeforeFill = true;
            // 
            // reporteDomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 547);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteDomo";
            this.Text = "reporteDomo";
            this.Load += new System.EventHandler(this.reporteDomo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDomo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAMA_DOMOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CAMA_DOMOSBindingSource;
        private DataSetDomo DataSetDomo;
        private DataSetDomoTableAdapters.CAMA_DOMOSTableAdapter CAMA_DOMOSTableAdapter;
    }
}