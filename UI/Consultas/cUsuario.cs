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
    public partial class cUsuario : Form
    {
        public cUsuario()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Usuarios>();

            if (FiltroCheckBox.Checked)
            {
                if (TodoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {

                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 1:
                                lista = UsuariosBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                                break;
                            case 2:
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(InformacionTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => true);
                }
                else if (ActivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(FiltroCheckBox.Text) && r.Activo);
                                break;
                            case 1:
                                lista = UsuariosBLL.GetList(r => r.Nombre.Contains(FiltroCheckBox.Text.ToUpper()) && r.Activo || r.Nombre.Contains(InformacionTextBox.Text.ToLower()) && r.Activo);
                                break;
                            case 2:
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(FiltroCheckBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => r.Activo);
                }
                else if (InactivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(InformacionTextBox.Text) && !r.Activo);
                                break;
                            case 1:
                                lista = UsuariosBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text.ToUpper()) && !r.Activo || r.Nombre.Contains(InformacionTextBox.Text.ToLower()) && !r.Activo);
                                break;
                            case 2:
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(InformacionTextBox.Text.ToUpper()) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => !r.Activo);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(InformacionTextBox.Text));
                            break;
                        case 1:
                            lista = UsuariosBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                            break;
                        case 3:
                            lista = UsuariosBLL.GetList(r => r.Email.Contains(InformacionTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = UsuariosBLL.GetList(r => true);
            }

            if (FiltroCheckBox.Checked)
            {
                lista = UsuariosBLL.GetList(r => r.FechaIngreso >= dateTimePicker1.Value && r.FechaIngreso <= dateTimePicker2.Value);
            }

            UsuarioDataGridView.DataSource = null;
            UsuarioDataGridView.DataSource = lista;
        }
    }
}
