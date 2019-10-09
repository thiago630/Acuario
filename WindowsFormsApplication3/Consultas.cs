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
    public partial class Consultas : Formbase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet LLenarDataGV(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + tabla);
            DS = utilidades.Ejecutar(cmd);


            return DS;
        
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;

            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }
    }
}
