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
    public partial class cInstituciones : Form
    {
        public cInstituciones()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Instituciones>();

            if (!string.IsNullOrEmpty(InformacionTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = InstitucionesBLL.GetList(e => e.InstitucionId == int.Parse(InformacionTextBox.Text));
                        break;

                    case 1:
                        listado = InstitucionesBLL.GetList(e => e.Nombre.Contains(InformacionTextBox.Text));
                        break;
                    case 2:
                        listado = InstitucionesBLL.GetList(e => e.Region.Contains(InformacionTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = InstitucionesBLL.GetList(c => true);
            }

            if (FiltroCheckBox.Checked == true)
            {
                listado = InstitucionesBLL.GetList(e => e.Fecha.Date >= FechaDesdeDateTimePicker.Value.Date && e.Fecha.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
                listado = InstitucionesBLL.GetList(e => e.Activo == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
                listado = InstitucionesBLL.GetList(e => e.Activo == false);
            }


            InstitucionesDataGridView.DataSource = null;
            InstitucionesDataGridView.DataSource = listado;
        }
    }
}
