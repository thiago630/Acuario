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
    public partial class ReporteTeclado : Form
    {
        public ReporteTeclado()
        {
            InitializeComponent();
        }

        private void ReporteTeclado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetTeclado.TECLADOS' Puede moverla o quitarla según sea necesario.
            this.TECLADOSTableAdapter.Fill(this.DataSetTeclado.TECLADOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
