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
            if ((EmailtextBox.Text == "") && (passwordtextBox.Text == ""))
                MessageBox.Show("No puede dejar los Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if ((EmailtextBox.Text != "user") && (passwordtextBox.Text == "1234"))
                MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if ((EmailtextBox.Text == "user") && (passwordtextBox.Text != "1234"))
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if ((EmailtextBox.Text != "") && (passwordtextBox.Text != ""))
            {
                if ((EmailtextBox.Text != "user") && (passwordtextBox.Text != "1234"))
                    MessageBox.Show("Usuario y Contraseña Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((EmailtextBox.Text != "") && (passwordtextBox.Text != ""))
            {

                if (EmailtextBox.Text == "user" && passwordtextBox.Text == "1234")
                {
                    MainForm mnf = new MainForm();
                    mnf.Show();
                }
            }
        }

        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                passwordtextBox.Focus();
            }
        }

        private void passwordtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if ((EmailtextBox.Text == "") && (passwordtextBox.Text == ""))
                    MessageBox.Show("No puede dejar los Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if ((EmailtextBox.Text != "user") && (passwordtextBox.Text == "1234"))
                    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if ((EmailtextBox.Text == "user") && (passwordtextBox.Text != "1234"))
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if ((EmailtextBox.Text != "") && (passwordtextBox.Text != ""))
                {
                    if ((EmailtextBox.Text != "user") && (passwordtextBox.Text != "1234"))
                        MessageBox.Show("Usuario y Contraseña Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if ((EmailtextBox.Text != "") && (passwordtextBox.Text != ""))
                {

                    if (EmailtextBox.Text == "user" && passwordtextBox.Text == "1234")
                    {
                        MainForm mnf = new MainForm();
                        mnf.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
