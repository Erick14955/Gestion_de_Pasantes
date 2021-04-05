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
            var lista = new List<Roles>();

            if (FiltroCheckBox.Checked)
            {
                if (TodoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {

                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 1:
                                lista = RolesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                                break;
                            case 2:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(InformacionTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => true);
                }
                else if (ActivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(InformacionTextBox.Text) && r.esActivo);
                                break;
                            case 1:
                                lista = RolesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text.ToUpper()) && r.esActivo || r.Nombre.Contains(InformacionTextBox.Text.ToLower()) && r.esActivo);
                                break;
                            case 2:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(InformacionTextBox.Text) && r.esActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => r.esActivo);
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
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(InformacionTextBox.Text) && !r.esActivo);
                                break;
                            case 1:
                                lista = RolesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text.ToUpper()) && !r.esActivo || r.Nombre.Contains(InformacionTextBox.Text.ToLower()) && !r.esActivo);
                                break;
                            case 2:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(InformacionTextBox.Text.ToUpper()) && r.esActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => !r.esActivo);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(InformacionTextBox.Text));
                            break;
                        case 1:
                            lista = RolesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                            break;
                        case 3:
                            lista = RolesBLL.GetList(r => r.Descripcion.Contains(InformacionTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = RolesBLL.GetList(r => true);
            }

            if (FiltroCheckBox.Checked)
            {
                lista = RolesBLL.GetList(r => r.FechaCreacion >= FechaInicio.Value && r.FechaCreacion<= FechaFinal.Value);
            }

            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = lista;
        }
    }
}
