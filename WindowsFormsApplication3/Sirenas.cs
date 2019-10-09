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
    public partial class Sirenas : mantenimiento
    {
        public Sirenas()
        {
            InitializeComponent();
        }
        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO sirenas VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_id_sirena.Text.Trim(), txt_nom_sirena.Text.Trim(), txt_watts_sirena.Text.Trim(), txt_marca_sirena.Text.Trim(), txt_color_sirena.Text.Trim(), txt_made_sirena.Text.Trim(), txt_detalle_sirena.Text.Trim(), txt_stock_sirena.Text.Trim(), txt_precio_sire.Text.Trim(), txt_total_sire.Text.Trim(), txt_fecha_sirena.Value.ToString());
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
                string cmd = string.Format("DELETE FROM SIRENAS WHERE ID_SIRENAS ='{0}'", txt_id_sirena.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha Eliminado");
                limpiartxt();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
            }
        }

        private void Sirenas_Load(object sender, EventArgs e)
        {

        }
        public void limpiartxt()
        {
            txt_id_sirena.Clear();
            txt_nom_sirena.Clear();
            txt_watts_sirena.Clear();
            txt_marca_sirena.Clear();
            txt_color_sirena.Clear();
            txt_made_sirena.Clear();
            txt_detalle_sirena.Clear();
            txt_stock_sirena.Clear();
            txt_precio_sire.Clear();
            txt_total_sire.Clear();
            
        }

        private void txt_precio_sire_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_sirena.Text);
            n2 = Convert.ToInt32(txt_precio_sire.Text);
            r = n1 * n2;
            txt_total_sire.Text = r.ToString();
        }
    }
}
