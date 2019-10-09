namespace WindowsFormsApplication3
{
    partial class ReporteProfesional
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
            this.CAMA_PROFESIONALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetProfesional = new WindowsFormsApplication3.DataSetProfesional();
            this.CAMA_PROFESIONALTableAdapter = new WindowsFormsApplication3.DataSetProfesionalTableAdapters.CAMA_PROFESIONALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CAMA_PROFESIONALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CAMA_PROFESIONALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportProfesional.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1166, 580);
            this.reportViewer1.TabIndex = 0;
            // 
            // CAMA_PROFESIONALBindingSource
            // 
            this.CAMA_PROFESIONALBindingSource.DataMember = "CAMA_PROFESIONAL";
            this.CAMA_PROFESIONALBindingSource.DataSource = this.DataSetProfesional;
            // 
            // DataSetProfesional
            // 
            this.DataSetProfesional.DataSetName = "DataSetProfesional";
            this.DataSetProfesional.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CAMA_PROFESIONALTableAdapter
            // 
            this.CAMA_PROFESIONALTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 580);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProfesional";
            this.Text = "ReporteProfesional";
            this.Load += new System.EventHandler(this.ReporteProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CAMA_PROFESIONALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CAMA_PROFESIONALBindingSource;
        private DataSetProfesional DataSetProfesional;
        private DataSetProfesionalTableAdapters.CAMA_PROFESIONALTableAdapter CAMA_PROFESIONALTableAdapter;
    }
}