using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mylibreria
{
    public partial class errortxtbox : TextBox
    {
        public errortxtbox()
        {
            InitializeComponent();
        }
        public Boolean Validar
        {
            set;
            get;
        }
        public Boolean SoloNumeros
        {
            set;
            get;
        }
    }
    
}
