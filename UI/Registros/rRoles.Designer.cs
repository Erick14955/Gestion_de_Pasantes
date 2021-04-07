
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRoles));
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.RolIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.DetallegroupBox = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.AsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.PermisoIdComboBox = new System.Windows.Forms.ComboBox();
            this.PermisoIdlabel = new System.Windows.Forms.Label();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.FechaCreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).BeginInit();
            this.DetallegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(22, 235);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(510, 27);
            this.DescripcionTextBox.TabIndex = 17;
            // 
            // RolIdNumericUpDown
            // 
            this.RolIdNumericUpDown.Location = new System.Drawing.Point(22, 53);
            this.RolIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RolIdNumericUpDown.Name = "RolIdNumericUpDown";
            this.RolIdNumericUpDown.Size = new System.Drawing.Size(288, 27);
            this.RolIdNumericUpDown.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Roles Id";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Gestion_de_Pasantes.Properties.Resources.buscar;
            this.BuscarButton.Location = new System.Drawing.Point(338, 52);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(64, 29);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::Gestion_de_Pasantes.Properties.Resources.nuevo;
            this.NuevoButton.Location = new System.Drawing.Point(87, 697);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(103, 62);
            this.NuevoButton.TabIndex = 21;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Gestion_de_Pasantes.Properties.Resources.guardar;
            this.GuardarButton.Location = new System.Drawing.Point(226, 697);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(103, 62);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::Gestion_de_Pasantes.Properties.Resources.eliminar;
            this.EliminarButton.Location = new System.Drawing.Point(365, 697);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(103, 62);
            this.EliminarButton.TabIndex = 23;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // DetallegroupBox
            // 
            this.DetallegroupBox.Controls.Add(this.RemoverButton);
            this.DetallegroupBox.Controls.Add(this.DetalleDataGridView);
            this.DetallegroupBox.Controls.Add(this.AgregarButton);
            this.DetallegroupBox.Controls.Add(this.AsignadoCheckBox);
            this.DetallegroupBox.Controls.Add(this.PermisoIdComboBox);
            this.DetallegroupBox.Controls.Add(this.PermisoIdlabel);
            this.DetallegroupBox.Location = new System.Drawing.Point(18, 293);
            this.DetallegroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetallegroupBox.Name = "DetallegroupBox";
            this.DetallegroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetallegroupBox.Size = new System.Drawing.Size(518, 379);
            this.DetallegroupBox.TabIndex = 24;
            this.DetallegroupBox.TabStop = false;
            this.DetallegroupBox.Text = "Detalle";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.Location = new System.Drawing.Point(4, 335);
            this.RemoverButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(98, 29);
            this.RemoverButton.TabIndex = 5;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(5, 67);
            this.DetalleDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.RowTemplate.Height = 25;
            this.DetalleDataGridView.Size = new System.Drawing.Size(510, 260);
            this.DetalleDataGridView.TabIndex = 4;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.Location = new System.Drawing.Point(415, 28);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(98, 29);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // AsignadoCheckBox
            // 
            this.AsignadoCheckBox.AutoSize = true;
            this.AsignadoCheckBox.Location = new System.Drawing.Point(315, 32);
            this.AsignadoCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsignadoCheckBox.Name = "AsignadoCheckBox";
            this.AsignadoCheckBox.Size = new System.Drawing.Size(94, 24);
            this.AsignadoCheckBox.TabIndex = 2;
            this.AsignadoCheckBox.Text = "Asignado";
            this.AsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermisoIdComboBox
            // 
            this.PermisoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PermisoIdComboBox.FormattingEnabled = true;
            this.PermisoIdComboBox.Location = new System.Drawing.Point(86, 28);
            this.PermisoIdComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PermisoIdComboBox.Name = "PermisoIdComboBox";
            this.PermisoIdComboBox.Size = new System.Drawing.Size(210, 28);
            this.PermisoIdComboBox.TabIndex = 1;
            // 
            // PermisoIdlabel
            // 
            this.PermisoIdlabel.AutoSize = true;
            this.PermisoIdlabel.Location = new System.Drawing.Point(7, 32);
            this.PermisoIdlabel.Name = "PermisoIdlabel";
            this.PermisoIdlabel.Size = new System.Drawing.Size(65, 20);
            this.PermisoIdlabel.TabIndex = 0;
            this.PermisoIdlabel.Text = "Permiso ";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(459, 52);
            this.ActivoCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(73, 24);
            this.ActivoCheckBox.TabIndex = 25;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre Rol";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(22, 173);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(510, 27);
            this.NombreTextBox.TabIndex = 27;
            // 
            // FechaCreacionDateTimePicker
            // 
            this.FechaCreacionDateTimePicker.CustomFormat = "dd / MM / yyyy";
            this.FechaCreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCreacionDateTimePicker.Location = new System.Drawing.Point(22, 115);
            this.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker";
            this.FechaCreacionDateTimePicker.Size = new System.Drawing.Size(510, 27);
            this.FechaCreacionDateTimePicker.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha Creacion";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 785);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaCreacionDateTimePicker);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.DetallegroupBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.RolIdNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "rRoles";
            this.Text = "Registro Roles";
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).EndInit();
            this.DetallegroupBox.ResumeLayout(false);
            this.DetallegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown RolIdNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.GroupBox DetallegroupBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.CheckBox AsignadoCheckBox;
        private System.Windows.Forms.ComboBox PermisoIdComboBox;
        private System.Windows.Forms.Label PermisoIdlabel;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.DateTimePicker FechaCreacionDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}