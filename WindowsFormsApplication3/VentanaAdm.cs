using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mylibreria;

namespace WindowsFormsApplication3
{
    public partial class VentanaAdm : Formbase

    {
        public VentanaAdm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void VentanaAdm_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios where id_usuario=" + VentanaLogin.Codigo;


            DataSet DS = utilidades.Ejecutar(cmd);


            lblnomAdm.Text = DS.Tables[0].Rows[0]["nom_usu"].ToString();
            lblUsuAdm.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblcodigoAdm.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();


            string url = DS.Tables[0].Rows[0]["foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);


        }

        private void VentanaAdm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contenedor_principal ConP = new Contenedor_principal();
            this.Hide();
            ConP.Show();
        }

        
    }
}
