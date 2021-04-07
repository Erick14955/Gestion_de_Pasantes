
namespace Gestion_de_Pasantes.UI.Registros
{
    partial class rTareas
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
            this.label1 = new System.Windows.Forms.Label();
            this.TareaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTareaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTexBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombrePasanteTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PrioridadComboBox = new System.Windows.Forms.ComboBox();
            this.EstadoTareaComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TareaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarea Id";
            // 
            // TareaIdNumericUpDown
            // 
            this.TareaIdNumericUpDown.Location = new System.Drawing.Point(170, 28);
            this.TareaIdNumericUpDown.Name = "TareaIdNumericUpDown";
            this.TareaIdNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.TareaIdNumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Tarea";
            // 
            // NombreTareaTextBox
            // 
            this.NombreTareaTextBox.Location = new System.Drawing.Point(170, 196);
            this.NombreTareaTextBox.Name = "NombreTareaTextBox";
            this.NombreTareaTextBox.Size = new System.Drawing.Size(415, 27);
            this.NombreTareaTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // DescripcionTexBox
            // 
            this.DescripcionTexBox.Location = new System.Drawing.Point(169, 252);
            this.DescripcionTexBox.Name = "DescripcionTexBox";
            this.DescripcionTexBox.Size = new System.Drawing.Size(415, 27);
            this.DescripcionTexBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prioridad";
            // 
            // NombrePasanteTextBox
            // 
            this.NombrePasanteTextBox.Location = new System.Drawing.Point(169, 308);
            this.NombrePasanteTextBox.Name = "NombrePasanteTextBox";
            this.NombrePasanteTextBox.Size = new System.Drawing.Size(415, 27);
            this.NombrePasanteTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre Pasante";
            // 
            // PrioridadComboBox
            // 
            this.PrioridadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrioridadComboBox.FormattingEnabled = true;
            this.PrioridadComboBox.Items.AddRange(new object[] {
            "Urgente",
            "Importante",
            "Media",
            "Baja"});
            this.PrioridadComboBox.Location = new System.Drawing.Point(169, 364);
            this.PrioridadComboBox.Name = "PrioridadComboBox";
            this.PrioridadComboBox.Size = new System.Drawing.Size(415, 28);
            this.PrioridadComboBox.TabIndex = 13;
            // 
            // EstadoTareaComboBox
            // 
            this.EstadoTareaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoTareaComboBox.FormattingEnabled = true;
            this.EstadoTareaComboBox.Items.AddRange(new object[] {
            "No iniciada",
            "En Curso",
            "Completada"});
            this.EstadoTareaComboBox.Location = new System.Drawing.Point(170, 421);
            this.EstadoTareaComboBox.Name = "EstadoTareaComboBox";
            this.EstadoTareaComboBox.Size = new System.Drawing.Size(415, 28);
            this.EstadoTareaComboBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha Creacion";
            // 
            // FechaInicioDateTimePicker
            // 
            this.FechaInicioDateTimePicker.CustomFormat = "dd/MM/yyyy ";
            this.FechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaInicioDateTimePicker.Location = new System.Drawing.Point(169, 84);
            this.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            this.FechaInicioDateTimePicker.Size = new System.Drawing.Size(415, 27);
            this.FechaInicioDateTimePicker.TabIndex = 17;
            // 
            // FechaVencimientoDateTimePicker
            // 
            this.FechaVencimientoDateTimePicker.CustomFormat = "dd/MM/yyyy ";
            this.FechaVencimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVencimientoDateTimePicker.Location = new System.Drawing.Point(169, 140);
            this.FechaVencimientoDateTimePicker.Name = "FechaVencimientoDateTimePicker";
            this.FechaVencimientoDateTimePicker.Size = new System.Drawing.Size(415, 27);
            this.FechaVencimientoDateTimePicker.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha Vencimiento";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(512, 29);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(73, 24);
            this.ActivoCheckBox.TabIndex = 20;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            //
            this.BuscarButton.Image = global::Gestion_de_Pasantes.Properties.Resources.buscar;
            this.BuscarButton.Location = new System.Drawing.Point(350, 27);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(64, 29);
            this.BuscarButton.TabIndex = 21;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            //
            this.NuevoButton.Image = global::Gestion_de_Pasantes.Properties.Resources.nuevo;
            this.NuevoButton.Location = new System.Drawing.Point(109, 477);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(103, 62);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Gestion_de_Pasantes.Properties.Resources.guardar;
            this.GuardarButton.Location = new System.Drawing.Point(255, 477);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(103, 62);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            //
            this.EliminarButton.Image = global::Gestion_de_Pasantes.Properties.Resources.eliminar;
            this.EliminarButton.Location = new System.Drawing.Point(401, 477);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(103, 62);
            this.EliminarButton.TabIndex = 24;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 565);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.FechaVencimientoDateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FechaInicioDateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EstadoTareaComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PrioridadComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NombrePasanteTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DescripcionTexBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTareaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TareaIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rTareas";
            this.Text = "Registro Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.TareaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TareaIdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTareaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTexBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombrePasanteTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PrioridadComboBox;
        private System.Windows.Forms.ComboBox EstadoTareaComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker FechaInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaVencimientoDateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}