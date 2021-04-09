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
    public partial class cTareas : Form
    {
        public cTareas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            var listado = new List<Tareas>();

            if (!string.IsNullOrEmpty(InformacionTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = TareasBLL.GetList(r => r.TareaId == Utilitarios.ToInt(InformacionTextBox.Text));
                        break;
                    case 1:
                        listado = TareasBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                        break;
                    case 2:
                        listado = TareasBLL.GetList(r => r.Asignado.Contains(InformacionTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = TareasBLL.GetList(c => true);
            }

            if (FiltroCheckBox.Checked == true)
            {
                listado = TareasBLL.GetList(e => e.FechaInicio.Date >= FechaDesdeDateTimePicker.Value.Date && e.FechaInicio.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
                listado = TareasBLL.GetList(e => e.Activo == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
                listado = TareasBLL.GetList(e => e.Activo == false);
            }

            TareasDataGridView.DataSource = null;
            TareasDataGridView.DataSource = listado;
        }
    }
}
