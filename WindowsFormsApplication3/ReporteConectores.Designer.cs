namespace WindowsFormsApplication3
{
    partial class ReporteConectores
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
            this.DataSetConectores = new WindowsFormsApplication3.DataSetConectores();
            this.CONECTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CONECTORESTableAdapter = new WindowsFormsApplication3.DataSetConectoresTableAdapters.CONECTORESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetConectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONECTORESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CONECTORESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportConectores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1074, 592);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetConectores
            // 
            this.DataSetConectores.DataSetName = "DataSetConectores";
            this.DataSetConectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CONECTORESBindingSource
            // 
            this.CONECTORESBindingSource.DataMember = "CONECTORES";
            this.CONECTORESBindingSource.DataSource = this.DataSetConectores;
            // 
            // CONECTORESTableAdapter
            // 
            this.CONECTORESTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteConectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 592);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteConectores";
            this.Text = "ReporteConectores";
            this.Load += new System.EventHandler(this.ReporteConectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetConectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONECTORESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CONECTORESBindingSource;
        private DataSetConectores DataSetConectores;
        private DataSetConectoresTableAdapters.CONECTORESTableAdapter CONECTORESTableAdapter;
    }
}