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
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
    public partial class ConsultarBullets : Consultas
    {
        /*MySqlConnection conexion;*/
        public ConsultarBullets( )
        {
            InitializeComponent();
            
        }

        private void ConsultarBullets_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = LLenarDataGV("cama_bullets").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string cmd = "Select * FROM cama_bullets WHERE NOMBRE_BULLETS LIKE ('%" + textBox1.Text.Trim() + "%')";

                    DS = utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = DS.Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error:" + error.Message);

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* ReportesBullets rebut = new ReportesBullets(conexion);
            
            rebut.Show();*/
            ReporteBullets rebull = new ReporteBullets();
            rebull.Show();
        }
    }
}
