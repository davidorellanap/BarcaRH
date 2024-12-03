namespace BarcaRH
{
    partial class frmMiEducacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiEducacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInstituciones = new System.Windows.Forms.ComboBox();
            this.cmbTitulos = new System.Windows.Forms.ComboBox();
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.academiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academiasTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.AcademiasTableAdapter();
            this.titulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titulosTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.TitulosTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewEducacion = new System.Windows.Forms.DataGridView();
            this.empleadosEducacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosEducacionTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.EmpleadosEducacionTableAdapter();
            this.codigoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAcademiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarEducacion = new System.Windows.Forms.Button();
            this.btnEliminarEducacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEducacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosEducacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // cmbInstituciones
            // 
            this.cmbInstituciones.DataSource = this.academiasBindingSource;
            this.cmbInstituciones.DisplayMember = "NombreAcademia";
            this.cmbInstituciones.FormattingEnabled = true;
            this.cmbInstituciones.Location = new System.Drawing.Point(129, 29);
            this.cmbInstituciones.Name = "cmbInstituciones";
            this.cmbInstituciones.Size = new System.Drawing.Size(292, 21);
            this.cmbInstituciones.TabIndex = 2;
            this.cmbInstituciones.ValueMember = "NombreAcademia";
            // 
            // cmbTitulos
            // 
            this.cmbTitulos.DataSource = this.titulosBindingSource;
            this.cmbTitulos.DisplayMember = "NombreTitulo";
            this.cmbTitulos.FormattingEnabled = true;
            this.cmbTitulos.Location = new System.Drawing.Point(129, 74);
            this.cmbTitulos.Name = "cmbTitulos";
            this.cmbTitulos.Size = new System.Drawing.Size(292, 21);
            this.cmbTitulos.TabIndex = 3;
            this.cmbTitulos.ValueMember = "NombreTitulo";
            // 
            // barcaRHBDDataSet
            // 
            this.barcaRHBDDataSet.DataSetName = "BarcaRHBDDataSet";
            this.barcaRHBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academiasBindingSource
            // 
            this.academiasBindingSource.DataMember = "Academias";
            this.academiasBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // academiasTableAdapter
            // 
            this.academiasTableAdapter.ClearBeforeFill = true;
            // 
            // titulosBindingSource
            // 
            this.titulosBindingSource.DataMember = "Titulos";
            this.titulosBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // titulosTableAdapter
            // 
            this.titulosTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "FechaInicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "FechaFin";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(550, 36);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 6;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 12, 2, 0, 0, 0, 0);
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(550, 77);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 7;
            this.dtpFechaFin.Value = new System.DateTime(2024, 12, 2, 0, 0, 0, 0);
            // 
            // dataGridViewEducacion
            // 
            this.dataGridViewEducacion.AutoGenerateColumns = false;
            this.dataGridViewEducacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEducacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEmpleadoDataGridViewTextBoxColumn,
            this.codigoAcademiaDataGridViewTextBoxColumn,
            this.codigoTituloDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn});
            this.dataGridViewEducacion.DataSource = this.empleadosEducacionBindingSource;
            this.dataGridViewEducacion.Location = new System.Drawing.Point(129, 146);
            this.dataGridViewEducacion.Name = "dataGridViewEducacion";
            this.dataGridViewEducacion.Size = new System.Drawing.Size(572, 150);
            this.dataGridViewEducacion.TabIndex = 8;
            // 
            // empleadosEducacionBindingSource
            // 
            this.empleadosEducacionBindingSource.DataMember = "EmpleadosEducacion";
            this.empleadosEducacionBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // empleadosEducacionTableAdapter
            // 
            this.empleadosEducacionTableAdapter.ClearBeforeFill = true;
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.Name = "codigoEmpleadoDataGridViewTextBoxColumn";
            // 
            // codigoAcademiaDataGridViewTextBoxColumn
            // 
            this.codigoAcademiaDataGridViewTextBoxColumn.DataPropertyName = "CodigoAcademia";
            this.codigoAcademiaDataGridViewTextBoxColumn.HeaderText = "CodigoAcademia";
            this.codigoAcademiaDataGridViewTextBoxColumn.Name = "codigoAcademiaDataGridViewTextBoxColumn";
            // 
            // codigoTituloDataGridViewTextBoxColumn
            // 
            this.codigoTituloDataGridViewTextBoxColumn.DataPropertyName = "CodigoTitulo";
            this.codigoTituloDataGridViewTextBoxColumn.HeaderText = "CodigoTitulo";
            this.codigoTituloDataGridViewTextBoxColumn.Name = "codigoTituloDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // btnAgregarEducacion
            // 
            this.btnAgregarEducacion.Location = new System.Drawing.Point(605, 415);
            this.btnAgregarEducacion.Name = "btnAgregarEducacion";
            this.btnAgregarEducacion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEducacion.TabIndex = 9;
            this.btnAgregarEducacion.Text = "Agregar";
            this.btnAgregarEducacion.UseVisualStyleBackColor = true;
            this.btnAgregarEducacion.Click += new System.EventHandler(this.btnAgregarEducacion_Click);
            // 
            // btnEliminarEducacion
            // 
            this.btnEliminarEducacion.Location = new System.Drawing.Point(686, 415);
            this.btnEliminarEducacion.Name = "btnEliminarEducacion";
            this.btnEliminarEducacion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEducacion.TabIndex = 10;
            this.btnEliminarEducacion.Text = "Eliminar";
            this.btnEliminarEducacion.UseVisualStyleBackColor = true;
            this.btnEliminarEducacion.Click += new System.EventHandler(this.btnEliminarEducacion_Click);
            // 
            // frmMiEducacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarEducacion);
            this.Controls.Add(this.btnAgregarEducacion);
            this.Controls.Add(this.dataGridViewEducacion);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTitulos);
            this.Controls.Add(this.cmbInstituciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMiEducacion";
            this.Text = "ACTUALIZACION - MI EDUCACION";
            this.Load += new System.EventHandler(this.frmMiEducacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEducacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosEducacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInstituciones;
        private System.Windows.Forms.ComboBox cmbTitulos;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource academiasBindingSource;
        private BarcaRHBDDataSetTableAdapters.AcademiasTableAdapter academiasTableAdapter;
        private System.Windows.Forms.BindingSource titulosBindingSource;
        private BarcaRHBDDataSetTableAdapters.TitulosTableAdapter titulosTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DataGridView dataGridViewEducacion;
        private System.Windows.Forms.BindingSource empleadosEducacionBindingSource;
        private BarcaRHBDDataSetTableAdapters.EmpleadosEducacionTableAdapter empleadosEducacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAcademiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgregarEducacion;
        private System.Windows.Forms.Button btnEliminarEducacion;
    }
}