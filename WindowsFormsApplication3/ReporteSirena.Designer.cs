namespace WindowsFormsApplication3
{
    partial class ReporteSirena
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
            this.DataSetSirena = new WindowsFormsApplication3.DataSetSirena();
            this.SIRENASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SIRENASTableAdapter = new WindowsFormsApplication3.DataSetSirenaTableAdapters.SIRENASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSirena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIRENASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SIRENASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportSirena.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1185, 588);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetSirena
            // 
            this.DataSetSirena.DataSetName = "DataSetSirena";
            this.DataSetSirena.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SIRENASBindingSource
            // 
            this.SIRENASBindingSource.DataMember = "SIRENAS";
            this.SIRENASBindingSource.DataSource = this.DataSetSirena;
            // 
            // SIRENASTableAdapter
            // 
            this.SIRENASTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteSirena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 588);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteSirena";
            this.Text = "ReporteSirena";
            this.Load += new System.EventHandler(this.ReporteSirena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSirena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIRENASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SIRENASBindingSource;
        private DataSetSirena DataSetSirena;
        private DataSetSirenaTableAdapters.SIRENASTableAdapter SIRENASTableAdapter;
    }
}