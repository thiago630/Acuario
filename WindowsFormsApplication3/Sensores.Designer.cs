namespace WindowsFormsApplication3
{
    partial class Sensores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Stock_Sen = new Mylibreria.errortxtbox();
            this.txt_Detalle_Sen = new Mylibreria.errortxtbox();
            this.txt_Made_Sen = new Mylibreria.errortxtbox();
            this.txt_Color_Sen = new Mylibreria.errortxtbox();
            this.txt_Marca_Sen = new Mylibreria.errortxtbox();
            this.txt_Modelo_Sen = new Mylibreria.errortxtbox();
            this.txt_Nom_Sen = new Mylibreria.errortxtbox();
            this.txt_Id_Sen = new Mylibreria.errortxtbox();
            this.txt_Fecha_Sen = new System.Windows.Forms.DateTimePicker();
            this.txt_precio_sen = new Mylibreria.errortxtbox();
            this.txt_total_sen = new Mylibreria.errortxtbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Sensor :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre Sensor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Modelo Sensor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Marca Sensor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Color Sensor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Made in Sensor  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Detalle Sensor :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(122, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Stock :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha :";
            // 
            // txt_Stock_Sen
            // 
            this.txt_Stock_Sen.Location = new System.Drawing.Point(209, 266);
            this.txt_Stock_Sen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Stock_Sen.Name = "txt_Stock_Sen";
            this.txt_Stock_Sen.Size = new System.Drawing.Size(196, 22);
            this.txt_Stock_Sen.SoloNumeros = true;
            this.txt_Stock_Sen.TabIndex = 30;
            this.txt_Stock_Sen.Validar = true;
            // 
            // txt_Detalle_Sen
            // 
            this.txt_Detalle_Sen.Location = new System.Drawing.Point(209, 234);
            this.txt_Detalle_Sen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Detalle_Sen.Name = "txt_Detalle_Sen";
            this.txt_Detalle_Sen.Size = new System.Drawing.Size(196, 22);
            this.txt_Detalle_Sen.SoloNumeros = false;
            this.txt_Detalle_Sen.TabIndex = 29;
            this.txt_Detalle_Sen.Validar = true;
            // 
            // txt_Made_Sen
            // 
            this.txt_Made_Sen.Location = new System.Drawing.Point(209, 202);
            this.txt_Made_Sen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Made_Sen.Name = "txt_Made_Sen";
            this.txt_Made_Sen.Size = new System.Drawing.Size(196, 22);
            this.txt_Made_Sen.SoloNumeros = false;
            this.txt_Made_Sen.TabIndex = 28;
            this.txt_Made_Sen.Validar = true;
            // 
            // txt_Color_Sen
            // 
            this.txt_Color_Sen.Location = new System.Drawing.Point(209, 170);
            this.txt_Color_Sen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Color_Sen.Name = "txt_Color_Sen";
            this.txt_Color_Sen.Size = new System.Drawing.Size(196, 22);
            this.txt_Color_Sen.SoloNumeros = false;
            this.txt_Color_Sen.TabIndex = 27;
            this.txt_Color_Sen.Validar = true;
            // 
            // txt_Marca_Sen
            // 
            this.txt_Marca_Sen.Location = new System.Drawing.Point(209, 138);
            this.txt_Marca_Sen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Marca_Sen.Name = "txt_Marca_Sen";
            this.txt_Marca_Sen.Size = new System.Drawing.Size(196, 22);
            this.txt_Marca_Sen.SoloNumeros = false;
            this.txt_Marca_Sen.TabIndex = 26;
            this.txt_Marca_Sen.Validar = true;
            // 
            // txt_Modelo_Sen
            // 
            this.txt_Modelo_Sen.Location = new System.Drawing.Point(209, 106);
            this.txt_Modelo_Sen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Modelo_Sen.Name = "txt_Modelo_Sen";
            this.txt_Modelo_Sen.Size = new System.Drawing.Size(196, 22);
            this.txt_Modelo_Sen.SoloNumeros = false;
            this.txt_Modelo_Sen.TabIndex = 25;
            this.txt_Modelo_Sen.Validar = true;
            // 
            // txt_Nom_Sen
            // 
            this.txt_Nom_Sen.Location = new System.Drawing.Point(209, 74);
            this.txt_Nom_Sen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nom_Sen.Name = "txt_Nom_Sen";
            this.txt_Nom_Sen.Size = new System.Drawing.Size(196, 22);
            this.txt_Nom_Sen.SoloNumeros = false;
            this.txt_Nom_Sen.TabIndex = 24;
            this.txt_Nom_Sen.Validar = true;
            this.txt_Nom_Sen.TextChanged += new System.EventHandler(this.txt_Nom_Sen_TextChanged);
            // 
            // txt_Id_Sen
            // 
            this.txt_Id_Sen.Location = new System.Drawing.Point(209, 39);
            this.txt_Id_Sen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id_Sen.Name = "txt_Id_Sen";
            this.txt_Id_Sen.Size = new System.Drawing.Size(196, 22);
            this.txt_Id_Sen.SoloNumeros = true;
            this.txt_Id_Sen.TabIndex = 23;
            this.txt_Id_Sen.Validar = true;
            this.txt_Id_Sen.TextChanged += new System.EventHandler(this.txt_Id_Sen_TextChanged);
            // 
            // txt_Fecha_Sen
            // 
            this.txt_Fecha_Sen.Location = new System.Drawing.Point(209, 356);
            this.txt_Fecha_Sen.Name = "txt_Fecha_Sen";
            this.txt_Fecha_Sen.Size = new System.Drawing.Size(244, 22);
            this.txt_Fecha_Sen.TabIndex = 33;
            // 
            // txt_precio_sen
            // 
            this.txt_precio_sen.Location = new System.Drawing.Point(209, 295);
            this.txt_precio_sen.Name = "txt_precio_sen";
            this.txt_precio_sen.Size = new System.Drawing.Size(196, 22);
            this.txt_precio_sen.SoloNumeros = false;
            this.txt_precio_sen.TabIndex = 31;
            this.txt_precio_sen.Validar = false;
            this.txt_precio_sen.Leave += new System.EventHandler(this.txt_precio_sen_Leave);
            // 
            // txt_total_sen
            // 
            this.txt_total_sen.Location = new System.Drawing.Point(209, 323);
            this.txt_total_sen.Name = "txt_total_sen";
            this.txt_total_sen.Size = new System.Drawing.Size(196, 22);
            this.txt_total_sen.SoloNumeros = false;
            this.txt_total_sen.TabIndex = 32;
            this.txt_total_sen.Validar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 295);
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
            this.label11.Location = new System.Drawing.Point(122, 323);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total :";
            // 
            // Sensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 390);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_total_sen);
            this.Controls.Add(this.txt_precio_sen);
            this.Controls.Add(this.txt_Fecha_Sen);
            this.Controls.Add(this.txt_Stock_Sen);
            this.Controls.Add(this.txt_Detalle_Sen);
            this.Controls.Add(this.txt_Made_Sen);
            this.Controls.Add(this.txt_Color_Sen);
            this.Controls.Add(this.txt_Marca_Sen);
            this.Controls.Add(this.txt_Modelo_Sen);
            this.Controls.Add(this.txt_Nom_Sen);
            this.Controls.Add(this.txt_Id_Sen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Sensores";
            this.Text = "Sensores";
            this.Load += new System.EventHandler(this.MantenimientoProducto_Load);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txt_Id_Sen, 0);
            this.Controls.SetChildIndex(this.txt_Nom_Sen, 0);
            this.Controls.SetChildIndex(this.txt_Modelo_Sen, 0);
            this.Controls.SetChildIndex(this.txt_Marca_Sen, 0);
            this.Controls.SetChildIndex(this.txt_Color_Sen, 0);
            this.Controls.SetChildIndex(this.txt_Made_Sen, 0);
            this.Controls.SetChildIndex(this.txt_Detalle_Sen, 0);
            this.Controls.SetChildIndex(this.txt_Stock_Sen, 0);
            this.Controls.SetChildIndex(this.txt_Fecha_Sen, 0);
            this.Controls.SetChildIndex(this.txt_precio_sen, 0);
            this.Controls.SetChildIndex(this.txt_total_sen, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Mylibreria.errortxtbox txt_Id_Sen;
        private Mylibreria.errortxtbox txt_Nom_Sen;
        private Mylibreria.errortxtbox txt_Modelo_Sen;
        private Mylibreria.errortxtbox txt_Marca_Sen;
        private Mylibreria.errortxtbox txt_Color_Sen;
        private Mylibreria.errortxtbox txt_Made_Sen;
        private Mylibreria.errortxtbox txt_Detalle_Sen;
        private Mylibreria.errortxtbox txt_Stock_Sen;
        private System.Windows.Forms.DateTimePicker txt_Fecha_Sen;
        private Mylibreria.errortxtbox txt_precio_sen;
        private Mylibreria.errortxtbox txt_total_sen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}