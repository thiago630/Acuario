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
    public partial class Domos : mantenimiento
    {
        public Domos()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO CAMA_DOMOS VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_id_domo.Text.Trim(), txt_nom_domo.Text.Trim(), txt_modelo_domo.Text.Trim(), txt_marca_domo.Text.Trim(), txt_color_domo.Text.Trim(), txt_made_domo.Text.Trim(), txt_detalle_domo.Text.Trim(), txt_stock_domo.Text.Trim(), txt_precio_domos.Text.Trim(), txt_total_domos.Text.Trim(), txt_fecha_domo.Value.ToString());
                   
                  
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

                string cmd = string.Format("DELETE FROM CAMA_DOMOS WHERE id_domos ='{0}'", txt_id_domo.Text.Trim());
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
            txt_id_domo.Clear();
            txt_nom_domo.Clear();
            txt_modelo_domo.Clear();
            txt_marca_domo.Clear();
            txt_color_domo.Clear();
            txt_made_domo.Clear();
            txt_detalle_domo.Clear();
            txt_stock_domo.Clear();
            txt_precio_domos.Clear();
            txt_total_domos.Clear();
           
        }

        private void Domos_Load(object sender, EventArgs e)
        {

        }
        private void txterrortxtbox1_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_domo.Text);
            n2 = Convert.ToInt32(txt_precio_domos.Text);
            r = n1 * n2;
            txt_total_domos.Text = r.ToString();

        }
    }
}
