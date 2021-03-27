using Gestion_de_Pasantes.BLL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (EmailtextBox.Text == "user" && passwordtextBox.Text == "1234")
            {
                MainForm mnf = new MainForm();
                mnf.Show();
            }
            else
            {
                if (PasantesBLL.ExisteUsuario(EmailtextBox.Text, passwordtextBox.Text))
                {
                    MainForm mnf = new MainForm();
                    mnf.Show();
                }
                else
                {
                    ErroreserrorProvider.SetError(EmailtextBox, "El email o clave es incorrecto");
                    ErroreserrorProvider.SetError(passwordtextBox, "El email o clave es incorrecto");
                    passwordtextBox.Clear();
                }
            }

            EmailtextBox.Clear();
            passwordtextBox.Clear();
        }
    }
}
