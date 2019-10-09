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
    public partial class Sensores : mantenimiento
    {
        public Sensores()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                   

                    string cmd = "INSERT INTO sensores VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";

                    cmd = string.Format(cmd, txt_Id_Sen.Text.Trim(), txt_Nom_Sen.Text.Trim(), txt_Modelo_Sen.Text.Trim(), txt_Marca_Sen.Text.Trim(), txt_Color_Sen.Text.Trim(), txt_Made_Sen.Text.Trim(), txt_Detalle_Sen.Text.Trim(), txt_Stock_Sen.Text.Trim(), txt_precio_sen.Text.Trim(), txt_total_sen.Text.Trim(), txt_Fecha_Sen.Value.ToString());
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
                string cmd = string.Format("DELETE FROM sensores WHERE id_sensores ='{0}'", txt_Id_Sen.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha Eliminado");
                limpiartxt();
            
            
            }
            catch(Exception  error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
            }
        }

       





        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {

        }

      private void label1_Click(object sender, EventArgs e)
        {

        }

      private void txt_Fecha_Sen_TextChanged(object sender, EventArgs e)
      {

      }

      private void txt_Id_Sen_TextChanged(object sender, EventArgs e)
      {
          errorProvider1.Clear();
      }

      private void txt_Nom_Sen_TextChanged(object sender, EventArgs e)
      {
         
      }

      public void limpiartxt()
      {
          txt_Id_Sen.Clear();
          txt_Nom_Sen.Clear();
          txt_Modelo_Sen.Clear();
          txt_Marca_Sen.Clear();
          txt_Color_Sen.Clear();
          txt_Made_Sen.Clear();
          txt_Detalle_Sen.Clear();
          txt_Stock_Sen.Clear();
          txt_precio_sen.Clear();
          txt_total_sen.Clear();
         
      }

      private void btnConsultar_Click(object sender, EventArgs e)
      {
          
      }

      private void txt_precio_sen_Leave(object sender, EventArgs e)
      {
          int n1, n2, r;
          n1 = Convert.ToInt32(txt_Stock_Sen.Text);
          n2 = Convert.ToInt32(txt_precio_sen.Text);
         
          r = n1 * n2;
          txt_total_sen.Text = r.ToString();
      }
    }
    

}
