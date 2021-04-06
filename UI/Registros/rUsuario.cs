using Gestion_de_Pasantes.BLL;
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
        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            UsuarioTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmarClaveTextBox.Clear();
            RolComboBox.Text = "";
            EmailTextBox.Clear();
            ActivoCheckBox.Checked = false;
            MyErrorProvider.Clear();
        }
        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
            usuario.Nombre = NombreTextBox.Text;
            usuario.Alias = UsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.Rol = RolComboBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.Activo = ActivoCheckBox.Checked;

            return usuario;
        }
        private void LlenaCampo(Usuarios usuarios)
        {
            UsuarioIdNumericUpDown.Value = usuarios.UsuarioId;
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
                MyErrorProvider.SetError(NombreTextBox, "Este campo no puede quedar vacio");
                NombreTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "Este campo no puede quedar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                MyErrorProvider.SetError(ClaveTextBox, "Este campo no puede quedar vacio");
                ClaveTextBox.Focus();
                paso = false;

            }
            if (string.IsNullOrWhiteSpace(ConfirmarClaveTextBox.Text))
            {
                MyErrorProvider.SetError(ConfirmarClaveTextBox, "Este campo no puede quedar vacio");
                ConfirmarClaveTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(RolComboBox.Text))
            {
                MyErrorProvider.SetError(RolComboBox, "Este campo no puede quedar vacio");
                RolComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyErrorProvider.SetError(EmailTextBox, "Este campo no puede quedar vacio");
                EmailTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse(UsuarioIdNumericUpDown.Text, out id);

            Limpiar();

            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                LlenaCampo(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            Usuarios usuarios;

            if (!Validar())
                return;

            usuarios = LlenaClase();

            var paso = UsuariosBLL.Guardar(usuarios);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(UsuarioIdNumericUpDown.Text, out id);

            if (UsuarioIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Debes agregar un id valido para poder eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UsuariosBLL.Existe(id))
                MessageBox.Show("Usuario Inexistente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Deseas eliminar este usuario?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (UsuariosBLL.Eliminar(id))
                    {
                        MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
            }
        }
    }
}
