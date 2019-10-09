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
    public partial class reporteDomo : Form
    {
        public reporteDomo()
        {
            InitializeComponent();
        }

        private void reporteDomo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetDomo.CAMA_DOMOS' Puede moverla o quitarla según sea necesario.
            this.CAMA_DOMOSTableAdapter.Fill(this.DataSetDomo.CAMA_DOMOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
