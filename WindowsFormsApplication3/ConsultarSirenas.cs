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
    public partial class ConsultarSirenas : Consultas
    {
        public ConsultarSirenas()
        {
            InitializeComponent();
        }

        private void ConsultarSirenas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("SIRENAS").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "Select * FROM SIRENAS WHERE NOMBRE_SIRENA LIKE ('%" + textBox1.Text.Trim() + "%')";

                    ds = utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error:" + error.Message);

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteSirena repsir = new ReporteSirena();
            repsir.Show();
        }
    }
}
