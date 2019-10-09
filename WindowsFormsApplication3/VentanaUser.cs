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
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
    public partial class VentanaUser : Formbase
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contenedor_principal ConP = new Contenedor_principal();
            this.Hide();
            ConP.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios where id_usuario=" + VentanaLogin.Codigo;


            DataSet DS = utilidades.Ejecutar(cmd);


            lblnomUs.Text = DS.Tables[0].Rows[0]["nom_usu"].ToString();
            lbluser.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblcodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();


            string url = DS.Tables[0].Rows[0]["foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
