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
            this.RegistrarPasantesToolStripMenuItem.Click += new EventHandler(this.RegistrarPasanteToolStripMenuItem_ItemClicked);
            this.ConsultarPasantesStripMenuItem.Click += new EventHandler(this.ConsultarPasantesToolStripMenuItem_ItemClicked);

            this.RegistrarInstitucionesToolStripMenuItem.Click += new EventHandler(this.RegistrarInstitucionToolStripMenuItem_ItemClicked);
            this.ConsultarInstitucioneToolStripMenuItem.Click += new EventHandler(this.ConsultarInstitucioneToolStripMenuItem_ItemClicked);
            
            this.RegistrarTareasToolStripMenuItem.Click += new EventHandler(this.RegistrarTareaToolStripMenuItem_ItemClicked);
            this.ConsultarTareasToolStripMenuItem.Click += new EventHandler(this.ConsultarTareasToolStripMenuItem_ItemClicked);

            this.RegistrarRolesToolStripMenuItem.Click += new EventHandler(this.RegistrarRolesToolStripMenuItem_ItemClicked);
            this.ConsultarRolesToolStripMenuItem.Click += new EventHandler(this.ConsultarRolesToolStripMenuItem_ItemClicked);

            this.RegistrarUsuariosToolStripMenuItem.Click += new EventHandler(this.RegistrarUsuariosToolStripMenuItem_ItemClicked);
            this.ConsultarUsuariosToolStripMenuItem.Click += new EventHandler(this.ConsultarUsuariosToolStripMenuItem_ItemClicked);

            this.RegistrarHabilidadesToolStripMenuItem.Click += new EventHandler(this.RegistrarHabilidadesToolStripMenuItem_ItemClicked);
            this.ConsultarHabilidadesToolStripMenuItem.Click += new EventHandler(this.ConsultarHabilidadesToolStripMenuItem_itemClicked);
        }

        private void RegistrarPasanteToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rPasantes pasantes = new rPasantes();
            pasantes.MdiParent = this;
            pasantes.Show();
        }

        private void ConsultarPasantesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cPasantes consultapasante = new cPasantes();
            consultapasante.MdiParent = this;
            consultapasante.Show();
        }

        private void RegistrarInstitucionToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rInstituciones registroinst = new rInstituciones();
            registroinst.MdiParent = this;
            registroinst.Show();
        }
        private void ConsultarInstitucioneToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cInstituciones obj = new cInstituciones();
            obj.MdiParent = this;
            obj.Show();
        }
        private void RegistrarTareaToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rTareas registareas = new rTareas();
            registareas.MdiParent = this;
            registareas.Show();
        }
        private void ConsultarTareasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cTareas obj = new cTareas();
            obj.MdiParent = this;
            obj.Show();
        }
        private void RegistrarRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rRoles obj = new rRoles();
            obj.MdiParent = this;
            obj.Show();
        }
        private void ConsultarRolesToolStripMenuItem_ItemClicked(object sender,EventArgs e)
        {
            cRoles obj = new cRoles();
            obj.MdiParent = this;
            obj.Show();
        }
        private void RegistrarUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rUsuario obj = new rUsuario();
            obj.MdiParent = this;
            obj.Show();
        }
        private void ConsultarUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cUsuario obj = new cUsuario();
            obj.MdiParent = this;
            obj.Show();
        }
        private void RegistrarHabilidadesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rHabilidades obj = new rHabilidades();
            obj.MdiParent = this;
            obj.Show();
        }
        private void ConsultarHabilidadesToolStripMenuItem_itemClicked(object sender, EventArgs e)
        {
            cHabilidades obj = new cHabilidades();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
