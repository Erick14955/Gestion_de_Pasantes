using Gestion_de_Pasantes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Pasantes.UI.Registros
{
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
        }
        private void LimpiarClase()
        {
            NumericUpDown1.Value = 0;
            NombreTextBox.Clear();
            UsuarioTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmarClaveTextBox.Clear();
            RolComboBox.Text = "";
            EmailTextBox.Clear();
            ActivoCheckBox.Checked = false;
        }
        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = (int)NumericUpDown1.Value;
            usuario.Nombre = NombreTextBox.Text;
            usuario.Alias = UsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.Rol = RolComboBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.Activo = ActivoCheckBox.Checked;

            return usuario;
        }
        private void LlenarCampo(Usuarios usuarios)
        {
            NumericUpDown1.Value = usuarios.UsuarioId;
            NombreTextBox.Text = usuarios.Nombre;
            UsuarioTextBox.Text = usuarios.Alias;
            ClaveTextBox.Text = usuarios.Clave;
            RolComboBox.Text = usuarios.Rol;
            EmailTextBox.Text = usuarios.Email;
            ActivoCheckBox.Checked = usuarios.Activo;
        }
    }
}
