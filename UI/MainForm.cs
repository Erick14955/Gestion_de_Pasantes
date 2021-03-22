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
        }

        private void PasanteToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rPasantes pasantes = new rPasantes();
            pasantes.MdiParent = this;
            pasantes.Show();
        }

        private void RolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {

        }

        private void PermisosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {

        }

        private void ConsultasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
        }
    }
}
