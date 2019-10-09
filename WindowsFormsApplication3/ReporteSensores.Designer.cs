namespace WindowsFormsApplication3
{
    partial class ReporteSensores
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
            this.DataSetSensores = new WindowsFormsApplication3.DataSetSensores();
            this.SENSORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SENSORESTableAdapter = new WindowsFormsApplication3.DataSetSensoresTableAdapters.SENSORESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSensores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SENSORESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SENSORESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportSensor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(925, 559);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetSensores
            // 
            this.DataSetSensores.DataSetName = "DataSetSensores";
            this.DataSetSensores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SENSORESBindingSource
            // 
            this.SENSORESBindingSource.DataMember = "SENSORES";
            this.SENSORESBindingSource.DataSource = this.DataSetSensores;
            // 
            // SENSORESTableAdapter
            // 
            this.SENSORESTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteSensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 559);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteSensores";
            this.Text = "ReporteSensores";
            this.Load += new System.EventHandler(this.ReporteSensores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSensores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SENSORESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SENSORESBindingSource;
        private DataSetSensores DataSetSensores;
        private DataSetSensoresTableAdapters.SENSORESTableAdapter SENSORESTableAdapter;
    }
}