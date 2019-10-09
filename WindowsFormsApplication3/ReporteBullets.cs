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
    public partial class ReporteBullets : Form
    {
        public ReporteBullets()
        {
            InitializeComponent();
        }

        private void ReporteBullets_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetBullets.CAMA_BULLETS' Puede moverla o quitarla según sea necesario.
           this.CAMA_BULLETSTableAdapter.Fill(this.DataSetBullets.CAMA_BULLETS);

            this.reportViewer1.RefreshReport();

            string cmd = "Select * from USUARIOS Where ID_USUARIO=" + VentanaLogin.Codigo;
            DataSet ds;
            ds = utilidades.Ejecutar(cmd);
            lblatiende.Text = ds.Tables[0].Rows[0]["NOM_USU"].ToString().Trim();


        }
    }
}
