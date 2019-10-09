using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mylibreria;

namespace WindowsFormsApplication3
{
    public partial class Teclados : mantenimiento
    {
        public Teclados()
        {
            InitializeComponent();
        }


        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO teclados VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_id_teclado.Text.Trim(), txt_nom_taclado.Text.Trim(), txt_modelo_teclado.Text.Trim(), txt_marca_teclado.Text.Trim(), txt_particiones_teclado.Text.Trim(), txt_made_teclado.Text.Trim(), txt_detalle_teclado.Text.Trim(), txt_stock_teclado.Text.Trim(), txt_precio_tecla.Text.Trim(), txt_total_tecla.Text.Trim(), txt_fecha_teclado.Value.ToString());
                    utilidades.Ejecutar(cmd);

                    MessageBox.Show("Se Guardo Correctamente....");
                    limpiartxt();
                    return true;

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha Ocurrido un error :" + error.Message);
                    return false;

                }


            }
            else
            {
                return false;
            }





        }
        public override void Eliminar()
        {
            try
            {
                /*string cmd = "DELETE FROM sensores WHERE('{0}')";
                cmd = string.Format(cmd, txt_Id_Sen.Text.Trim());*/
                string cmd = string.Format("DELETE FROM teclados WHERE id_tecla ='{0}'", txt_id_teclado.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha Eliminado");
                limpiartxt();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
            }
        }

        private void Teclados_Load(object sender, EventArgs e)
        {

        }

        private void errortxtbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void errortxtbox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void limpiartxt()
        {
            txt_id_teclado.Clear();
            txt_nom_taclado.Clear();
            txt_modelo_teclado.Clear();
            txt_marca_teclado.Clear();
            txt_particiones_teclado.Clear();
            txt_made_teclado.Clear();
            txt_detalle_teclado.Clear();
            txt_stock_teclado.Clear();
            txt_precio_tecla.Clear();
            txt_total_tecla.Clear();
            
        }

        private void txt_precio_tecla_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_teclado.Text);
            n2 = Convert.ToInt32(txt_precio_tecla.Text);
            r = n1 * n2;
            txt_total_tecla.Text = r.ToString();
        }
    }
}
