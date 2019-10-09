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
    public partial class CamaraIP : mantenimiento
    {
        public CamaraIP()
        {
            InitializeComponent();
        }


        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO CAMA_IP VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_id_cip.Text.Trim(), txt_nom_cip.Text.Trim(), txt_modelo_cip.Text.Trim(), txt_marca_cip.Text.Trim(), txt_color_cip.Text.Trim(), txt_made_cip.Text.Trim(), txt_detalle_cip.Text.Trim(), txt_stock_cip.Text.Trim(), txt_precio_IP.Text.Trim(), txt_total_IP.Text.Trim(), txt_fecha_cip.Value.ToString());
                   

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

                string cmd = string.Format("DELETE FROM CAMA_IP WHERE ID_CIP ='{0}'", txt_id_cip.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha Eliminado");
                limpiartxt();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
            }
        }





        public void limpiartxt()
        {
            txt_id_cip.Clear();
            txt_nom_cip.Clear();
            txt_modelo_cip.Clear();
            txt_marca_cip.Clear();
            txt_color_cip.Clear();
            txt_made_cip.Clear();
            txt_detalle_cip.Clear();
            txt_stock_cip.Clear();
            txt_precio_IP.Clear();
            txt_total_IP.Clear();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_precio_IP_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_cip.Text);
            n2 = Convert.ToInt32(txt_precio_IP.Text);
            r = n1 * n2;
            txt_total_IP.Text = r.ToString();
        }
    }
}
