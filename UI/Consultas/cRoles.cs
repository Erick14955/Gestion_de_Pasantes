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

namespace Gestion_de_Pasantes.UI.Consultas
{
    public partial class cRoles : Form
    {
        public cRoles()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Roles>();

            if (!string.IsNullOrEmpty(InformacionTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(InformacionTextBox.Text));
                        break;
                    case 1:
                        listado = RolesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                        break;
                    case 3:
                        listado = RolesBLL.GetList(r => r.Descripcion.Contains(InformacionTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = RolesBLL.GetList(c => true);
            }

            if (FiltroCheckBox.Checked == true)
            {
                listado = RolesBLL.GetList(e => e.FechaCreacion.Date >= FechaDesdeDateTimePicker.Value.Date && e.FechaCreacion.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
                listado = RolesBLL.GetList(e => e.esActivo == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
                listado = RolesBLL.GetList(e => e.esActivo == false);
            }

            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = listado;
        }
    }
}
