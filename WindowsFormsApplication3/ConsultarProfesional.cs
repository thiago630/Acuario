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
    public partial class ConsultarProfesional : Consultas
    {
        public ConsultarProfesional()
        {
            InitializeComponent();
        }

        private void ConsultarProfesional_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("cama_profesional").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "Select * FROM cama_profesional WHERE NOMBRE_PROFESIONAL LIKE ('%" + textBox1.Text.Trim() + "%')";

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
            ReporteProfesional repProfe = new ReporteProfesional();
            repProfe.Show();
        }
    }
}
