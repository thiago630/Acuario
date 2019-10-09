namespace WindowsFormsApplication3
{
    partial class ReportePaneles
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
            this.DataSetPaneles = new WindowsFormsApplication3.DataSetPaneles();
            this.PANELESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PANELESTableAdapter = new WindowsFormsApplication3.DataSetPanelesTableAdapters.PANELESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPaneles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PANELESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PANELESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportPanel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(654, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetPaneles
            // 
            this.DataSetPaneles.DataSetName = "DataSetPaneles";
            this.DataSetPaneles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PANELESBindingSource
            // 
            this.PANELESBindingSource.DataMember = "PANELES";
            this.PANELESBindingSource.DataSource = this.DataSetPaneles;
            // 
            // PANELESTableAdapter
            // 
            this.PANELESTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePaneles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 532);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePaneles";
            this.Text = "ReportePaneles";
            this.Load += new System.EventHandler(this.ReportePaneles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPaneles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PANELESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PANELESBindingSource;
        private DataSetPaneles DataSetPaneles;
        private DataSetPanelesTableAdapters.PANELESTableAdapter PANELESTableAdapter;
    }
}