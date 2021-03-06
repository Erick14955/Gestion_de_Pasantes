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
    public partial class rPasantes : Form
    {
        public List<HabilidadesDetalle> Detalle { get; set; }
        public rPasantes()
        {
            InitializeComponent();
            this.Detalle = new List<HabilidadesDetalle>();
        }
        private void Limpiar()
        {
            PasanteIdNumericUpDown.Value = 0;
            FechaCreacionDateTimePicker.Value = DateTime.Now.Date;
            NombrePasanteTextBox.Clear();
            MatriculaTextBox.Clear();
            EmailTextBox.Clear();
            HorasARealizarTextBox.Clear();
            TelefonoTextBox.Clear();
            ComentarioTextBox.Clear();
            MyErrorProvider.Clear();

            this.Detalle = new List<HabilidadesDetalle>();
            CargarGrid();
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


            this.Detalle = pasante.Detalle;
            CargarGrid();
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

            pasante.Detalle = this.Detalle;

            return pasante;
        }
        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
            DetalleDataGridView.Columns["PasanteId"].Visible = false;
            DetalleDataGridView.Columns["DetalleId"].Visible = false;
        }
        private bool Validar()
        {
            bool paso = true;
            if (InstitucionComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(InstitucionComboBox, "Debes agreagr datos aqui.");
                InstitucionComboBox.Focus();

                paso = false;
            }
            if (NombrePasanteTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombrePasanteTextBox, "Debes agreagr datos aqui.");
                NombrePasanteTextBox.Focus();

                paso = false;
            }
            if (MatriculaTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(MatriculaTextBox, "Debes agreagr datos aqui.");
                MatriculaTextBox.Focus();

                paso = false;
            }
            if (EmailTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(EmailTextBox, "Debes agreagr datos aqui.");
                EmailTextBox.Focus();

                paso = false;
            }
            if (HorasARealizarTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(HorasARealizarTextBox, "Debes agreagr datos aqui.");
                HorasARealizarTextBox.Focus();

                paso = false;
            }
            if (TelefonoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(TelefonoTextBox, "Debes agreagr datos aqui.");
                TelefonoTextBox.Focus();

                paso = false;
            }

            return paso;
        }
        private void rPasantes_Load(object sender, EventArgs e)
        {
            InstitucionComboBox.DataSource = InstitucionesBLL.GetInstituciones();
            InstitucionComboBox.DisplayMember = "Nombre";
            InstitucionComboBox.ValueMember = "InstitucionId";

            HabilidadComboBox.DataSource = HabilidadesBLL.GetHabilidades();
            HabilidadComboBox.DisplayMember = "Nombre";
            HabilidadComboBox.ValueMember = "HabilidadId";
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            Pasantes pasante;
            int id;
            int.TryParse(PasanteIdNumericUpDown.Text, out id);

            Limpiar();

            pasante = PasantesBLL.Buscar(id);

            if (pasante != null)
                LlenaCampo(pasante);
            else
                MessageBox.Show("Pasante no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<HabilidadesDetalle>)DetalleDataGridView.DataSource;

            if(HabilidadComboBox.Text == string.Empty)
            {
                MessageBox.Show("Selecciona una habilidad en el combobox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Habilidades habilidad = HabilidadesBLL.Buscar(HabilidadComboBox.SelectedIndex+1);

            try 
            {
                this.Detalle.Add(new HabilidadesDetalle(
                    DetalleId: 0,
                    PasanteId: (int)PasanteIdNumericUpDown.Value,
                    HabilidadId: habilidad.HabilidadId,
                    Nombre: habilidad.Nombre,
                    Descripcion: habilidad.Descripcion,
                    Comentario: ComentarioTextBox.Text
                    )                     
                );
                CargarGrid();
                HabilidadComboBox.Focus();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            if ((DetalleDataGridView.Rows.Count >= 0) && (DetalleDataGridView.CurrentRow != null))
            {

                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
            else
            {
                MyErrorProvider.SetError(DetalleDataGridView, "Debes agregar Datos.");
                DetalleDataGridView.Focus();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            Pasantes pasante;
            MyErrorProvider.Clear();
            if (!Validar())
                return;

            pasante = LlenaClase();
            bool paso = PasantesBLL.Guardar(pasante);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(PasanteIdNumericUpDown.Text, out id);

            if (PasanteIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Debes agregar un id valido para poder eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!PasantesBLL.Existe(id))
                MessageBox.Show("Pasante Inexistente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Deseas eliminar este pasante?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (PasantesBLL.Eliminar(id))
                    {
                        MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                        MyErrorProvider.SetError(PasanteIdNumericUpDown, "Agrega un id Valido. Este no Existe");
                }
            }
        }
    }
}
