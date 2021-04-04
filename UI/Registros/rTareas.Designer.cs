﻿
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
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TareaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarea Id";
            // 
            // TareaIdNumericUpDown
            // 
            this.TareaIdNumericUpDown.Location = new System.Drawing.Point(149, 21);
            this.TareaIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TareaIdNumericUpDown.Name = "TareaIdNumericUpDown";
            this.TareaIdNumericUpDown.Size = new System.Drawing.Size(131, 23);
            this.TareaIdNumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Tarea";
            // 
            // NombreTareaTextBox
            // 
            this.NombreTareaTextBox.Location = new System.Drawing.Point(149, 147);
            this.NombreTareaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreTareaTextBox.Name = "NombreTareaTextBox";
            this.NombreTareaTextBox.Size = new System.Drawing.Size(364, 23);
            this.NombreTareaTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // DescripcionTexBox
            // 
            this.DescripcionTexBox.Location = new System.Drawing.Point(148, 189);
            this.DescripcionTexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescripcionTexBox.Name = "DescripcionTexBox";
            this.DescripcionTexBox.Size = new System.Drawing.Size(364, 23);
            this.DescripcionTexBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prioridad";
            // 
            // NombrePasanteTextBox
            // 
            this.NombrePasanteTextBox.Location = new System.Drawing.Point(148, 231);
            this.NombrePasanteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombrePasanteTextBox.Name = "NombrePasanteTextBox";
            this.NombrePasanteTextBox.Size = new System.Drawing.Size(364, 23);
            this.NombrePasanteTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre Pasante";
            // 
            // PrioridadComboBox
            // 
            this.PrioridadComboBox.FormattingEnabled = true;
            this.PrioridadComboBox.Items.AddRange(new object[] {
            "Importante",
            "Intermedia",
            "Baja"});
            this.PrioridadComboBox.Location = new System.Drawing.Point(148, 273);
            this.PrioridadComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrioridadComboBox.Name = "PrioridadComboBox";
            this.PrioridadComboBox.Size = new System.Drawing.Size(364, 23);
            this.PrioridadComboBox.TabIndex = 13;
            // 
            // EstadoTareaComboBox
            // 
            this.EstadoTareaComboBox.FormattingEnabled = true;
            this.EstadoTareaComboBox.Items.AddRange(new object[] {
            "No iniciada",
            "En progreso",
            "Finalizada"});
            this.EstadoTareaComboBox.Location = new System.Drawing.Point(149, 316);
            this.EstadoTareaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EstadoTareaComboBox.Name = "EstadoTareaComboBox";
            this.EstadoTareaComboBox.Size = new System.Drawing.Size(364, 23);
            this.EstadoTareaComboBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha Creacion";
            // 
            // FechaInicioDateTimePicker
            // 
            this.FechaInicioDateTimePicker.CustomFormat = "dd/MM/yyyy ";
            this.FechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaInicioDateTimePicker.Location = new System.Drawing.Point(148, 63);
            this.FechaInicioDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            this.FechaInicioDateTimePicker.Size = new System.Drawing.Size(364, 23);
            this.FechaInicioDateTimePicker.TabIndex = 17;
            // 
            // FechaVencimientoDateTimePicker
            // 
            this.FechaVencimientoDateTimePicker.CustomFormat = "dd/MM/yyyy ";
            this.FechaVencimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVencimientoDateTimePicker.Location = new System.Drawing.Point(148, 105);
            this.FechaVencimientoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaVencimientoDateTimePicker.Name = "FechaVencimientoDateTimePicker";
            this.FechaVencimientoDateTimePicker.Size = new System.Drawing.Size(364, 23);
            this.FechaVencimientoDateTimePicker.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha Vencimiento";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(448, 22);
            this.ActivoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoCheckBox.TabIndex = 20;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(306, 20);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(82, 22);
            this.BuscarButton.TabIndex = 21;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(88, 358);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(105, 26);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(216, 358);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(105, 26);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(344, 358);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(105, 26);
            this.EliminarButton.TabIndex = 24;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // rTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 404);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rTareas";
            this.Text = "Registro Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.TareaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}