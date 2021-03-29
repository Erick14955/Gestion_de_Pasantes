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
    public partial class rTareas : Form
    {
        public rTareas()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            TareaIdNumericUpDown.Value = 0;
            FechaInicioDateTimePicker.Value = DateTime.Now;
            FechaVencimientoDateTimePicker.Value = DateTime.Now;
            ActivoCheckBox.Checked = false;
            NombreTareaTextBox.Clear();
            DescripcionTexBox.Clear();
            PrioridadComboBox.Text = " ";
            AsignadaATextBox.Clear();
            InstitucionPasanteTextBox.Clear();
            ProgresoComboBox.Text = " ";
        }

        public void LlenarCampos(Tareas tareas)
        {
            TareaIdNumericUpDown.Value = tareas.TareaId;
            FechaInicioDateTimePicker.Value = tareas.FechaInicio;
            FechaVencimientoDateTimePicker.Value = tareas.FechaFinal;
            ActivoCheckBox.Checked = tareas.Activo;
            NombreTareaTextBox.Text = tareas.NombreTarea;
            DescripcionTexBox.Text = tareas.Descripcion;
            PrioridadComboBox.Text = tareas.Prioridad;
            AsignadaATextBox.Text = tareas.Asignado;
            InstitucionPasanteTextBox.Text = tareas.Institucion;
            ProgresoComboBox.Text = tareas.Progreso;
        }

        private Tareas LlenarClase()
        {
            Tareas tareas = new Tareas();
            tareas.TareaId = (int)TareaIdNumericUpDown.Value;
            tareas.FechaFinal = FechaVencimientoDateTimePicker.Value;
            tareas.FechaInicio = FechaInicioDateTimePicker.Value;
            tareas.Activo = ActivoCheckBox.Checked;
            tareas.NombreTarea = NombreTareaTextBox.Text;
            tareas.Descripcion = DescripcionTexBox.Text;
            tareas.Prioridad = PrioridadComboBox.Text;
            tareas.Asignado = AsignadaATextBox.Text;
            tareas.Institucion = InstitucionPasanteTextBox.Text;
            tareas.Progreso = ProgresoComboBox.Text;

            return tareas;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrEmpty(NombreTareaTextBox.Text))
            {
                MyerrorProvider.SetError(NombreTareaTextBox, "Este campo no puede quedar vacio");
                NombreTareaTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrEmpty(AsignadaATextBox.Text))
            {
                MyerrorProvider.SetError(AsignadaATextBox, "Este campo no puede quedar vacio");
                AsignadaATextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrEmpty(DescripcionTexBox.Text))
            {
                MyerrorProvider.SetError(DescripcionTexBox, "Este campo no puede quedar vacio");
                DescripcionTexBox.Focus();
                paso = false;
            }
            if (string.IsNullOrEmpty(InstitucionPasanteTextBox.Text))
            {
                MyerrorProvider.SetError(InstitucionPasanteTextBox, "Este campo no puede quedar vacio");
                InstitucionPasanteTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(PrioridadComboBox.Text))
            {
                MyerrorProvider.SetError(PrioridadComboBox, "Este campo no puede quedar vacio");
                PrioridadComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ProgresoComboBox.Text))
            {
                MyerrorProvider.SetError(ProgresoComboBox, "Este campo no puede quedar vacio");
                ProgresoComboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Tareas tareas = new Tareas();
            int.TryParse(TareaIdNumericUpDown.Text, out id);

            Limpiar();

            tareas = TareasBLL.Buscar(id);

            if (tareas != null)
            {
                LlenarCampos(tareas);
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
            Tareas tareas;

            if (!Validar())
                return;

            tareas = LlenarClase();

            var paso = TareasBLL.Guardar(tareas);

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
            MyerrorProvider.Clear();

            int id;
            int.TryParse(TareaIdNumericUpDown.Text, out id);

            Limpiar();

            if (PasantesBLL.Eliminar(id))
                MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(TareaIdNumericUpDown, "No se puede eliminar una tarea que no existe");
        }
    }
}
