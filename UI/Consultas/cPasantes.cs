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
                                lista = PasantesBLL.GetList(r => r.PasanteId == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 1:
                                lista = PasantesBLL.GetList(r => r.Nombre.Contains(InformacionTextBox.Text));
                                break;
                            case 2:
                                lista = PasantesBLL.GetList(r => r.Matricula == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            case 3:
                                lista = PasantesBLL.GetList(r => r.Institucion.Contains(InformacionTextBox.Text));
                                break;
                            case 4:
                                lista = PasantesBLL.GetList(r => r.HorasARealizar == Utilitarios.ToInt(InformacionTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = PasantesBLL.GetList(r => true);
                }
            }
            PasantesDataGridView.DataSource = null;
            PasantesDataGridView.DataSource = lista;
        }
    }
}
