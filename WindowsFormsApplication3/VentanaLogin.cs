using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Mylibreria;

namespace WindowsFormsApplication3
{
    public partial class VentanaLogin : Formbase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }
        public static string Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM USUARIOS WHERE account='{0}' AND password='{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());

                DataSet ds = utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();


                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {

                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaAdm VenAd = new VentanaAdm();
                        this.Hide();
                        VenAd.Show();


                    }
                    else
                    {

                        VentanaUser VenUs = new VentanaUser();
                        this.Hide();
                        VenUs.Show();
                    }
                }
                

            }
            catch(Exception )
            {
                MessageBox.Show("Usuario o contraseña incorrecta" );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
