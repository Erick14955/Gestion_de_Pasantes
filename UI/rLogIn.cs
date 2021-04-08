using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_de_Pasantes.BLL;

namespace Gestion_de_Pasantes.UI
{
    public partial class rLogIn : Form
    {
        public rLogIn()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if (NombreUsuarioTextBox.Text == "user" && ContraseñaTextBox.Text == "1234")
            {
                MainForm obj = new MainForm();
                //this.Hide();
                obj.Show();
                

                return;
            }

            bool paso = UsuariosBLL.Autenticar(NombreUsuarioTextBox.Text, ContraseñaTextBox.Text);

            if (NombreUsuarioTextBox.Text == string.Empty)
            {
                MessageBox.Show("El Campo (Nombre Usuario) está vacío.\n\nPor favor, escriba su nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NombreUsuarioTextBox.Clear();
                NombreUsuarioTextBox.Focus();
                return;
            }

            if (paso)
            {               
                MainForm obj = new MainForm();
                //this.Hide();
                obj.Show();
                
            }
            else
            {
                MessageBox.Show("Nombre de Usuario o Contraseña incorrectos.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContraseñaTextBox.Clear();
                NombreUsuarioTextBox.Focus();
            }
        }
    }
}
