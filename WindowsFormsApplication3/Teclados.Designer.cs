namespace WindowsFormsApplication3
{
    partial class Teclados
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
            this.txt_id_teclado = new Mylibreria.errortxtbox();
            this.txt_nom_taclado = new Mylibreria.errortxtbox();
            this.txt_modelo_teclado = new Mylibreria.errortxtbox();
            this.txt_marca_teclado = new Mylibreria.errortxtbox();
            this.txt_particiones_teclado = new Mylibreria.errortxtbox();
            this.txt_made_teclado = new Mylibreria.errortxtbox();
            this.txt_detalle_teclado = new Mylibreria.errortxtbox();
            this.txt_stock_teclado = new Mylibreria.errortxtbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha_teclado = new System.Windows.Forms.DateTimePicker();
            this.txt_precio_tecla = new Mylibreria.errortxtbox();
            this.txt_total_tecla = new Mylibreria.errortxtbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_teclado
            // 
            this.txt_id_teclado.Location = new System.Drawing.Point(237, 55);
            this.txt_id_teclado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_teclado.Name = "txt_id_teclado";
            this.txt_id_teclado.Size = new System.Drawing.Size(188, 22);
            this.txt_id_teclado.SoloNumeros = true;
            this.txt_id_teclado.TabIndex = 5;
            this.txt_id_teclado.Validar = true;
            // 
            // txt_nom_taclado
            // 
            this.txt_nom_taclado.Location = new System.Drawing.Point(237, 87);
            this.txt_nom_taclado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom_taclado.Name = "txt_nom_taclado";
            this.txt_nom_taclado.Size = new System.Drawing.Size(188, 22);
            this.txt_nom_taclado.SoloNumeros = false;
            this.txt_nom_taclado.TabIndex = 6;
            this.txt_nom_taclado.Validar = true;
            // 
            // txt_modelo_teclado
            // 
            this.txt_modelo_teclado.Location = new System.Drawing.Point(237, 119);
            this.txt_modelo_teclado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_modelo_teclado.Name = "txt_modelo_teclado";
            this.txt_modelo_teclado.Size = new System.Drawing.Size(188, 22);
            this.txt_modelo_teclado.SoloNumeros = false;
            this.txt_modelo_teclado.TabIndex = 7;
            this.txt_modelo_teclado.Validar = true;
            // 
            // txt_marca_teclado
            // 
            this.txt_marca_teclado.Location = new System.Drawing.Point(237, 151);
            this.txt_marca_teclado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_marca_teclado.Name = "txt_marca_teclado";
            this.txt_marca_teclado.Size = new System.Drawing.Size(188, 22);
            this.txt_marca_teclado.SoloNumeros = false;
            this.txt_marca_teclado.TabIndex = 8;
            this.txt_marca_teclado.Validar = true;
            this.txt_marca_teclado.TextChanged += new System.EventHandler(this.errortxtbox4_TextChanged);
            // 
            // txt_particiones_teclado
            // 
            this.txt_particiones_teclado.Location = new System.Drawing.Point(237, 183);
            this.txt_particiones_teclado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_particiones_teclado.Name = "txt_particiones_teclado";
            this.txt_particiones_teclado.Size = new System.Drawing.Size(188, 22);
            this.txt_particiones_teclado.SoloNumeros = false;
            this.txt_particiones_teclado.TabIndex = 9;
            this.txt_particiones_teclado.Validar = true;
            this.txt_particiones_teclado.TextChanged += new System.EventHandler(this.errortxtbox5_TextChanged);
            // 
            // txt_made_teclado
            // 
            this.txt_made_teclado.Location = new System.Drawing.Point(237, 215);
            this.txt_made_teclado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_made_teclado.Name = "txt_made_teclado";
            this.txt_made_teclado.Size = new System.Drawing.Size(188, 22);
            this.txt_made_teclado.SoloNumeros = false;
            this.txt_made_teclado.TabIndex = 10;
            this.txt_made_teclado.Validar = true;
            // 
            // txt_detalle_teclado
            // 
            this.txt_detalle_teclado.Location = new System.Drawing.Point(237, 247);
            this.txt_detalle_teclado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_detalle_teclado.Name = "txt_detalle_teclado";
            this.txt_detalle_teclado.Size = new System.Drawing.Size(188, 22);
            this.txt_detalle_teclado.SoloNumeros = false;
            this.txt_detalle_teclado.TabIndex = 11;
            this.txt_detalle_teclado.Validar = true;
            // 
            // txt_stock_teclado
            // 
            this.txt_stock_teclado.Location = new System.Drawing.Point(237, 279);
            this.txt_stock_teclado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock_teclado.Name = "txt_stock_teclado";
            this.txt_stock_teclado.Size = new System.Drawing.Size(188, 22);
            this.txt_stock_teclado.SoloNumeros = true;
            this.txt_stock_teclado.TabIndex = 12;
            this.txt_stock_teclado.Validar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 370);
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
            this.label8.Location = new System.Drawing.Point(136, 279);
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
            this.label7.Location = new System.Drawing.Point(51, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Detalle Teclado :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Made in Teclado :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Particiones Teclado :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Marca Teclado :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Modelo Teclado :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre Teclado :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id Teclado :";
            // 
            // txt_fecha_teclado
            // 
            this.txt_fecha_teclado.Location = new System.Drawing.Point(210, 370);
            this.txt_fecha_teclado.Name = "txt_fecha_teclado";
            this.txt_fecha_teclado.Size = new System.Drawing.Size(244, 22);
            this.txt_fecha_teclado.TabIndex = 15;
            // 
            // txt_precio_tecla
            // 
            this.txt_precio_tecla.Location = new System.Drawing.Point(237, 308);
            this.txt_precio_tecla.Name = "txt_precio_tecla";
            this.txt_precio_tecla.Size = new System.Drawing.Size(188, 22);
            this.txt_precio_tecla.SoloNumeros = false;
            this.txt_precio_tecla.TabIndex = 13;
            this.txt_precio_tecla.Validar = false;
            this.txt_precio_tecla.Leave += new System.EventHandler(this.txt_precio_tecla_Leave);
            // 
            // txt_total_tecla
            // 
            this.txt_total_tecla.Location = new System.Drawing.Point(237, 336);
            this.txt_total_tecla.Name = "txt_total_tecla";
            this.txt_total_tecla.Size = new System.Drawing.Size(188, 22);
            this.txt_total_tecla.SoloNumeros = false;
            this.txt_total_tecla.TabIndex = 14;
            this.txt_total_tecla.Validar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(137, 310);
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
            this.label11.Location = new System.Drawing.Point(137, 338);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total :";
            // 
            // Teclados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 404);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_total_tecla);
            this.Controls.Add(this.txt_precio_tecla);
            this.Controls.Add(this.txt_fecha_teclado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_stock_teclado);
            this.Controls.Add(this.txt_detalle_teclado);
            this.Controls.Add(this.txt_made_teclado);
            this.Controls.Add(this.txt_particiones_teclado);
            this.Controls.Add(this.txt_marca_teclado);
            this.Controls.Add(this.txt_modelo_teclado);
            this.Controls.Add(this.txt_nom_taclado);
            this.Controls.Add(this.txt_id_teclado);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Teclados";
            this.Text = "Teclados";
            this.Load += new System.EventHandler(this.Teclados_Load);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.txt_id_teclado, 0);
            this.Controls.SetChildIndex(this.txt_nom_taclado, 0);
            this.Controls.SetChildIndex(this.txt_modelo_teclado, 0);
            this.Controls.SetChildIndex(this.txt_marca_teclado, 0);
            this.Controls.SetChildIndex(this.txt_particiones_teclado, 0);
            this.Controls.SetChildIndex(this.txt_made_teclado, 0);
            this.Controls.SetChildIndex(this.txt_detalle_teclado, 0);
            this.Controls.SetChildIndex(this.txt_stock_teclado, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txt_fecha_teclado, 0);
            this.Controls.SetChildIndex(this.txt_precio_tecla, 0);
            this.Controls.SetChildIndex(this.txt_total_tecla, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mylibreria.errortxtbox txt_id_teclado;
        private Mylibreria.errortxtbox txt_nom_taclado;
        private Mylibreria.errortxtbox txt_modelo_teclado;
        private Mylibreria.errortxtbox txt_marca_teclado;
        private Mylibreria.errortxtbox txt_particiones_teclado;
        private Mylibreria.errortxtbox txt_made_teclado;
        private Mylibreria.errortxtbox txt_detalle_teclado;
        private Mylibreria.errortxtbox txt_stock_teclado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_fecha_teclado;
        private Mylibreria.errortxtbox txt_precio_tecla;
        private Mylibreria.errortxtbox txt_total_tecla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}