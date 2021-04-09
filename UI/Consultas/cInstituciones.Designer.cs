
namespace Gestion_de_Pasantes.UI.Consultas
{
    partial class cInstituciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cInstituciones));
            this.FiltroCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InformacionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InactivoRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivoRadioButton = new System.Windows.Forms.RadioButton();
            this.TodoRadioButton = new System.Windows.Forms.RadioButton();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.InstitucionesDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaHastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstitucionesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroCheckBox
            // 
            this.FiltroCheckBox.AutoSize = true;
            this.FiltroCheckBox.Location = new System.Drawing.Point(14, 28);
            this.FiltroCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiltroCheckBox.Name = "FiltroCheckBox";
            this.FiltroCheckBox.Size = new System.Drawing.Size(157, 24);
            this.FiltroCheckBox.TabIndex = 0;
            this.FiltroCheckBox.Text = "Uso Filtro de Fecha";
            this.FiltroCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // InformacionTextBox
            // 
            this.InformacionTextBox.Location = new System.Drawing.Point(224, 67);
            this.InformacionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InformacionTextBox.Name = "InformacionTextBox";
            this.InformacionTextBox.Size = new System.Drawing.Size(545, 27);
            this.InformacionTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InactivoRadioButton);
            this.groupBox2.Controls.Add(this.ActivoRadioButton);
            this.groupBox2.Controls.Add(this.TodoRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(776, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(93, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EsActivo?";
            // 
            // InactivoRadioButton
            // 
            this.InactivoRadioButton.AutoSize = true;
            this.InactivoRadioButton.Location = new System.Drawing.Point(7, 67);
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
            this.ActivoRadioButton.Location = new System.Drawing.Point(7, 44);
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
            this.TodoRadioButton.Location = new System.Drawing.Point(7, 21);
            this.TodoRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TodoRadioButton.Name = "TodoRadioButton";
            this.TodoRadioButton.Size = new System.Drawing.Size(70, 24);
            this.TodoRadioButton.TabIndex = 0;
            this.TodoRadioButton.TabStop = true;
            this.TodoRadioButton.Text = "Todos";
            this.TodoRadioButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.Location = new System.Drawing.Point(875, 13);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(90, 89);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // InstitucionesDataGridView
            // 
            this.InstitucionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstitucionesDataGridView.Location = new System.Drawing.Point(14, 124);
            this.InstitucionesDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InstitucionesDataGridView.Name = "InstitucionesDataGridView";
            this.InstitucionesDataGridView.RowHeadersWidth = 51;
            this.InstitucionesDataGridView.RowTemplate.Height = 25;
            this.InstitucionesDataGridView.Size = new System.Drawing.Size(952, 589);
            this.InstitucionesDataGridView.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(14, 721);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Imprimir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Region"});
            this.FiltroComboBox.Location = new System.Drawing.Point(59, 72);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(140, 28);
            this.FiltroComboBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hasta";
            // 
            // FechaDesdeDateTimePicker
            // 
            this.FechaDesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDesdeDateTimePicker.Location = new System.Drawing.Point(100, 16);
            this.FechaDesdeDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FechaDesdeDateTimePicker.Name = "FechaDesdeDateTimePicker";
            this.FechaDesdeDateTimePicker.Size = new System.Drawing.Size(161, 27);
            this.FechaDesdeDateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desde";
            // 
            // FechaHastaDateTimePicker
            // 
            this.FechaHastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaHastaDateTimePicker.Location = new System.Drawing.Point(367, 16);
            this.FechaHastaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FechaHastaDateTimePicker.Name = "FechaHastaDateTimePicker";
            this.FechaHastaDateTimePicker.Size = new System.Drawing.Size(161, 27);
            this.FechaHastaDateTimePicker.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaHastaDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FechaDesdeDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(224, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(545, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cInstituciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 769);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InstitucionesDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InformacionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cInstituciones";
            this.Text = "Consultar Instituciónes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstitucionesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FiltroCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InformacionTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton InactivoRadioButton;
        private System.Windows.Forms.RadioButton ActivoRadioButton;
        private System.Windows.Forms.RadioButton TodoRadioButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView InstitucionesDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDesdeDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaHastaDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}