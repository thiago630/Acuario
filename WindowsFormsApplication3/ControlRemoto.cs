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
    public partial class ControlRemoto : mantenimiento
    {
        public ControlRemoto()
        {
            InitializeComponent();

        }
        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO CONTROL_REMOTO VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_id_control.Text.Trim(), txt_nom_control.Text.Trim(), txt_modelo_control.Text.Trim(), txt_marca_control.Text.Trim(), txt_color_control.Text.Trim(), txt_made_control.Text.Trim(), txt_detalle_control.Text.Trim(), txt_stock_control.Text.Trim(), txt_precio_control_remoto.Text.Trim(), txt_total_control_remoto.Text.Trim(), txt_fecha_control.Value.ToString());
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
             
                string cmd = string.Format("DELETE FROM CONTROL_REMOTO WHERE ID_CONTROL_REMOTO ='{0}'", txt_id_control.Text.Trim());
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
            txt_id_control.Clear();
            txt_nom_control.Clear();
            txt_modelo_control.Clear();
            txt_marca_control.Clear();
            txt_color_control.Clear();
            txt_made_control.Clear();
            txt_detalle_control.Clear();
            txt_stock_control.Clear();
            txt_precio_control_remoto.Clear();
            txt_total_control_remoto.Clear();

       
        }

        private void txt_precio_control_remoto_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_control.Text);
            n2 = Convert.ToInt32(txt_precio_control_remoto.Text);
            r = n1 * n2;
            txt_total_control_remoto.Text = r.ToString();
        }
    }
}
