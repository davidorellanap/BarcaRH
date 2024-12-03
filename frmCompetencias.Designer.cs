namespace BarcaRH
{
    partial class frmCompetencias
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbEstadoCompetencia = new System.Windows.Forms.ComboBox();
            this.txtNombreCompetencia = new System.Windows.Forms.TextBox();
            this.dataGridViewCompetencias = new System.Windows.Forms.DataGridView();
            this.codigoCompetenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompetenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCompetenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcaRHBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.competenciasTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.CompetenciasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Competencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(551, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(632, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(713, 415);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbEstadoCompetencia
            // 
            this.cmbEstadoCompetencia.FormattingEnabled = true;
            this.cmbEstadoCompetencia.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoCompetencia.Location = new System.Drawing.Point(136, 64);
            this.cmbEstadoCompetencia.Name = "cmbEstadoCompetencia";
            this.cmbEstadoCompetencia.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoCompetencia.TabIndex = 5;
            // 
            // txtNombreCompetencia
            // 
            this.txtNombreCompetencia.Location = new System.Drawing.Point(136, 33);
            this.txtNombreCompetencia.Name = "txtNombreCompetencia";
            this.txtNombreCompetencia.Size = new System.Drawing.Size(188, 20);
            this.txtNombreCompetencia.TabIndex = 6;
            // 
            // dataGridViewCompetencias
            // 
            this.dataGridViewCompetencias.AllowUserToOrderColumns = true;
            this.dataGridViewCompetencias.AutoGenerateColumns = false;
            this.dataGridViewCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCompetenciaDataGridViewTextBoxColumn,
            this.nombreCompetenciaDataGridViewTextBoxColumn,
            this.estadoCompetenciaDataGridViewTextBoxColumn});
            this.dataGridViewCompetencias.DataSource = this.competenciasBindingSource;
            this.dataGridViewCompetencias.Location = new System.Drawing.Point(136, 157);
            this.dataGridViewCompetencias.Name = "dataGridViewCompetencias";
            this.dataGridViewCompetencias.Size = new System.Drawing.Size(498, 150);
            this.dataGridViewCompetencias.TabIndex = 7;
            // 
            // codigoCompetenciaDataGridViewTextBoxColumn
            // 
            this.codigoCompetenciaDataGridViewTextBoxColumn.DataPropertyName = "CodigoCompetencia";
            this.codigoCompetenciaDataGridViewTextBoxColumn.HeaderText = "CodigoCompetencia";
            this.codigoCompetenciaDataGridViewTextBoxColumn.Name = "codigoCompetenciaDataGridViewTextBoxColumn";
            this.codigoCompetenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoCompetenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreCompetenciaDataGridViewTextBoxColumn
            // 
            this.nombreCompetenciaDataGridViewTextBoxColumn.DataPropertyName = "NombreCompetencia";
            this.nombreCompetenciaDataGridViewTextBoxColumn.HeaderText = "NombreCompetencia";
            this.nombreCompetenciaDataGridViewTextBoxColumn.Name = "nombreCompetenciaDataGridViewTextBoxColumn";
            this.nombreCompetenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoCompetenciaDataGridViewTextBoxColumn
            // 
            this.estadoCompetenciaDataGridViewTextBoxColumn.DataPropertyName = "EstadoCompetencia";
            this.estadoCompetenciaDataGridViewTextBoxColumn.HeaderText = "EstadoCompetencia";
            this.estadoCompetenciaDataGridViewTextBoxColumn.Name = "estadoCompetenciaDataGridViewTextBoxColumn";
            this.estadoCompetenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // competenciasBindingSource
            // 
            this.competenciasBindingSource.DataMember = "Competencias";
            this.competenciasBindingSource.DataSource = this.barcaRHBDDataSetBindingSource;
            // 
            // barcaRHBDDataSetBindingSource
            // 
            this.barcaRHBDDataSetBindingSource.DataSource = this.barcaRHBDDataSet;
            this.barcaRHBDDataSetBindingSource.Position = 0;
            // 
            // barcaRHBDDataSet
            // 
            this.barcaRHBDDataSet.DataSetName = "BarcaRHBDDataSet";
            this.barcaRHBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competenciasTableAdapter
            // 
            this.competenciasTableAdapter.ClearBeforeFill = true;
            // 
            // frmCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCompetencias);
            this.Controls.Add(this.txtNombreCompetencia);
            this.Controls.Add(this.cmbEstadoCompetencia);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCompetencias";
            this.Text = "GESTION - COMPETENCIAS";
            this.Load += new System.EventHandler(this.frmCompetencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbEstadoCompetencia;
        private System.Windows.Forms.TextBox txtNombreCompetencia;
        private System.Windows.Forms.DataGridView dataGridViewCompetencias;
        private System.Windows.Forms.BindingSource barcaRHBDDataSetBindingSource;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource competenciasBindingSource;
        private BarcaRHBDDataSetTableAdapters.CompetenciasTableAdapter competenciasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCompetenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompetenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCompetenciaDataGridViewTextBoxColumn;
    }
}