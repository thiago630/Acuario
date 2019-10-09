namespace WindowsFormsApplication3
{
    partial class ConsultarTeclado
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
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // ConsultarTeclado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 671);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ConsultarTeclado";
            this.Text = "ConsultarTeclado";
            this.Load += new System.EventHandler(this.ConsultarTeclado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}