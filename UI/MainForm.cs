using Gestion_de_Pasantes.UI.Consultas;
using Gestion_de_Pasantes.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Pasantes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.PasanteToolStripMenuItem.Click += new EventHandler(this.PasanteToolStripMenuItem_ItemClicked);
            this.PasantesStripMenuItem.Click += new EventHandler(this.PasantesToolStripMenuItem_ItemClicked);
        }

        private void PasanteToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rPasantes pasantes = new rPasantes();
            pasantes.MdiParent = this;
            pasantes.Show();
        }

        private void PasantesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cPasantes consultapasante = new cPasantes();
            consultapasante.MdiParent = this;
            consultapasante.Show();
        }

        private void PermisosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {

        }

        private void ConsultasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
        }
    }
}
