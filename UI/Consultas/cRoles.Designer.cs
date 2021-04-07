
namespace Gestion_de_Pasantes.UI.Consultas
{
    partial class cRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cRoles));
            this.RolesDataGridView = new System.Windows.Forms.DataGridView();
            this.EsactivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivoRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivoRadioButton = new System.Windows.Forms.RadioButton();
            this.TodoRadioButton = new System.Windows.Forms.RadioButton();
            this.InformacionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroCheckBox = new System.Windows.Forms.CheckBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).BeginInit();
            this.EsactivoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RolesDataGridView
            // 
            this.RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDataGridView.Location = new System.Drawing.Point(14, 124);
            this.RolesDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RolesDataGridView.Name = "RolesDataGridView";
            this.RolesDataGridView.RowHeadersWidth = 51;
            this.RolesDataGridView.RowTemplate.Height = 25;
            this.RolesDataGridView.Size = new System.Drawing.Size(952, 589);
            this.RolesDataGridView.TabIndex = 14;
            // 
            // EsactivoGroupBox
            // 
            this.EsactivoGroupBox.Controls.Add(this.InactivoRadioButton);
            this.EsactivoGroupBox.Controls.Add(this.ActivoRadioButton);
            this.EsactivoGroupBox.Controls.Add(this.TodoRadioButton);
            this.EsactivoGroupBox.Location = new System.Drawing.Point(776, 5);
            this.EsactivoGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EsactivoGroupBox.Name = "EsactivoGroupBox";
            this.EsactivoGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EsactivoGroupBox.Size = new System.Drawing.Size(93, 97);
            this.EsactivoGroupBox.TabIndex = 13;
            this.EsactivoGroupBox.TabStop = false;
            this.EsactivoGroupBox.Text = "EsActivo?";
            // 
            // InactivoRadioButton
            // 
            this.InactivoRadioButton.AutoSize = true;
            this.InactivoRadioButton.Location = new System.Drawing.Point(7, 64);
            this.InactivoRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InactivoRadioButton.Name = "InactivoRadioButton";
            this.InactivoRadioButton.Size = new System.Drawing.Size(82, 24);
            this.InactivoRadioButton.TabIndex = 2;
            this.InactivoRadioButton.TabStop = true;
            this.InactivoRadioButton.Text = "Inactivo";
            this.InactivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivoRadioButton
            // 
            this.ActivoRadioButton.AutoSize = true;
            this.ActivoRadioButton.Location = new System.Drawing.Point(7, 41);
            this.ActivoRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActivoRadioButton.Name = "ActivoRadioButton";
            this.ActivoRadioButton.Size = new System.Drawing.Size(72, 24);
            this.ActivoRadioButton.TabIndex = 1;
            this.ActivoRadioButton.TabStop = true;
            this.ActivoRadioButton.Text = "Activo";
            this.ActivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodoRadioButton
            // 
            this.TodoRadioButton.AutoSize = true;
            this.TodoRadioButton.Location = new System.Drawing.Point(7, 19);
            this.TodoRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TodoRadioButton.Name = "TodoRadioButton";
            this.TodoRadioButton.Size = new System.Drawing.Size(70, 24);
            this.TodoRadioButton.TabIndex = 0;
            this.TodoRadioButton.TabStop = true;
            this.TodoRadioButton.Text = "Todos";
            this.TodoRadioButton.UseVisualStyleBackColor = true;
            // 
            // InformacionTextBox
            // 
            this.InformacionTextBox.Location = new System.Drawing.Point(224, 72);
            this.InformacionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InformacionTextBox.Multiline = true;
            this.InformacionTextBox.Name = "InformacionTextBox";
            this.InformacionTextBox.Size = new System.Drawing.Size(545, 29);
            this.InformacionTextBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaFinal);
            this.groupBox1.Controls.Add(this.FechaInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(224, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(545, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // FechaFinal
            // 
            this.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinal.Location = new System.Drawing.Point(367, 16);
            this.FechaFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(161, 27);
            this.FechaFinal.TabIndex = 3;
            // 
            // FechaInicio
            // 
            this.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicio.Location = new System.Drawing.Point(80, 15);
            this.FechaInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(161, 27);
            this.FechaInicio.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id",
            "Rol",
            "descripción"});
            this.FiltroComboBox.Location = new System.Drawing.Point(59, 72);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(130, 28);
            this.FiltroComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtro";
            // 
            // FiltroCheckBox
            // 
            this.FiltroCheckBox.AutoSize = true;
            this.FiltroCheckBox.Location = new System.Drawing.Point(14, 28);
            this.FiltroCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiltroCheckBox.Name = "FiltroCheckBox";
            this.FiltroCheckBox.Size = new System.Drawing.Size(136, 24);
            this.FiltroCheckBox.TabIndex = 8;
            this.FiltroCheckBox.Text = "Uso Filtro Fecha";
            this.FiltroCheckBox.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Gestion_de_Pasantes.Properties.Resources.buscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.Location = new System.Drawing.Point(875, 16);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(87, 87);
            this.BuscarButton.TabIndex = 15;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(14, 721);
            this.ImprimirButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(101, 33);
            this.ImprimirButton.TabIndex = 16;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // cRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 761);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.RolesDataGridView);
            this.Controls.Add(this.EsactivoGroupBox);
            this.Controls.Add(this.InformacionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroCheckBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cRoles";
            this.Text = "Consultar Roles";
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).EndInit();
            this.EsactivoGroupBox.ResumeLayout(false);
            this.EsactivoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RolesDataGridView;
        private System.Windows.Forms.GroupBox EsactivoGroupBox;
        private System.Windows.Forms.RadioButton InactivoRadioButton;
        private System.Windows.Forms.RadioButton ActivoRadioButton;
        private System.Windows.Forms.RadioButton TodoRadioButton;
        private System.Windows.Forms.TextBox InformacionTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaFinal;
        private System.Windows.Forms.DateTimePicker FechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FiltroCheckBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ImprimirButton;
    }
}