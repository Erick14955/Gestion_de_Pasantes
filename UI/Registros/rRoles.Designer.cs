
namespace Gestion_de_Pasantes.UI.Registros
{
    partial class rRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.DetallegroupBox = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.AsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.PermisosComboBox = new System.Windows.Forms.ComboBox();
            this.PermisoIdlabel = new System.Windows.Forms.Label();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.FechaCreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.DetallegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(19, 176);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(447, 23);
            this.DescripcionTextBox.TabIndex = 17;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(19, 40);
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(252, 23);
            this.NumericUpDown1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Roles Id";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(296, 39);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(74, 22);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(92, 510);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(84, 39);
            this.LimpiarButton.TabIndex = 21;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(200, 511);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(84, 39);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(308, 511);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(84, 39);
            this.EliminarButton.TabIndex = 23;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // DetallegroupBox
            // 
            this.DetallegroupBox.Controls.Add(this.RemoverButton);
            this.DetallegroupBox.Controls.Add(this.DetalleDataGridView);
            this.DetallegroupBox.Controls.Add(this.AgregarButton);
            this.DetallegroupBox.Controls.Add(this.AsignadoCheckBox);
            this.DetallegroupBox.Controls.Add(this.PermisosComboBox);
            this.DetallegroupBox.Controls.Add(this.PermisoIdlabel);
            this.DetallegroupBox.Location = new System.Drawing.Point(16, 220);
            this.DetallegroupBox.Name = "DetallegroupBox";
            this.DetallegroupBox.Size = new System.Drawing.Size(453, 284);
            this.DetallegroupBox.TabIndex = 24;
            this.DetallegroupBox.TabStop = false;
            this.DetallegroupBox.Text = "Detalle";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(11, 251);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(92, 27);
            this.RemoverButton.TabIndex = 5;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(4, 50);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.RowTemplate.Height = 25;
            this.DetalleDataGridView.Size = new System.Drawing.Size(446, 195);
            this.DetalleDataGridView.TabIndex = 4;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(363, 21);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(82, 23);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // AsignadoCheckBox
            // 
            this.AsignadoCheckBox.AutoSize = true;
            this.AsignadoCheckBox.Location = new System.Drawing.Point(276, 24);
            this.AsignadoCheckBox.Name = "AsignadoCheckBox";
            this.AsignadoCheckBox.Size = new System.Drawing.Size(76, 19);
            this.AsignadoCheckBox.TabIndex = 2;
            this.AsignadoCheckBox.Text = "Asignado";
            this.AsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermisosComboBox
            // 
            this.PermisosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PermisosComboBox.FormattingEnabled = true;
            this.PermisosComboBox.Location = new System.Drawing.Point(75, 21);
            this.PermisosComboBox.Name = "PermisosComboBox";
            this.PermisosComboBox.Size = new System.Drawing.Size(184, 23);
            this.PermisosComboBox.TabIndex = 1;
            // 
            // PermisoIdlabel
            // 
            this.PermisoIdlabel.AutoSize = true;
            this.PermisoIdlabel.Location = new System.Drawing.Point(6, 24);
            this.PermisoIdlabel.Name = "PermisoIdlabel";
            this.PermisoIdlabel.Size = new System.Drawing.Size(63, 15);
            this.PermisoIdlabel.TabIndex = 0;
            this.PermisoIdlabel.Text = "Permiso Id";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(402, 39);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoCheckBox.TabIndex = 25;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre Rol";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(19, 130);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(447, 23);
            this.NombreTextBox.TabIndex = 27;
            // 
            // FechaCreacionDateTimePicker
            // 
            this.FechaCreacionDateTimePicker.CustomFormat = "dd / MM / yyyy";
            this.FechaCreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCreacionDateTimePicker.Location = new System.Drawing.Point(19, 86);
            this.FechaCreacionDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker";
            this.FechaCreacionDateTimePicker.Size = new System.Drawing.Size(447, 23);
            this.FechaCreacionDateTimePicker.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha Creacion";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaCreacionDateTimePicker);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.DetallegroupBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "rRoles";
            this.Text = "Registro Roles";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.DetallegroupBox.ResumeLayout(false);
            this.DetallegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown NumericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.GroupBox DetallegroupBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.CheckBox AsignadoCheckBox;
        private System.Windows.Forms.ComboBox PermisosComboBox;
        private System.Windows.Forms.Label PermisoIdlabel;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.DateTimePicker FechaCreacionDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}