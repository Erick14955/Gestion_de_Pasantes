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

namespace Gestion_de_Pasantes.UI.Registros
{
    public partial class rHabilidades : Form
    {
        public rHabilidades()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            HabilidadIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
            FechaCreacionDateTimePicker.Value = DateTime.Now.Date;
        }
        private void LlenaCampo(Habilidades habilidad)
        {
            HabilidadIdNumericUpDown.Value = habilidad.HabilidadId;
            NombreTextBox.Text = habilidad.Nombre;
            DescripcionTextBox.Text = habilidad.Descripcion;
            FechaCreacionDateTimePicker.Value = habilidad.FechaCreacion.Date;
        }
        private Habilidades LlenaClase()
        {
            Habilidades habilidad = new Habilidades();
            habilidad.HabilidadId = Convert.ToInt32(HabilidadIdNumericUpDown.Value);
            habilidad.Nombre = NombreTextBox.Text;
            habilidad.Descripcion = DescripcionTextBox.Text;
            habilidad.FechaCreacion = FechaCreacionDateTimePicker.Value.Date;

            return habilidad;
        }
        private bool Validar()
        {
            bool paso = true;

            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox,"Debes agregar un Nombre a esta habilidad.");
                NombreTextBox.Focus();

                paso = false;
            }
            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox,"Debes agregar una descripcion a esta habilidad.");
                DescripcionTextBox.Focus();

                paso = false;
            }

            return paso;
        }
    }
}
