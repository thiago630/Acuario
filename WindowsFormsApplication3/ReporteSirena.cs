﻿using System;
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
    public partial class ReporteSirena : Form
    {
        public ReporteSirena()
        {
            InitializeComponent();
        }

        private void ReporteSirena_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetSirena.SIRENAS' Puede moverla o quitarla según sea necesario.
            this.SIRENASTableAdapter.Fill(this.DataSetSirena.SIRENAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
