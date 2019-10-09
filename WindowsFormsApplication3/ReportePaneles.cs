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
    public partial class ReportePaneles : Form
    {
        public ReportePaneles()
        {
            InitializeComponent();
        }

        private void ReportePaneles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPaneles.PANELES' Puede moverla o quitarla según sea necesario.
            this.PANELESTableAdapter.Fill(this.DataSetPaneles.PANELES);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
