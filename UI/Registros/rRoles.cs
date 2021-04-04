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
        public List<RolesDetalle> Roles { get; set; }

        public rRoles()
        {
            InitializeComponent();
        }
        private void LimpiarClase()
        {
            NumericUpDown1.Value = 0;
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
            PermisosComboBox.Text = "";
            AsignadoCheckBox.Checked = false;
            ActivoCheckBox.Checked = false;
        }
        private Roles LlenarClase()
        {
            Roles roles = new Roles();

            roles.RolId = (int)NumericUpDown1.Value;
            roles.Nombre = NombreTextBox.Text;
            roles.Descripcion = DescripcionTextBox.Text;
            roles.esActivo = ActivoCheckBox.Checked;
            roles.FechaCreacion = FechaCreacionDateTimePicker.Value;

            return roles;
        }
        private void LlenarCampo(Roles roles)
        {
            NumericUpDown1.Value = roles.RolId;
            NombreTextBox.Text = roles.Nombre;
            DescripcionTextBox.Text = roles.Descripcion;
            ActivoCheckBox.Checked = roles.esActivo;
            FechaCreacionDateTimePicker.Value = roles.FechaCreacion;
        }
    }
}
