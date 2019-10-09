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
    public partial class ReperteCables : Form
    {
        public ReperteCables()
        {
            InitializeComponent();
        }

        private void ReperteCables_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetCables.CABLES_UTP' Puede moverla o quitarla según sea necesario.
            this.CABLES_UTPTableAdapter.Fill(this.DataSetCables.CABLES_UTP);

            this.reportViewer1.RefreshReport();
        }
    }
}
