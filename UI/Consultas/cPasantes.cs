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
    public partial class cPasantes : Form
    {
        public cPasantes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Pasantes>();

            if (!string.IsNullOrEmpty(InformacionTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = PasantesBLL.GetList(r => r.PasanteId == Utilitarios.ToInt(InformacionTextBox.Text));
                        break;
                    case 1:
                        listado = PasantesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                        break;
                    case 2:
                        listado = PasantesBLL.GetList(r => r.Matricula == Utilitarios.ToInt(InformacionTextBox.Text));
                        break;
                    case 3:
                        listado = PasantesBLL.GetList(r => r.Institucion.Contains(InformacionTextBox.Text));
                        break;
                    case 4:
                        listado = PasantesBLL.GetList(r => r.HorasARealizar == Utilitarios.ToInt(InformacionTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = PasantesBLL.GetList(c => true);
            }

            if (FiltroCheckBox.Checked == true)
            {
                listado = PasantesBLL.GetList(e => e.FechaCreacion.Date >= FechaDesdeDateTimePicker.Value.Date && e.FechaCreacion.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
                listado = PasantesBLL.GetList(e => e.Activo == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
                listado = PasantesBLL.GetList(e => e.Activo == false);
            }

            PasantesDataGridView.DataSource = null;
            PasantesDataGridView.DataSource = listado;
        }
    }
}
