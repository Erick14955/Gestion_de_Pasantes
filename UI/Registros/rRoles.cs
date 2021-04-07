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
    public partial class rRoles : Form
    {
        public List<RolesDetalle> Detalle { get; set; }

        public rRoles()
        {
            InitializeComponent();
            this.Detalle = new List<RolesDetalle>();
            PermisoIdComboBox.DataSource = PermisosBLL.GetPermisos();
            PermisoIdComboBox.DisplayMember = "NombrePermiso";
            PermisoIdComboBox.ValueMember = "DescripcionPermiso";
        }
        private void Limpiar()
        {
            RolIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
            PermisoIdComboBox.Text = "";
            AsignadoCheckBox.Checked = false;
            ActivoCheckBox.Checked = false;
            MyErrorProvider.Clear();

            this.Detalle = new List<RolesDetalle>();
            CargarGrid();
        }
        private Roles LlenaClase()
        {
            Roles roles = new Roles();

            roles.RolId = (int)RolIdNumericUpDown.Value;
            roles.Nombre = NombreTextBox.Text;
            roles.Descripcion = DescripcionTextBox.Text;
            roles.esActivo = ActivoCheckBox.Checked;
            roles.FechaCreacion = FechaCreacionDateTimePicker.Value;
            roles.Detalle = this.Detalle;
            CargarGrid();

            return roles;
        }
        private void LlenaCampo(Roles roles)
        {
            RolIdNumericUpDown.Value = roles.RolId;
            NombreTextBox.Text = roles.Nombre;
            DescripcionTextBox.Text = roles.Descripcion;
            ActivoCheckBox.Checked = roles.esActivo;
            FechaCreacionDateTimePicker.Value = roles.FechaCreacion;
            this.Detalle = roles.Detalle;
            CargarGrid();
        }
        public void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
            DetalleDataGridView.Columns["ID"].Visible = false;
            DetalleDataGridView.Columns["RolID"].Visible = false;
        }
        private bool Validar()
        {
            bool paso = true;

            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "Debes agregar un Nombre a este Rol.");
                NombreTextBox.Focus();

                paso = false;
            }
            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Debes agregar una descripcion a este Rol.");
                DescripcionTextBox.Focus();

                paso = false;
            }
            if (PermisoIdComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(PermisoIdComboBox, "Debe elegír un Permiso.");
                NombreTextBox.Focus();

                paso = false;
            }

            return paso;
        }
        public bool ExisteEnLaBaseDeDatos()
        {
            Roles roles = RolesBLL.Buscar((int)RolIdNumericUpDown.Value);
            return (roles != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            Roles roles;
            int id;
            int.TryParse(RolIdNumericUpDown.Text, out id);

            Limpiar();

            roles = RolesBLL.Buscar(id);

            if (roles != null)
            {
                LlenaCampo(roles);
            }
            else
                MessageBox.Show("Este Rol no existe, prueba buscar otro!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<RolesDetalle>)DetalleDataGridView.DataSource;

            if (PermisoIdComboBox.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un permiso antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Permisos permiso = PermisosBLL.Buscar(PermisoIdComboBox.SelectedIndex + 1);
            this.Detalle.Add(
                new RolesDetalle(
                    ID: 0,
                    RolID: (int)RolIdNumericUpDown.Value,
                    PermisoID: permiso.PermisoID,
                    esAsignado: AsignadoCheckBox.Checked
                )
            );
            CargarGrid();
            PermisoIdComboBox.Focus();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            if ((DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null))
            {
                this.Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
            else
            {
                MyErrorProvider.SetError(DetalleDataGridView, "No hay datos aqui.");
                
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            Roles roles;

            if (!Validar())
                return;

            roles = LlenaClase();

            var paso = RolesBLL.Guardar(roles);

            if (paso)
            {
                MessageBox.Show("Rol guardado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar este permiso, intentalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(RolIdNumericUpDown.Text, out id);

            if (RolIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Debes agregar un Id valido para poder eliminar un Rol", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ExisteEnLaBaseDeDatos())
            {
                if (MessageBox.Show("Deseas eliminar este Rol?", "Elije una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (RolesBLL.Eliminar(id))
                    {
                        MessageBox.Show("Rol eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                        MyErrorProvider.SetError(RolIdNumericUpDown, "Agrega un Id Valido! Este no existe.");
                }

            }
            else
                MessageBox.Show("Este Rol no existe en la base de datos, prueba a eliminar otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
