using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Mylibreria
{
    public class utilidades
    {

        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=BOLTYCOM2;Integrated Security=True");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();


            return DS;
        }

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls)
            {
                if (Item is errortxtbox)
                {
                    errortxtbox obj = (errortxtbox)Item;

                    if (obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(obj, "No puede estar vacio");
                            HayErrores = true;
                        }

                    }

                    if (obj.SoloNumeros == true)
                    {
                        int cont = 0, LetrasEncontradas = 0;

                        foreach (char letra in obj.Text.Trim())
                        {
                            if (char.IsLetter(obj.Text.Trim(), cont))
                            {
                                LetrasEncontradas++;
                            }
                            cont++;

                        }

                        if (LetrasEncontradas != 0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(obj, "Solo Numeros");
                        }
                    }
                }
            }
            return HayErrores;
        
        
        }

    }
}
