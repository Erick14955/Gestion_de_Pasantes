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
            NombrePasanteTextBox.Clear();
            EstadoTareaComboBox.Text = " ";
        }

        public void LlenarCampos(Tareas tareas)
        {
            TareaIdNumericUpDown.Value = tareas.TareaId;
            FechaInicioDateTimePicker.Value = tareas.FechaInicio;
            FechaVencimientoDateTimePicker.Value = tareas.FechaFinal;
            ActivoCheckBox.Checked = tareas.Activo;
            NombreTareaTextBox.Text = tareas.Nombre;
            DescripcionTexBox.Text = tareas.Descripcion;
            PrioridadComboBox.Text = tareas.Prioridad;
            NombrePasanteTextBox.Text = tareas.Asignado;
            EstadoTareaComboBox.Text = tareas.Estado;
        }

        private Tareas LlenarClase()
        {
            Tareas tareas = new Tareas();
            tareas.TareaId = (int)TareaIdNumericUpDown.Value;
            tareas.FechaFinal = FechaVencimientoDateTimePicker.Value;
            tareas.FechaInicio = FechaInicioDateTimePicker.Value;
            tareas.Activo = ActivoCheckBox.Checked;
            tareas.Nombre = NombreTareaTextBox.Text;
            tareas.Descripcion = DescripcionTexBox.Text;
            tareas.Prioridad = PrioridadComboBox.Text;
            tareas.Asignado = NombrePasanteTextBox.Text;
            tareas.Estado = EstadoTareaComboBox.Text;

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
            if (string.IsNullOrEmpty(NombrePasanteTextBox.Text))
            {
                MyerrorProvider.SetError(NombrePasanteTextBox, "Este campo no puede quedar vacio");
                NombrePasanteTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrEmpty(DescripcionTexBox.Text))
            {
                MyerrorProvider.SetError(DescripcionTexBox, "Este campo no puede quedar vacio");
                DescripcionTexBox.Focus();
                paso = false;

            }
            if (string.IsNullOrWhiteSpace(PrioridadComboBox.Text))
            {
                MyerrorProvider.SetError(PrioridadComboBox, "Este campo no puede quedar vacio");
                PrioridadComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EstadoTareaComboBox.Text))
            {
                MyerrorProvider.SetError(EstadoTareaComboBox, "Este campo no puede quedar vacio");
                EstadoTareaComboBox.Focus();
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
