namespace WindowsFormsApplication3
{
    partial class ReporteControlRemoto
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
            this.DataSetControlRemoto = new WindowsFormsApplication3.DataSetControlRemoto();
            this.CONTROL_REMOTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CONTROL_REMOTOTableAdapter = new WindowsFormsApplication3.DataSetControlRemotoTableAdapters.CONTROL_REMOTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetControlRemoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTROL_REMOTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CONTROL_REMOTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportControlRemoto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1070, 618);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetControlRemoto
            // 
            this.DataSetControlRemoto.DataSetName = "DataSetControlRemoto";
            this.DataSetControlRemoto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CONTROL_REMOTOBindingSource
            // 
            this.CONTROL_REMOTOBindingSource.DataMember = "CONTROL_REMOTO";
            this.CONTROL_REMOTOBindingSource.DataSource = this.DataSetControlRemoto;
            // 
            // CONTROL_REMOTOTableAdapter
            // 
            this.CONTROL_REMOTOTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteControlRemoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 618);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteControlRemoto";
            this.Text = "ReporteControlRemoto";
            this.Load += new System.EventHandler(this.ReporteControlRemoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetControlRemoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTROL_REMOTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CONTROL_REMOTOBindingSource;
        private DataSetControlRemoto DataSetControlRemoto;
        private DataSetControlRemotoTableAdapters.CONTROL_REMOTOTableAdapter CONTROL_REMOTOTableAdapter;
    }
}