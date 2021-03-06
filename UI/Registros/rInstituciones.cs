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

        private void Limpiar()
        {
            InstitucionIdNumericUpDown.Value = 0;
            NombretextBox.Clear();
            RegiontextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            CorreotextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            FaxtextBox.Clear();
            PrivadaRadioButton.Checked = false;
            PublicaRadioButton.Checked = false;
            ActivocheckBox.Checked = false;
            MyErrorProvider.Clear();
        }

        private void LlenarCampos(Instituciones instituciones)
        {
            ActivocheckBox.Checked = instituciones.Activo;
            InstitucionIdNumericUpDown.Value = instituciones.InstitucionId;
            NombretextBox.Text = instituciones.Nombre;
            RegiontextBox.Text = instituciones.Region;
            DirecciontextBox.Text = instituciones.Direccion;
            TelefonotextBox.Text = instituciones.Telefono;
            CorreotextBox.Text = instituciones.Correo;
            FechadateTimePicker.Value = instituciones.Fecha;
            FaxtextBox.Text = instituciones.NumFax;

            PublicaRadioButton.Checked = instituciones.TipoInstitucion == "Publica" ?  true : false;
            PrivadaRadioButton.Checked = instituciones.TipoInstitucion == "Publica" ? false : true;
        }

        private Instituciones LlenarClase()
        {
            Instituciones instituciones = new Instituciones();

            instituciones.Activo = ActivocheckBox.Checked;
            instituciones.InstitucionId = (int)InstitucionIdNumericUpDown.Value;
            instituciones.Nombre = NombretextBox.Text;
            instituciones.Region = RegiontextBox.Text;
            instituciones.Direccion = DirecciontextBox.Text;
            instituciones.Telefono = TelefonotextBox.Text;
            instituciones.Correo = CorreotextBox.Text;
            instituciones.Fecha = FechadateTimePicker.Value;
            instituciones.NumFax = FaxtextBox.Text;
            instituciones.TipoInstitucion = PublicaRadioButton.Checked == true ? "Publica" : "Privada";

            return instituciones;
        }

        public bool Validar()
        {
            bool paso = true;

            if(NombretextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombretextBox, "Este campo no puede quedar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CorreotextBox.Text))
            {
                MyErrorProvider.SetError(CorreotextBox, "Este campo no puede quedar vacio");
                CorreotextBox.Focus();
                paso = false;
            }
            if(RegiontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(RegiontextBox, "Este campo no puede quedar vacio");
                RegiontextBox.Focus();
                paso = false;
            }
            if(DirecciontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DirecciontextBox, "Este campo no puede quedar vacio");
                DirecciontextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonotextBox.Text))
            {
                MyErrorProvider.SetError(TelefonotextBox, "Este campo no puede quedar vacio");
                TelefonotextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(FaxtextBox.Text))
            {
                MyErrorProvider.SetError(FaxtextBox, "Este campo no puede quedar vacio");
                FaxtextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            Instituciones instituciones = new Instituciones();
            int.TryParse(InstitucionIdNumericUpDown.Text, out id);

            Limpiar();

            instituciones = InstitucionesBLL.Buscar(id);

            if (instituciones != null)
            {
                LlenarCampos(instituciones);
            }
            else
            {
                MessageBox.Show("Institución no Encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            Instituciones instituciones;

            if (!Validar())
                return;

            if (InstitucionesBLL.ExisteInstitucion(NombretextBox.Text))
            {
                MyErrorProvider.SetError(NombretextBox, "Esta institución ya existe en la base de datos");
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
            MyErrorProvider.Clear();
            int id;
            int.TryParse(InstitucionIdNumericUpDown.Text, out id);

            if (InstitucionIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Debes agregar un id valido para poder eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!InstitucionesBLL.Existe(id))
                MessageBox.Show("Institucion Inexistente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Deseas eliminar esta institucion?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (InstitucionesBLL.Eliminar(id))
                    {
                        MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
            }
        }

    }
}
