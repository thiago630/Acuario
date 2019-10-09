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
    public partial class Paneles : mantenimiento
    {
        public Paneles()
        {
            InitializeComponent();
        }



        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {


                    string cmd = "INSERT INTO paneles VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_id_panel.Text.Trim(), txt_nom_panel.Text.Trim(), txt_modelo_panel.Text.Trim(), txt_marca_panel.Text.Trim(), txt_zonas_panel.Text.Trim(), txt_made_panel.Text.Trim(), txt_detalle_panel.Text.Trim(), txt_stock_panel.Text.Trim(), txt_precio_panel.Text.Trim(), txt_total_panel.Text.Trim(), txt_fecha_panel.Value.ToString());
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
                string cmd = string.Format("DELETE FROM paneles WHERE id_panel ='{0}'", txt_id_panel.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha Eliminado");
                limpiartxt();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
            }
        }
        

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {

        }

        private void errortxtbox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void limpiartxt()
        {
            txt_id_panel.Clear();
            txt_nom_panel.Clear();
            txt_modelo_panel.Clear();
            txt_marca_panel.Clear();
            txt_zonas_panel.Clear();
            txt_made_panel.Clear();
            txt_detalle_panel.Clear();
            txt_stock_panel.Clear();
            txt_precio_panel.Clear();
            txt_total_panel.Clear();
            
        }

        private void txt_id_panel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txt_precio_panel_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txt_stock_panel.Text);
            n2 = Convert.ToInt32(txt_precio_panel.Text);
            r = n1 * n2;
            txt_total_panel.Text = r.ToString();
        }
    }
}
