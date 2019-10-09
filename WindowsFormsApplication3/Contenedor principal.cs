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
    public partial class Contenedor_principal : Form
    {
        private int childFormNumber = 0;

        public Contenedor_principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       /* private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }*/

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Paneles ManCli = new Paneles();
            ManCli.MdiParent = this;
            ManCli.Show();

        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sensores ManPro = new Sensores();
            ManPro.MdiParent = this;
            ManPro.Show();
        }

        private void sensoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarSensores ConAlar = new ConsultarSensores();
            ConAlar.MdiParent = this;
            ConAlar.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                /*this.Close();*/
                Application.Exit();
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPaneles ConPane = new ConsultarPaneles();
            ConPane.MdiParent = this;
            ConPane.Show();
        }

        private void tecladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teclados tecla = new Teclados();
            tecla.MdiParent = this;
            tecla.Show();
        }

        private void tecladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTeclado Contecla = new ConsultarTeclado();
            Contecla.MdiParent = this;
            Contecla.Show();
        }

        private void controlRemotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlRemoto ConRemoto = new ControlRemoto();
            ConRemoto.MdiParent = this;
            ConRemoto.Show();
        }

        private void controlRemotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarControlRemotos ConRemoto = new ConsultarControlRemotos();
            ConRemoto.MdiParent = this;
            ConRemoto.Show();
        }

        private void sirenasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sirenas Sire = new Sirenas();
            Sire.MdiParent = this;
            Sire.Show();
        }

        private void sirenasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarSirenas ConSir = new ConsultarSirenas();
            ConSir.MdiParent = this;
            ConSir.Show();
        }

        private void bulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bullets bull = new Bullets();
            bull.MdiParent = this;
            bull.Show();
        }

        private void bulletsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarBullets conbull = new ConsultarBullets();
            conbull.MdiParent = this;
            conbull.Show();
        }

        private void profesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesional camPro = new Profesional();
            camPro.MdiParent = this;
            camPro.Show();
        }

        private void profesionalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarProfesional ConPro = new ConsultarProfesional();
            ConPro.MdiParent = this;
            ConPro.Show();
        }

        private void domoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Domos camDom = new Domos();
            camDom.MdiParent = this;
            camDom.Show();
        }

        private void domosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarDomos ConDomo = new ConsultarDomos();
            ConDomo.MdiParent = this;
            ConDomo.Show();
        }

        private void camarasIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CamaraIP CamIP = new CamaraIP();
            CamIP.MdiParent = this;
            CamIP.Show();
        }

        private void iPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarIP ConIP = new ConsultarIP();
            ConIP.MdiParent = this;
            ConIP.Show();
        }

        private void cablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cables cab = new Cables();
            cab.MdiParent = this;
            cab.Show();
        }

        private void cablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarCables concab = new ConsultarCables();
            concab.MdiParent = this;
            concab.Show();
        }

        private void conectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conectores Conec = new Conectores();
            Conec.MdiParent = this;
            Conec.Show();
        }

        private void conectoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarConectores ConConec = new ConsultarConectores();
            ConConec.MdiParent = this;
            ConConec.Show();
        }
    }
}
