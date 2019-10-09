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
    public partial class Cables : mantenimiento
    {
        public Cables()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO CABLES_UTP VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')";

                    cmd = string.Format(cmd, txt_id_cable.Text.Trim(), txt_nom_cable.Text.Trim(), txt_modelo_cable.Text.Trim(), txt_marca_cable.Text.Trim(), txt_categoria_cable.Text.Trim(), txt_color_cable.Text.Trim(), txt_made_cable.Text.Trim(), txt_detalle_cable.Text.Trim(), txt_stock_cable.Text.Trim(), txt_precio_cables.Text.Trim(), txt_total_cables.Text.Trim(), txt_fecha_cable.Value.ToString());
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

                string cmd = string.Format("DELETE FROM CABLE_UTP WHERE ID_CABLE ='{0}'", txt_id_cable.Text.Trim());
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
            txt_id_cable.Clear();
            txt_nom_cable.Clear();
            txt_modelo_cable.Clear();
            txt_marca_cable.Clear();
            txt_categoria_cable.Clear();
            txt_color_cable.Clear();
            txt_made_cable.Clear();
            txt_detalle_cable.Clear();
            txt_stock_cable.Clear();
            txt_precio_cables.Clear();
            txt_total_cables.Clear();
            
        }

        private void txt_precio_cables_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_cable.Text);
            n2 = Convert.ToInt32(txt_precio_cables.Text);
            r = n1 * n2;
            txt_total_cables.Text = r.ToString();
        }

    }
}
