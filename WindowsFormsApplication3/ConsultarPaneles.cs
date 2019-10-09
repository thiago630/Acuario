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
    public partial class ConsultarPaneles : Consultas
    {
        public ConsultarPaneles()
        {
            InitializeComponent();
        }

        private void ConsultarPaneles_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("paneles").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "Select * FROM paneles WHERE NOMBRE_PANEL LIKE ('%" + textBox1.Text.Trim() + "%')";

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
            ReportePaneles repan = new ReportePaneles();
            repan.Show();
        }
    }
}
