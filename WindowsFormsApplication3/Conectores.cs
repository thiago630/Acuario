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
    public partial class Conectores : mantenimiento
    {
        public Conectores()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO CONECTORES VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')";

                    cmd = string.Format(cmd, txt_id_conectores.Text.Trim(), txt_nom_conectores.Text.Trim(), txt_mode_conectores.Text.Trim(), txt_marca_conectores.Text.Trim(), txt_made_conectores.Text.Trim(), txt_detalle_conectores.Text.Trim(), txt_stock_conectores.Text.Trim(), txt_precio_conec.Text.Trim(), txt_total_conec.Text.Trim(), txt_fecha_conectores.Value.ToString());


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

                string cmd = string.Format("DELETE FROM CONECTORES WHERE ID_CONECT ='{0}'", txt_id_conectores.Text.Trim());
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
            txt_id_conectores.Clear();
            txt_nom_conectores.Clear();
            txt_mode_conectores.Clear();
            txt_marca_conectores.Clear();
            txt_made_conectores.Clear();
            txt_detalle_conectores.Clear();
            txt_stock_conectores.Clear();
            txt_precio_conec.Clear();
            txt_total_conec.Clear();
           

        }

        private void txt_precio_conec_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_conectores.Text);
            n2 = Convert.ToInt32(txt_precio_conec.Text);
            r = n1 * n2;
            txt_total_conec.Text = r.ToString();
        }
    }
}
