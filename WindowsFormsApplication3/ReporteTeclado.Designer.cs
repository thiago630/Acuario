namespace WindowsFormsApplication3
{
    partial class ReporteTeclado
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
            this.DataSetTeclado = new WindowsFormsApplication3.DataSetTeclado();
            this.TECLADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TECLADOSTableAdapter = new WindowsFormsApplication3.DataSetTecladoTableAdapters.TECLADOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTeclado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECLADOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TECLADOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportTeclado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetTeclado
            // 
            this.DataSetTeclado.DataSetName = "DataSetTeclado";
            this.DataSetTeclado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TECLADOSBindingSource
            // 
            this.TECLADOSBindingSource.DataMember = "TECLADOS";
            this.TECLADOSBindingSource.DataSource = this.DataSetTeclado;
            // 
            // TECLADOSTableAdapter
            // 
            this.TECLADOSTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteTeclado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 467);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteTeclado";
            this.Text = "ReporteTeclado";
            this.Load += new System.EventHandler(this.ReporteTeclado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTeclado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECLADOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TECLADOSBindingSource;
        private DataSetTeclado DataSetTeclado;
        private DataSetTecladoTableAdapters.TECLADOSTableAdapter TECLADOSTableAdapter;
    }
}