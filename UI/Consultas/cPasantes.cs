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
            var lista = new List<Pasantes>();

            if (FiltroCheckBox.Checked)
            {
                if (TodoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {

                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = PasantesBLL.GetList(r => r.id == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 1:
                                lista = PasantesBLL.GetList(r => r.NombrePasante.Contains(InformacionTextBox.Text));
                                break;
                            case 2:
                                lista = PasantesBLL.GetList(r => r.Matricula == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 3:
                                lista = PasantesBLL.GetList(r => r.Institucion.Contains(InformacionTextBox.Text));
                                break;
                            case 4:
                                lista = PasantesBLL.GetList(r => r.TotalHoras == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = PasantesBLL.GetList(r => true);
                }
                else if (ActivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = PasantesBLL.GetList(r => r.id == Utilitarios.ToInt(InformacionTextBox.Text) && r.Activo);
                                break;
                            case 1:
                                lista = PasantesBLL.GetList(r => r.NombrePasante.Contains(InformacionTextBox.Text.ToUpper()) && r.Activo || r.NombrePasante.Contains(InformacionTextBox.Text.ToLower()) && r.Activo);
                                break;
                            case 2:
                                lista = PasantesBLL.GetList(r => r.Matricula == Utilitarios.ToInt(InformacionTextBox.Text) && r.Activo);
                                break;
                            case 3:
                                lista = PasantesBLL.GetList(r => r.Institucion.Contains(InformacionTextBox.Text.ToUpper()) && r.Activo || r.NombrePasante.Contains(InformacionTextBox.Text.ToLower()) && r.Activo);
                                break;
                            case 4:
                                lista = PasantesBLL.GetList(r => r.TotalHoras == Utilitarios.ToInt(InformacionTextBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = PasantesBLL.GetList(r => r.Activo);
                }
                else if (InactivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            /*Id
                            Nombre
                            Matricula
                            Institucion
                            Total de horas*/
                            case 0:
                                lista = PasantesBLL.GetList(r => r.id == Utilitarios.ToInt(InformacionTextBox.Text) && !r.Activo);
                                break;
                            case 1:
                                lista = PasantesBLL.GetList(r => r.NombrePasante.Contains(InformacionTextBox.Text.ToUpper()) && !r.Activo || r.NombrePasante.Contains(InformacionTextBox.Text.ToLower()) && !r.Activo);
                                break;
                            case 2:
                                lista = PasantesBLL.GetList(r => r.Matricula == Utilitarios.ToInt(InformacionTextBox.Text) && r.Activo);
                                break;
                            case 3:
                                lista = PasantesBLL.GetList(r => r.Institucion.Contains(InformacionTextBox.Text.ToUpper()) && r.Activo || r.NombrePasante.Contains(InformacionTextBox.Text.ToLower()) && r.Activo);
                                break;
                            case 4:
                                lista = PasantesBLL.GetList(r => r.TotalHoras == Utilitarios.ToInt(InformacionTextBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = PasantesBLL.GetList(r => !r.Activo);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            lista = PasantesBLL.GetList(r => r.id == Utilitarios.ToInt(InformacionTextBox.Text));
                            break;
                        case 1:
                            lista = PasantesBLL.GetList(r => r.NombrePasante.Contains(InformacionTextBox.Text));
                            break;
                        case 2:
                            lista = PasantesBLL.GetList(r => r.Matricula == Utilitarios.ToInt(InformacionTextBox.Text));
                            break;
                        case 3:
                            lista = PasantesBLL.GetList(r => r.Institucion.Contains(InformacionTextBox.Text));
                            break;
                        case 4:
                            lista = PasantesBLL.GetList(r => r.TotalHoras == Utilitarios.ToInt(InformacionTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = PasantesBLL.GetList(r => true);
            }

            if (FiltroCheckBox.Checked)
            {
                lista = PasantesBLL.GetList(r => r.Fecha >= dateTimePicker1.Value && r.Fecha <= dateTimePicker2.Value);
            }

            PasantesDataGridView.DataSource = null;
            PasantesDataGridView.DataSource = lista;
        }
    }
}
