namespace WindowsFormsApplication3
{
    partial class ReporteBullets
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
            this.CAMA_BULLETSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBullets = new WindowsFormsApplication3.DataSetBullets();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CAMA_BULLETSTableAdapter = new WindowsFormsApplication3.DataSetBulletsTableAdapters.CAMA_BULLETSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblatiende = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CAMA_BULLETSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBullets)).BeginInit();
            this.SuspendLayout();
            // 
            // CAMA_BULLETSBindingSource
            // 
            this.CAMA_BULLETSBindingSource.DataMember = "CAMA_BULLETS";
            this.CAMA_BULLETSBindingSource.DataSource = this.DataSetBullets;
            // 
            // DataSetBullets
            // 
            this.DataSetBullets.DataSetName = "DataSetBullets";
            this.DataSetBullets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CAMA_BULLETSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportBullets.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1293, 609);
            this.reportViewer1.TabIndex = 0;
            // 
            // CAMA_BULLETSTableAdapter
            // 
            this.CAMA_BULLETSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lo Atiende:";
            // 
            // lblatiende
            // 
            this.lblatiende.BackColor = System.Drawing.SystemColors.Control;
            this.lblatiende.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblatiende.Location = new System.Drawing.Point(98, 56);
            this.lblatiende.Name = "lblatiende";
            this.lblatiende.Size = new System.Drawing.Size(127, 26);
            this.lblatiende.TabIndex = 2;
            // 
            // ReporteBullets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 609);
            this.Controls.Add(this.lblatiende);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteBullets";
            this.Text = "ReporteBullets";
            this.Load += new System.EventHandler(this.ReporteBullets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CAMA_BULLETSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBullets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CAMA_BULLETSBindingSource;
        private DataSetBullets DataSetBullets;
        private DataSetBulletsTableAdapters.CAMA_BULLETSTableAdapter CAMA_BULLETSTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblatiende;
    }
}