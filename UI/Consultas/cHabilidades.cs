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
    public partial class cHabilidades : Form
    {
        public cHabilidades()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Habilidades>();

            if (!string.IsNullOrEmpty(InformacionTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = HabilidadesBLL.GetList(e => e.HabilidadId == int.Parse(InformacionTextBox.Text));
                        break;

                    case 1:
                        listado = HabilidadesBLL.GetList(e => e.Nombre.Contains(InformacionTextBox.Text));
                        break;

                }
            }
            else
            {
                listado = HabilidadesBLL.GetList(c => true);
            }

            if (FiltroCheckBox.Checked == true)
            {
                listado = HabilidadesBLL.GetList(e => e.FechaCreacion.Date >= FechaDesdeDateTimePicker.Value.Date && e.FechaCreacion.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
                listado = HabilidadesBLL.GetList(e => e.EsActivo == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
                listado = HabilidadesBLL.GetList(e => e.EsActivo == false);
            }

            UsuarioDataGridView.DataSource = null;
            UsuarioDataGridView.DataSource = listado;
            /*var lista = new List<Habilidades>();

            if (FiltroCheckBox.Checked)
            {
                if (TodoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {

                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = HabilidadesBLL.GetList(r => r.HabilidadId == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 1:
                                lista = HabilidadesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = HabilidadesBLL.GetList(r => true);
                }
                else if (ActivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = HabilidadesBLL.GetList(r => r.HabilidadId == Utilitarios.ToInt(FiltroCheckBox.Text));
                                break;
                            case 1:
                                lista = HabilidadesBLL.GetList(r => r.Nombre.Contains(FiltroCheckBox.Text.ToUpper()) || r.Nombre.Contains(InformacionTextBox.Text.ToLower()));
                                break;
                            default:
                                break;
                        }
                    }
                    
                        
                }
                else if (InactivoRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = HabilidadesBLL.GetList(r => r.HabilidadId == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 1:
                                lista = HabilidadesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text.ToUpper()) || r.Nombre.Contains(InformacionTextBox.Text.ToLower()));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(InformacionTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            lista = HabilidadesBLL.GetList(r => r.HabilidadId == Utilitarios.ToInt(InformacionTextBox.Text));
                            break;
                        case 1:
                            lista = HabilidadesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (FiltroCheckBox.Checked)
            {
                lista = HabilidadesBLL.GetList(r => r.FechaCreacion >= dateTimePicker1.Value && r.FechaCreacion <= dateTimePicker2.Value);
            }

            UsuarioDataGridView.DataSource = null;
            UsuarioDataGridView.DataSource = lista;*/
        }
    }
}
