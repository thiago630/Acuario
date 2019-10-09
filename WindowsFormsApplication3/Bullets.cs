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
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Bullets : mantenimiento
    {
        public Bullets()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO cama_bullets VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_id_bullets.Text.Trim(), txt_nom_bullets.Text.Trim(), txt_modelo_bullets.Text.Trim(), txt_marca_bullets.Text.Trim(), txt_color_bullets.Text.Trim(), txt_made_bullets.Text.Trim(), txt_detalle_bullets.Text.Trim(), txt_stock_bullets.Text.Trim(), txtprecio1.Text.Trim(),txt_total1.Text.Trim(),txt_fecha_bullets.Value.ToString());
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

                string cmd = string.Format("DELETE FROM cama_bullets WHERE ID_BULLETS ='{0}'", txt_id_bullets.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha Eliminado");
                limpiartxt();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
            }
        }

        private void errortxtbox9_TextChanged(object sender, EventArgs e)
        {

        }

        public void limpiartxt()
        {
            txt_id_bullets.Clear();
            txt_nom_bullets.Clear();
            txt_modelo_bullets.Clear();
            txt_marca_bullets.Clear();
            txt_color_bullets.Clear();
            txt_made_bullets.Clear();
            txt_detalle_bullets.Clear();
            txt_stock_bullets.Clear();
            txtprecio1.Clear();
            txt_total1.Clear();
            
        }

        private void Bullets_Load(object sender, EventArgs e)
        {

        }

        private void txt_precio(object sender, EventArgs e)
        {
           
        }

        private void txt_total(object sender, EventArgs e)
        {

        }

        private void txtprecio1_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_bullets.Text);
            n2 = Convert.ToInt32(txtprecio1.Text);
            r = n1 * n2;
            txt_total1.Text = r.ToString();

        }
    }
}
