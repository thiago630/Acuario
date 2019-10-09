namespace WindowsFormsApplication3
{
    partial class ReperteCables
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
            this.DataSetCables = new WindowsFormsApplication3.DataSetCables();
            this.CABLES_UTPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CABLES_UTPTableAdapter = new WindowsFormsApplication3.DataSetCablesTableAdapters.CABLES_UTPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CABLES_UTPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CABLES_UTPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportCable.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1105, 598);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetCables
            // 
            this.DataSetCables.DataSetName = "DataSetCables";
            this.DataSetCables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CABLES_UTPBindingSource
            // 
            this.CABLES_UTPBindingSource.DataMember = "CABLES_UTP";
            this.CABLES_UTPBindingSource.DataSource = this.DataSetCables;
            // 
            // CABLES_UTPTableAdapter
            // 
            this.CABLES_UTPTableAdapter.ClearBeforeFill = true;
            // 
            // ReperteCables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 598);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReperteCables";
            this.Text = "ReperteCables";
            this.Load += new System.EventHandler(this.ReperteCables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CABLES_UTPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CABLES_UTPBindingSource;
        private DataSetCables DataSetCables;
        private DataSetCablesTableAdapters.CABLES_UTPTableAdapter CABLES_UTPTableAdapter;
    }
}