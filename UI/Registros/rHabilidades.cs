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
            MyErrorProvider.Clear();
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
            if (HabilidadesBLL.ExisteNombre(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox,"Esta habilidad ya existe.");
                NombreTextBox.Focus();

                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            Habilidades habilidad = new Habilidades();
            int.TryParse(HabilidadIdNumericUpDown.Text, out id);

            Limpiar();

            habilidad = HabilidadesBLL.Buscar(id);

            if (habilidad != null)
            {
                LlenaCampo(habilidad);
            }
            else
            {
                MessageBox.Show("Habilidad no Encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            Habilidades habilidad;

            if (!Validar())
                return;

            habilidad = LlenaClase();

            var paso = HabilidadesBLL.Guardar(habilidad);

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
        public bool ExisteEnLaBaseDeDatos()
        {
            Roles roles = RolesBLL.Buscar((int)HabilidadIdNumericUpDown.Value);
            return (roles != null);
        }
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(HabilidadIdNumericUpDown.Text, out id);

            if (HabilidadIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Debes agregar un Id valido para poder eliminar una Habilidad", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ExisteEnLaBaseDeDatos())
            {
                if (MessageBox.Show("Deseas eliminar esta Habilidad?", "Elije una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (HabilidadesBLL.Eliminar(id))
                    {
                        MessageBox.Show("Habilidad eliminada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                        MyErrorProvider.SetError(HabilidadIdNumericUpDown, "Agrega un Id Valido! Este no existe.");
                }

            }
            else
                MessageBox.Show("Esta habilidad no existe en la base de datos, prueba a eliminar otra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
