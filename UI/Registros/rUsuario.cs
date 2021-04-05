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
        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                MyerrorProvider.SetError(NombreTextBox, "Este campo no puede quedar vacio");
                NombreTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                MyerrorProvider.SetError(UsuarioTextBox, "Este campo no puede quedar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                MyerrorProvider.SetError(ClaveTextBox, "Este campo no puede quedar vacio");
                ClaveTextBox.Focus();
                paso = false;

            }
            if (string.IsNullOrWhiteSpace(ConfirmarClaveTextBox.Text))
            {
                MyerrorProvider.SetError(ConfirmarClaveTextBox, "Este campo no puede quedar vacio");
                ConfirmarClaveTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(RolComboBox.Text))
            {
                MyerrorProvider.SetError(RolComboBox, "Este campo no puede quedar vacio");
                RolComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyerrorProvider.SetError(EmailTextBox, "Este campo no puede quedar vacio");
                EmailTextBox.Focus();
                paso = false;
            }

            return paso;
        }
    }
}
