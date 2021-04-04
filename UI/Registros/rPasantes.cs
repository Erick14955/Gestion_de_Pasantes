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
    public partial class rPasantes : Form
    {
        public rPasantes()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            PasanteIdNumericUpDown.Value = 0;
            FechaCreacionDateTimePicker.Value = DateTime.Now.Date;
            InstitucionComboBox.ValueMember = " ";
            NombrePasanteTextBox.Clear();
            MatriculaTextBox.Clear();
            EmailTextBox.Clear();
            HorasARealizarTextBox.Clear();
            TelefonoTextBox.Clear();
            HabilidadComboBox.ValueMember = " ";
            ComentarioTextBox.Clear();
        }
        private void LlenaCampo(Pasantes pasante)
        {
            PasanteIdNumericUpDown.Value = pasante.PasanteId;
            FechaCreacionDateTimePicker.Value = pasante.FechaCreacion.Date;
            InstitucionComboBox.Text = pasante.Institucion;
            NombrePasanteTextBox.Text = pasante.Nombre;
            MatriculaTextBox.Text = pasante.Matricula.ToString();
            EmailTextBox.Text = pasante.Email;
            HorasARealizarTextBox.Text = pasante.HorasARealizar.ToString();
            TelefonoTextBox.Text = pasante.Telefono;

            HabilidadComboBox.ValueMember = " ";
            ComentarioTextBox.Clear();
        }
        private Pasantes LlenaClase()
        {
            Pasantes pasante = new Pasantes();
            pasante.PasanteId = Convert.ToInt32(PasanteIdNumericUpDown.Value);
            pasante.FechaCreacion = FechaCreacionDateTimePicker.Value.Date;
            pasante.Nombre = NombrePasanteTextBox.Text;
            pasante.Institucion = InstitucionComboBox.Text;
            pasante.Matricula = int.Parse(MatriculaTextBox.Text);
            pasante.Email = EmailTextBox.Text;
            pasante.HorasARealizar = int.Parse(HorasARealizarTextBox.Text);
            pasante.Telefono = TelefonoTextBox.Text;
            

            return pasante;
        }
    }
}
