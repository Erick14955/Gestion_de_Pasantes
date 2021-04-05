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
            var lista = new List<Tareas>();

            if (FiltroCheckBox.Checked)
            {
                if (TodoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {

                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = TareasBLL.GetList(r => r.TareaId == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 1:
                                lista = TareasBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                                break;
                            case 2:
                                lista = TareasBLL.GetList(r => r.Descripcion.Contains(InformacionTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = TareasBLL.GetList(r => true);
                }
                else if (ActivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = TareasBLL.GetList(r => r.TareaId == Utilitarios.ToInt(FiltroCheckBox.Text) && r.Activo);
                                break;
                            case 1:
                                lista = TareasBLL.GetList(r => r.Nombre.Contains(FiltroCheckBox.Text.ToUpper()) && r.Activo || r.Nombre.Contains(InformacionTextBox.Text.ToLower()) && r.Activo);
                                break;
                            case 2:
                                lista = TareasBLL.GetList(r => r.Asignado.Contains(FiltroCheckBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = TareasBLL.GetList(r => r.Activo);
                }
                else if (InactivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = TareasBLL.GetList(r => r.TareaId == Utilitarios.ToInt(InformacionTextBox.Text) && !r.Activo);
                                break;
                            case 1:
                                lista = TareasBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text.ToUpper()) && !r.Activo || r.Nombre.Contains(InformacionTextBox.Text.ToLower()) && !r.Activo);
                                break;
                            case 2:
                                lista = TareasBLL.GetList(r => r.Asignado.Contains(InformacionTextBox.Text.ToUpper()) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = TareasBLL.GetList(r => !r.Activo);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            lista = TareasBLL.GetList(r => r.TareaId == Utilitarios.ToInt(InformacionTextBox.Text));
                            break;
                        case 1:
                            lista = TareasBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                            break;
                        case 3:
                            lista = TareasBLL.GetList(r => r.Asignado.Contains(InformacionTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = TareasBLL.GetList(r => true);
            }

            if (FiltroCheckBox.Checked)
            {
                lista = TareasBLL.GetList(r => r.FechaFinal >= dateTimePicker.Value && r.FechaFinal <= dateTimePicker.Value);
            }

            TareasDataGridView.DataSource = null;
            TareasDataGridView.DataSource = lista;
        }
    }
}
