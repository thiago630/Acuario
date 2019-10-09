namespace WindowsFormsApplication3
{
    partial class Paneles
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
            this.txt_id_panel = new Mylibreria.errortxtbox();
            this.txt_nom_panel = new Mylibreria.errortxtbox();
            this.txt_modelo_panel = new Mylibreria.errortxtbox();
            this.txt_marca_panel = new Mylibreria.errortxtbox();
            this.txt_zonas_panel = new Mylibreria.errortxtbox();
            this.txt_made_panel = new Mylibreria.errortxtbox();
            this.txt_detalle_panel = new Mylibreria.errortxtbox();
            this.txt_stock_panel = new Mylibreria.errortxtbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha_panel = new System.Windows.Forms.DateTimePicker();
            this.txt_precio_panel = new Mylibreria.errortxtbox();
            this.txt_total_panel = new Mylibreria.errortxtbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(456, 54);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_id_panel
            // 
            this.txt_id_panel.Location = new System.Drawing.Point(234, 30);
            this.txt_id_panel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_panel.Name = "txt_id_panel";
            this.txt_id_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_id_panel.SoloNumeros = true;
            this.txt_id_panel.TabIndex = 5;
            this.txt_id_panel.Validar = true;
            this.txt_id_panel.TextChanged += new System.EventHandler(this.txt_id_panel_TextChanged);
            // 
            // txt_nom_panel
            // 
            this.txt_nom_panel.Location = new System.Drawing.Point(234, 63);
            this.txt_nom_panel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom_panel.Name = "txt_nom_panel";
            this.txt_nom_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_nom_panel.SoloNumeros = false;
            this.txt_nom_panel.TabIndex = 6;
            this.txt_nom_panel.Validar = true;
            // 
            // txt_modelo_panel
            // 
            this.txt_modelo_panel.Location = new System.Drawing.Point(234, 95);
            this.txt_modelo_panel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_modelo_panel.Name = "txt_modelo_panel";
            this.txt_modelo_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_modelo_panel.SoloNumeros = false;
            this.txt_modelo_panel.TabIndex = 7;
            this.txt_modelo_panel.Validar = true;
            this.txt_modelo_panel.TextChanged += new System.EventHandler(this.errortxtbox3_TextChanged);
            // 
            // txt_marca_panel
            // 
            this.txt_marca_panel.Location = new System.Drawing.Point(234, 127);
            this.txt_marca_panel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_marca_panel.Name = "txt_marca_panel";
            this.txt_marca_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_marca_panel.SoloNumeros = false;
            this.txt_marca_panel.TabIndex = 8;
            this.txt_marca_panel.Validar = true;
            // 
            // txt_zonas_panel
            // 
            this.txt_zonas_panel.Location = new System.Drawing.Point(234, 161);
            this.txt_zonas_panel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_zonas_panel.Name = "txt_zonas_panel";
            this.txt_zonas_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_zonas_panel.SoloNumeros = true;
            this.txt_zonas_panel.TabIndex = 9;
            this.txt_zonas_panel.Validar = true;
            // 
            // txt_made_panel
            // 
            this.txt_made_panel.Location = new System.Drawing.Point(234, 193);
            this.txt_made_panel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_made_panel.Name = "txt_made_panel";
            this.txt_made_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_made_panel.SoloNumeros = false;
            this.txt_made_panel.TabIndex = 10;
            this.txt_made_panel.Validar = true;
            // 
            // txt_detalle_panel
            // 
            this.txt_detalle_panel.Location = new System.Drawing.Point(234, 225);
            this.txt_detalle_panel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_detalle_panel.Name = "txt_detalle_panel";
            this.txt_detalle_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_detalle_panel.SoloNumeros = false;
            this.txt_detalle_panel.TabIndex = 11;
            this.txt_detalle_panel.Validar = true;
            // 
            // txt_stock_panel
            // 
            this.txt_stock_panel.Location = new System.Drawing.Point(234, 257);
            this.txt_stock_panel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock_panel.Name = "txt_stock_panel";
            this.txt_stock_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_stock_panel.SoloNumeros = true;
            this.txt_stock_panel.TabIndex = 12;
            this.txt_stock_panel.Validar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Stock :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Detalle Panel :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Made in Panel  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Zonas Panel :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Marca Panel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Modelo Panel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre Panel :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id Panel :";
            // 
            // txt_fecha_panel
            // 
            this.txt_fecha_panel.Location = new System.Drawing.Point(197, 342);
            this.txt_fecha_panel.Name = "txt_fecha_panel";
            this.txt_fecha_panel.Size = new System.Drawing.Size(246, 22);
            this.txt_fecha_panel.TabIndex = 15;
            // 
            // txt_precio_panel
            // 
            this.txt_precio_panel.Location = new System.Drawing.Point(234, 286);
            this.txt_precio_panel.Name = "txt_precio_panel";
            this.txt_precio_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_precio_panel.SoloNumeros = false;
            this.txt_precio_panel.TabIndex = 13;
            this.txt_precio_panel.Validar = false;
            this.txt_precio_panel.Leave += new System.EventHandler(this.txt_precio_panel_Leave);
            // 
            // txt_total_panel
            // 
            this.txt_total_panel.Location = new System.Drawing.Point(234, 314);
            this.txt_total_panel.Name = "txt_total_panel";
            this.txt_total_panel.Size = new System.Drawing.Size(175, 22);
            this.txt_total_panel.SoloNumeros = false;
            this.txt_total_panel.TabIndex = 14;
            this.txt_total_panel.Validar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(138, 286);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Precio :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(137, 314);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total :";
            // 
            // Paneles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 405);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_total_panel);
            this.Controls.Add(this.txt_precio_panel);
            this.Controls.Add(this.txt_fecha_panel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_stock_panel);
            this.Controls.Add(this.txt_detalle_panel);
            this.Controls.Add(this.txt_made_panel);
            this.Controls.Add(this.txt_zonas_panel);
            this.Controls.Add(this.txt_marca_panel);
            this.Controls.Add(this.txt_modelo_panel);
            this.Controls.Add(this.txt_nom_panel);
            this.Controls.Add(this.txt_id_panel);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Paneles";
            this.Text = "Paneles";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.txt_id_panel, 0);
            this.Controls.SetChildIndex(this.txt_nom_panel, 0);
            this.Controls.SetChildIndex(this.txt_modelo_panel, 0);
            this.Controls.SetChildIndex(this.txt_marca_panel, 0);
            this.Controls.SetChildIndex(this.txt_zonas_panel, 0);
            this.Controls.SetChildIndex(this.txt_made_panel, 0);
            this.Controls.SetChildIndex(this.txt_detalle_panel, 0);
            this.Controls.SetChildIndex(this.txt_stock_panel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txt_fecha_panel, 0);
            this.Controls.SetChildIndex(this.txt_precio_panel, 0);
            this.Controls.SetChildIndex(this.txt_total_panel, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mylibreria.errortxtbox txt_id_panel;
        private Mylibreria.errortxtbox txt_nom_panel;
        private Mylibreria.errortxtbox txt_modelo_panel;
        private Mylibreria.errortxtbox txt_marca_panel;
        private Mylibreria.errortxtbox txt_zonas_panel;
        private Mylibreria.errortxtbox txt_made_panel;
        private Mylibreria.errortxtbox txt_detalle_panel;
        private Mylibreria.errortxtbox txt_stock_panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_fecha_panel;
        private Mylibreria.errortxtbox txt_precio_panel;
        private Mylibreria.errortxtbox txt_total_panel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}