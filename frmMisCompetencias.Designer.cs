namespace BarcaRH
{
    partial class frmMisCompetencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMisCompetencias));
            this.cmbNivelDestreza = new System.Windows.Forms.ComboBox();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.competenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competenciasTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.CompetenciasTableAdapter();
            this.dataGridViewCompetencias = new System.Windows.Forms.DataGridView();
            this.btnEliminarCompetencia = new System.Windows.Forms.Button();
            this.btnAgregarCompetencia = new System.Windows.Forms.Button();
            this.empleadosCompetenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosCompetenciasTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.EmpleadosCompetenciasTableAdapter();
            this.codigoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCompetenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDestrezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosCompetenciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNivelDestreza
            // 
            this.cmbNivelDestreza.FormattingEnabled = true;
            this.cmbNivelDestreza.Items.AddRange(new object[] {
            "Novato",
            "Principiante",
            "Intermedio",
            "Avanzado",
            "Senior"});
            this.cmbNivelDestreza.Location = new System.Drawing.Point(394, 24);
            this.cmbNivelDestreza.Name = "cmbNivelDestreza";
            this.cmbNivelDestreza.Size = new System.Drawing.Size(184, 21);
            this.cmbNivelDestreza.TabIndex = 7;
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.DataSource = this.competenciasBindingSource;
            this.cmbCompetencias.DisplayMember = "NombreCompetencia";
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(90, 24);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(183, 21);
            this.cmbCompetencias.TabIndex = 6;
            this.cmbCompetencias.ValueMember = "NombreCompetencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nivel Dominio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Competencia";
            // 
            // barcaRHBDDataSet
            // 
            this.barcaRHBDDataSet.DataSetName = "BarcaRHBDDataSet";
            this.barcaRHBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competenciasBindingSource
            // 
            this.competenciasBindingSource.DataMember = "Competencias";
            this.competenciasBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // competenciasTableAdapter
            // 
            this.competenciasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCompetencias
            // 
            this.dataGridViewCompetencias.AllowUserToOrderColumns = true;
            this.dataGridViewCompetencias.AutoGenerateColumns = false;
            this.dataGridViewCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEmpleadoDataGridViewTextBoxColumn,
            this.codigoCompetenciaDataGridViewTextBoxColumn,
            this.nivelDestrezaDataGridViewTextBoxColumn});
            this.dataGridViewCompetencias.DataSource = this.empleadosCompetenciasBindingSource;
            this.dataGridViewCompetencias.Location = new System.Drawing.Point(90, 142);
            this.dataGridViewCompetencias.Name = "dataGridViewCompetencias";
            this.dataGridViewCompetencias.Size = new System.Drawing.Size(417, 150);
            this.dataGridViewCompetencias.TabIndex = 8;
            // 
            // btnEliminarCompetencia
            // 
            this.btnEliminarCompetencia.Location = new System.Drawing.Point(650, 415);
            this.btnEliminarCompetencia.Name = "btnEliminarCompetencia";
            this.btnEliminarCompetencia.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCompetencia.TabIndex = 10;
            this.btnEliminarCompetencia.Text = "Eliminar";
            this.btnEliminarCompetencia.UseVisualStyleBackColor = true;
            this.btnEliminarCompetencia.Click += new System.EventHandler(this.btnEliminarHabilidad_Click);
            // 
            // btnAgregarCompetencia
            // 
            this.btnAgregarCompetencia.Location = new System.Drawing.Point(568, 416);
            this.btnAgregarCompetencia.Name = "btnAgregarCompetencia";
            this.btnAgregarCompetencia.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCompetencia.TabIndex = 9;
            this.btnAgregarCompetencia.Text = "Agregar";
            this.btnAgregarCompetencia.UseVisualStyleBackColor = true;
            this.btnAgregarCompetencia.Click += new System.EventHandler(this.btnAgregarCompetencia_Click);
            // 
            // empleadosCompetenciasBindingSource
            // 
            this.empleadosCompetenciasBindingSource.DataMember = "EmpleadosCompetencias";
            this.empleadosCompetenciasBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // empleadosCompetenciasTableAdapter
            // 
            this.empleadosCompetenciasTableAdapter.ClearBeforeFill = true;
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.Name = "codigoEmpleadoDataGridViewTextBoxColumn";
            // 
            // codigoCompetenciaDataGridViewTextBoxColumn
            // 
            this.codigoCompetenciaDataGridViewTextBoxColumn.DataPropertyName = "CodigoCompetencia";
            this.codigoCompetenciaDataGridViewTextBoxColumn.HeaderText = "CodigoCompetencia";
            this.codigoCompetenciaDataGridViewTextBoxColumn.Name = "codigoCompetenciaDataGridViewTextBoxColumn";
            // 
            // nivelDestrezaDataGridViewTextBoxColumn
            // 
            this.nivelDestrezaDataGridViewTextBoxColumn.DataPropertyName = "NivelDestreza";
            this.nivelDestrezaDataGridViewTextBoxColumn.HeaderText = "NivelDestreza";
            this.nivelDestrezaDataGridViewTextBoxColumn.Name = "nivelDestrezaDataGridViewTextBoxColumn";
            // 
            // frmMisCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarCompetencia);
            this.Controls.Add(this.btnAgregarCompetencia);
            this.Controls.Add(this.dataGridViewCompetencias);
            this.Controls.Add(this.cmbNivelDestreza);
            this.Controls.Add(this.cmbCompetencias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMisCompetencias";
            this.Text = "ACTUALIZACIONES - MIS COMPETENCIAS";
            this.Load += new System.EventHandler(this.frmMisCompetencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosCompetenciasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNivelDestreza;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource competenciasBindingSource;
        private BarcaRHBDDataSetTableAdapters.CompetenciasTableAdapter competenciasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCompetencias;
        private System.Windows.Forms.Button btnEliminarCompetencia;
        private System.Windows.Forms.Button btnAgregarCompetencia;
        private System.Windows.Forms.BindingSource empleadosCompetenciasBindingSource;
        private BarcaRHBDDataSetTableAdapters.EmpleadosCompetenciasTableAdapter empleadosCompetenciasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCompetenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDestrezaDataGridViewTextBoxColumn;
    }
}