using Gestion_de_Pasantes.BLL;
using Gestion_de_Pasantes.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_de_Pasantes.UI.Consultas
{
    public partial class cUsuario : Form
    {
        public cUsuario()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            var listado = new List<Usuarios>();

            if (!string.IsNullOrEmpty(InformacionTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(InformacionTextBox.Text));
                        break;
                    case 1:
                        listado = UsuariosBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                        break;
                    case 3:
                        listado = UsuariosBLL.GetList(r => r.Email.Contains(InformacionTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = UsuariosBLL.GetList(c => true);
            }

            if (FiltroCheckBox.Checked == true)
            {
                listado = UsuariosBLL.GetList(e => e.FechaIngreso.Date >= FechaDesdeDateTimePicker.Value.Date && e.FechaIngreso.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
                listado = UsuariosBLL.GetList(e => e.Activo == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
                listado = UsuariosBLL.GetList(e => e.Activo == false);
            }

            UsuarioDataGridView.DataSource = null;
            UsuarioDataGridView.DataSource = listado;
        }
    }
}
