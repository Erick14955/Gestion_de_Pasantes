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

namespace Gestion_de_Pasantes.UI.Registros
{
    public partial class rInstituciones : Form
    {
        public rInstituciones()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Clear();
            RegiontextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            CorreotextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            FaxtextBox.Clear();
            privadaradioButton.Checked = false;
            publicaradioButton.Checked = false;
            ActivocheckBox.Checked = false;
            MyerrorProvider.Clear();
        }

        public void LlenarCampos(Instituciones instituciones)
        {
            ActivocheckBox.Checked = instituciones.Activo;
            IdnumericUpDown.Value = instituciones.InstitucionId;
            NombretextBox.Text = instituciones.NombreInstitucion;
            RegiontextBox.Text = instituciones.Region;
            DirecciontextBox.Text = instituciones.Direccion;
            TelefonotextBox.Text = instituciones.Telefono;
            CorreotextBox.Text = instituciones.Correo;
            FechadateTimePicker.Value = instituciones.Fecha;
            FaxtextBox.Text = instituciones.NumFax;
            privadaradioButton.Checked = instituciones.Privada;
            publicaradioButton.Checked = instituciones.Publica;
        }

        private Instituciones LlenarClase()
        {
            Instituciones instituciones = new Instituciones();

            instituciones.Activo = ActivocheckBox.Checked;
            instituciones.InstitucionId = (int)IdnumericUpDown.Value;
            instituciones.NombreInstitucion = NombretextBox.Text;
            instituciones.Region = RegiontextBox.Text;
            instituciones.Direccion = DirecciontextBox.Text;
            instituciones.Telefono = TelefonotextBox.Text;
            instituciones.Correo = CorreotextBox.Text;
            instituciones.Fecha = FechadateTimePicker.Value;
            instituciones.NumFax = FaxtextBox.Text;
            instituciones.Privada = privadaradioButton.Checked;
            instituciones.Publica = publicaradioButton.Checked;

            return instituciones;
        }

        public bool Validar()
        {
            bool paso = true;

            if(NombretextBox.Text == string.Empty)
            {
                MyerrorProvider.SetError(NombretextBox, "Este campo no puede quedar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CorreotextBox.Text))
            {
                MyerrorProvider.SetError(CorreotextBox, "Este campo no puede quedar vacio");
                CorreotextBox.Focus();
                paso = false;
            }
            if(RegiontextBox.Text == string.Empty)
            {
                MyerrorProvider.SetError(RegiontextBox, "Este campo no puede quedar vacio");
                RegiontextBox.Focus();
                paso = false;
            }
            if(DirecciontextBox.Text == string.Empty)
            {
                MyerrorProvider.SetError(DirecciontextBox, "Este campo no puede quedar vacio");
                DirecciontextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonotextBox.Text))
            {
                MyerrorProvider.SetError(TelefonotextBox, "Este campo no puede quedar vacio");
                TelefonotextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(FaxtextBox.Text))
            {
                MyerrorProvider.SetError(FaxtextBox, "Este campo no puede quedar vacio");
                FaxtextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Instituciones instituciones = new Instituciones();
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            instituciones = InstitucionesBLL.Buscar(id);

            if (instituciones != null)
            {
                LlenarCampos(instituciones);
            }
            else
            {
                MessageBox.Show("Institución no Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Instituciones instituciones;

            if (!Validar())
                return;

            if (InstitucionesBLL.ExisteInstitucion(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox, "Esta institución ya existe en la base de datos");
                NombretextBox.Focus();
            }

            instituciones = LlenarClase();

            var paso = InstitucionesBLL.Guardar(instituciones);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            int id;
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            if (InstitucionesBLL.Eliminar(id))
                MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(IdnumericUpDown, "No se puede eliminar una institucion que no existe");
        }

    }
}
