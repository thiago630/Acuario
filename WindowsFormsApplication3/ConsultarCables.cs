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
    public partial class ConsultarCables : Consultas
    {
        public ConsultarCables()
        {
            InitializeComponent();
        }

        private void ConsultarCables_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("CABLES_UTP").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "Select * FROM CABLE_UTP WHERE NOMBRE_CABLE LIKE ('%" + textBox1.Text.Trim() + "%')";

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
            ReperteCables repCable = new ReperteCables();
            repCable.Show();
        }
    }
}
