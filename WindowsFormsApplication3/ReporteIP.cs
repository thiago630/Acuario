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
    public partial class ReporteIP : Form
    {
        public ReporteIP()
        {
            InitializeComponent();
        }

        private void ReporteIP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetIP.CAMA_IP' Puede moverla o quitarla según sea necesario.
            this.CAMA_IPTableAdapter.Fill(this.DataSetIP.CAMA_IP);

            this.reportViewer1.RefreshReport();
        }
    }
}
