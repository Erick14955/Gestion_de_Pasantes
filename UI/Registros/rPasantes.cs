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
using Gestion_de_Pasantes.BLL;

namespace Gestion_de_Pasantes.UI.Registros
{
    public partial class rPasantes : Form
    {
        public rPasantes()
        {
            InitializeComponent();
        }
        
        public void Limpiar()
        {
            PasanteIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmarClavetextBox.Clear();
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            //HabilidadComboBox.Text = " ";
            ActivoCheckBox.Checked = false;
            InstitucioncomboBox.Text = " ";
            EmailTextBox.Clear();
            MatriculaTextBox.Clear();
            totalhorastextBox.Clear();
            MyErrorProvider.Clear();
        }
        public void LlenaCampos(Pasantes pasantes)
        {
            ActivoCheckBox.Checked = pasantes.Activo;
            PasanteIdNumericUpDown.Value = pasantes.Id;
            NombreTextBox.Text = pasantes.NombrePasante;
            ClaveTextBox.Text = pasantes.Clave;
            ConfirmarClavetextBox.Text = pasantes.Clave;
            EmailTextBox.Text = pasantes.Email;
            FechaCreacionDateTimePicker.Value = pasantes.Fecha;
            InstitucioncomboBox.Text = pasantes.Institucion;
            totalhorastextBox.Text = Convert.ToString(pasantes.TotalHoras);
            MatriculaTextBox.Text = Convert.ToString(pasantes.Matricula);
        }
        private Pasantes LlenaClase()
        {
            Pasantes pasantes = new Pasantes();
            pasantes.Id = (int)PasanteIdNumericUpDown.Value;
            pasantes.Activo = ActivoCheckBox.Checked;
            pasantes.Email = EmailTextBox.Text;
            pasantes.Fecha = FechaCreacionDateTimePicker.Value;
            pasantes.Clave = ClaveTextBox.Text;
            pasantes.NombrePasante = NombreTextBox.Text;
            pasantes.TotalHoras = Convert.ToInt32(totalhorastextBox.Text);
            pasantes.Matricula = Convert.ToInt32(MatriculaTextBox.Text);
            pasantes.Institucion = InstitucioncomboBox.Text;

            return pasantes;
        }
        private void rUsuarios_Load(object sender, EventArgs e)
        {
            InstitucioncomboBox.DataSource = InstitucionesBLL.GetInstituciones();
            InstitucioncomboBox.DisplayMember = "NombreInstitucion";
            InstitucioncomboBox.ValueMember = "Id";
        }
        private bool Validar()
        {
            bool paso = true;

            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyErrorProvider.SetError(EmailTextBox, "El Email no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                MyErrorProvider.SetError(ClaveTextBox, "Debe asignar una clave a su usuario");
                ClaveTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ConfirmarClavetextBox.Text))
            {
                MyErrorProvider.SetError(ConfirmarClavetextBox, "Debe confirmar la clave");
                ConfirmarClavetextBox.Focus();
                paso = false;
            }
            if (ClaveTextBox.Text != ConfirmarClavetextBox.Text)
            {
                MyErrorProvider.SetError(ConfirmarClavetextBox, "Las contrseñas deben ser iguales.");
                ConfirmarClavetextBox.Focus();
                MyErrorProvider.SetError(ClaveTextBox, "Las contraseñas deben ser iguales.");
                ClaveTextBox.Focus();
                paso = false;
            }

            return paso;
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Pasantes pasantes = new Pasantes();
            int.TryParse(PasanteIdNumericUpDown.Text, out id);

            Limpiar();

            pasantes = PasantesBLL.Buscar(id);

            if (pasantes != null)
            {
                LlenaCampos(pasantes);
            }
            else
            {
                MessageBox.Show("Pasante no Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Pasantes pasantes;

            if (!Validar())
                return;

            pasantes = LlenaClase();

            var paso = PasantesBLL.Guardar(pasantes);

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

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(PasanteIdNumericUpDown.Text, out id);

            Limpiar();

            if (PasantesBLL.Eliminar(id))
                MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(PasanteIdNumericUpDown, "No se puede eliminar un pasante que no existe");
        }
        
    }
}