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
    public partial class ConsultarIP : Consultas
    {
        public ConsultarIP()
        {
            InitializeComponent();
        }

        private void ConsultarIP_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("CAMA_IP").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string cmd = "Select * FROM cama_ip WHERE NOMBRE_CIP LIKE ('%" + textBox1.Text.Trim() + "%')";

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
            ReporteIP repIP = new ReporteIP();
            repIP.Show();
        }
    }
}
