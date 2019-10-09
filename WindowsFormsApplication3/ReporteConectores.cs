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
    public partial class ReporteConectores : Form
    {
        public ReporteConectores()
        {
            InitializeComponent();
        }

        private void ReporteConectores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetConectores.CONECTORES' Puede moverla o quitarla según sea necesario.
            this.CONECTORESTableAdapter.Fill(this.DataSetConectores.CONECTORES);

            this.reportViewer1.RefreshReport();
        }
    }
}
