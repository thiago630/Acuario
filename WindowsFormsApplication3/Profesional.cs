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
    public partial class Profesional : mantenimiento
    {
        public Profesional()
        {
            InitializeComponent();
        }
        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO cama_profesional VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_id_profesional.Text.Trim(), txt_nombre_profesional.Text.Trim(), txt_modelo_profesional.Text.Trim(), txt_marca_profesional.Text.Trim(), txt_color_profesional.Text.Trim(), txt_made_profesional.Text.Trim(), txt_detalle_profesional.Text.Trim(), txt_stock_profesional.Text.Trim(), txt_precio_profes.Text.Trim(), txt_total_profe.Text.Trim(), txt_fecha_profesional.Value.ToString());
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

                string cmd = string.Format("DELETE FROM cama_profesional WHERE ID_PROFESIONAL ='{0}'", txt_id_profesional.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha Eliminado");
                limpiartxt();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
            }
        }

        private void Profesional_Load(object sender, EventArgs e)
        {

        }



        public void limpiartxt()
        {
            txt_id_profesional.Clear();
            txt_nombre_profesional.Clear();
            txt_modelo_profesional.Clear();
            txt_marca_profesional.Clear();
            txt_color_profesional.Clear();
            txt_made_profesional.Clear();
            txt_detalle_profesional.Clear();
            txt_stock_profesional.Clear();
            txt_precio_profes.Clear();
            txt_total_profe.Clear();
            
        }

        private void txt_precio_profes_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_profesional.Text);
            n2 = Convert.ToInt32(txt_precio_profes.Text);
            r = n1 * n2;
            txt_total_profe.Text = r.ToString();
        }
    }
}
