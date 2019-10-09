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
    public partial class ReporteProfesional : Form
    {
        public ReporteProfesional()
        {
            InitializeComponent();
        }

        private void ReporteProfesional_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetProfesional.CAMA_PROFESIONAL' Puede moverla o quitarla según sea necesario.
            this.CAMA_PROFESIONALTableAdapter.Fill(this.DataSetProfesional.CAMA_PROFESIONAL);

            this.reportViewer1.RefreshReport();
        }
    }
}
