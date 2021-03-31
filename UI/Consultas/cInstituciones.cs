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
            var lista = new List<Instituciones>();

            if (FiltroCheckBox.Checked)
            {
                if (TodoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {

                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = InstitucionesBLL.GetList(r => r.InstitucionId == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 1:
                                lista = InstitucionesBLL.GetList(r => r.NombreInstitucion.Contains(InformacionTextBox.Text));
                                break;
                            case 2:
                                lista = InstitucionesBLL.GetList(r => r.Region.Contains(InformacionTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = InstitucionesBLL.GetList(r => true);
                }
                else if (ActivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = InstitucionesBLL.GetList(r => r.InstitucionId == Utilitarios.ToInt(InformacionTextBox.Text) && r.Activo);
                                break;
                            case 1:
                                lista = InstitucionesBLL.GetList(r => r.NombreInstitucion.Contains(InformacionTextBox.Text.ToUpper()) && r.Activo || r.NombreInstitucion.Contains(InformacionTextBox.Text.ToLower()) && r.Activo);
                                break;
                            case 2:
                                lista = InstitucionesBLL.GetList(r => r.Region.Contains(InformacionTextBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = InstitucionesBLL.GetList(r => r.Activo);
                }
                else if (InactivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = InstitucionesBLL.GetList(r => r.InstitucionId == Utilitarios.ToInt(InformacionTextBox.Text) && !r.Activo);
                                break;
                            case 1:
                                lista = InstitucionesBLL.GetList(r => r.NombreInstitucion.Contains(InformacionTextBox.Text.ToUpper()) && !r.Activo || r.NombreInstitucion.Contains(InformacionTextBox.Text.ToLower()) && !r.Activo);
                                break;
                            case 2:
                                lista = InstitucionesBLL.GetList(r => r.Region.Contains(InformacionTextBox.Text.ToUpper()) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = InstitucionesBLL.GetList(r => !r.Activo);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            lista = InstitucionesBLL.GetList(r => r.InstitucionId == Utilitarios.ToInt(InformacionTextBox.Text));
                            break;
                        case 1:
                            lista = InstitucionesBLL.GetList(r => r.NombreInstitucion.Contains(InformacionTextBox.Text));
                            break;
                        case 3:
                            lista = InstitucionesBLL.GetList(r => r.Region.Contains(InformacionTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = InstitucionesBLL.GetList(r => true);
            }

            if (FiltroCheckBox.Checked)
            {
                lista = InstitucionesBLL.GetList(r => r.Fecha >= dateTimePicker1.Value && r.Fecha <= dateTimePicker2.Value);
            }

            InstitucionesDataGridView.DataSource = null;
            InstitucionesDataGridView.DataSource = lista;
        }
    }
}
