
namespace Gestion_de_Pasantes.UI.Consultas
{
    partial class cHabilidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cHabilidades));
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.UsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EsactivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivoRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivoRadioButton = new System.Windows.Forms.RadioButton();
            this.TodoRadioButton = new System.Windows.Forms.RadioButton();
            this.InformacionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaHastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGridView)).BeginInit();
            this.EsactivoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirButton.Image")));
            this.ImprimirButton.Location = new System.Drawing.Point(11, 541);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(95, 25);
            this.ImprimirButton.TabIndex = 35;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // UsuarioDataGridView
            // 
            this.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuarioDataGridView.Location = new System.Drawing.Point(11, 93);
            this.UsuarioDataGridView.Name = "UsuarioDataGridView";
            this.UsuarioDataGridView.RowHeadersWidth = 51;
            this.UsuarioDataGridView.RowTemplate.Height = 25;
            this.UsuarioDataGridView.Size = new System.Drawing.Size(833, 442);
            this.UsuarioDataGridView.TabIndex = 34;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(767, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(77, 65);
            this.BuscarButton.TabIndex = 33;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EsactivoGroupBox
            // 
            this.EsactivoGroupBox.Controls.Add(this.InactivoRadioButton);
            this.EsactivoGroupBox.Controls.Add(this.ActivoRadioButton);
            this.EsactivoGroupBox.Controls.Add(this.TodoRadioButton);
            this.EsactivoGroupBox.Location = new System.Drawing.Point(685, 4);
            this.EsactivoGroupBox.Name = "EsactivoGroupBox";
            this.EsactivoGroupBox.Size = new System.Drawing.Size(76, 73);
            this.EsactivoGroupBox.TabIndex = 32;
            this.EsactivoGroupBox.TabStop = false;
            this.EsactivoGroupBox.Text = "EsActivo?";
            // 
            // InactivoRadioButton
            // 
            this.InactivoRadioButton.AutoSize = true;
            this.InactivoRadioButton.Location = new System.Drawing.Point(6, 48);
            this.InactivoRadioButton.Name = "InactivoRadioButton";
            this.InactivoRadioButton.Size = new System.Drawing.Size(67, 19);
            this.InactivoRadioButton.TabIndex = 2;
            this.InactivoRadioButton.TabStop = true;
            this.InactivoRadioButton.Text = "Inactivo";
            this.InactivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivoRadioButton
            // 
            this.ActivoRadioButton.AutoSize = true;
            this.ActivoRadioButton.Location = new System.Drawing.Point(6, 31);
            this.ActivoRadioButton.Name = "ActivoRadioButton";
            this.ActivoRadioButton.Size = new System.Drawing.Size(59, 19);
            this.ActivoRadioButton.TabIndex = 1;
            this.ActivoRadioButton.TabStop = true;
            this.ActivoRadioButton.Text = "Activo";
            this.ActivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodoRadioButton
            // 
            this.TodoRadioButton.AutoSize = true;
            this.TodoRadioButton.Location = new System.Drawing.Point(6, 14);
            this.TodoRadioButton.Name = "TodoRadioButton";
            this.TodoRadioButton.Size = new System.Drawing.Size(56, 19);
            this.TodoRadioButton.TabIndex = 0;
            this.TodoRadioButton.TabStop = true;
            this.TodoRadioButton.Text = "Todos";
            this.TodoRadioButton.UseVisualStyleBackColor = true;
            // 
            // InformacionTextBox
            // 
            this.InformacionTextBox.Location = new System.Drawing.Point(195, 52);
            this.InformacionTextBox.Multiline = true;
            this.InformacionTextBox.Name = "InformacionTextBox";
            this.InformacionTextBox.Size = new System.Drawing.Size(477, 25);
            this.InformacionTextBox.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaHastaDateTimePicker);
            this.groupBox1.Controls.Add(this.FechaDesdeDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(195, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 44);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // FechaHastaDateTimePicker
            // 
            this.FechaHastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaHastaDateTimePicker.Location = new System.Drawing.Point(321, 12);
            this.FechaHastaDateTimePicker.Name = "FechaHastaDateTimePicker";
            this.FechaHastaDateTimePicker.Size = new System.Drawing.Size(141, 23);
            this.FechaHastaDateTimePicker.TabIndex = 3;
            // 
            // FechaDesdeDateTimePicker
            // 
            this.FechaDesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDesdeDateTimePicker.Location = new System.Drawing.Point(70, 11);
            this.FechaDesdeDateTimePicker.Name = "FechaDesdeDateTimePicker";
            this.FechaDesdeDateTimePicker.Size = new System.Drawing.Size(141, 23);
            this.FechaDesdeDateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre"});
            this.FiltroComboBox.Location = new System.Drawing.Point(51, 54);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(114, 23);
            this.FiltroComboBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filtro";
            // 
            // FiltroCheckBox
            // 
            this.FiltroCheckBox.AutoSize = true;
            this.FiltroCheckBox.Location = new System.Drawing.Point(11, 21);
            this.FiltroCheckBox.Name = "FiltroCheckBox";
            this.FiltroCheckBox.Size = new System.Drawing.Size(110, 19);
            this.FiltroCheckBox.TabIndex = 27;
            this.FiltroCheckBox.Text = "Uso Filtro Fecha";
            this.FiltroCheckBox.UseVisualStyleBackColor = true;
            // 
            // cHabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 562);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.UsuarioDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EsactivoGroupBox);
            this.Controls.Add(this.InformacionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cHabilidades";
            this.Text = "Consultar Habilidades";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGridView)).EndInit();
            this.EsactivoGroupBox.ResumeLayout(false);
            this.EsactivoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.DataGridView UsuarioDataGridView;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.GroupBox EsactivoGroupBox;
        private System.Windows.Forms.RadioButton InactivoRadioButton;
        private System.Windows.Forms.RadioButton ActivoRadioButton;
        private System.Windows.Forms.RadioButton TodoRadioButton;
        private System.Windows.Forms.TextBox InformacionTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaHastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaDesdeDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FiltroCheckBox;
    }
}