using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class ReporteControlRemoto : Form
    {
        public ReporteControlRemoto()
        {
            InitializeComponent();
        }

        private void ReporteControlRemoto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetControlRemoto.CONTROL_REMOTO' Puede moverla o quitarla según sea necesario.
            this.CONTROL_REMOTOTableAdapter.Fill(this.DataSetControlRemoto.CONTROL_REMOTO);

            this.reportViewer1.RefreshReport();
        }
    }
}
