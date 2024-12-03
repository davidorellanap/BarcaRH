namespace BarcaRH
{
    partial class frmMisHabilidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMisHabilidades));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHabilidades = new System.Windows.Forms.ComboBox();
            this.cmbNivelDestreza = new System.Windows.Forms.ComboBox();
            this.dataGridViewHabilidades = new System.Windows.Forms.DataGridView();
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.empleadosHabilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosHabilidadesTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.EmpleadosHabilidadesTableAdapter();
            this.codigoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoHabilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDestrezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habilidadesTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.HabilidadesTableAdapter();
            this.btnAgregarHabilidad = new System.Windows.Forms.Button();
            this.btnEliminarHabilidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabilidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosHabilidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel Dominio";
            // 
            // cmbHabilidades
            // 
            this.cmbHabilidades.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.habilidadesBindingSource, "NombreHabilidad", true));
            this.cmbHabilidades.DataSource = this.habilidadesBindingSource;
            this.cmbHabilidades.DisplayMember = "NombreHabilidad";
            this.cmbHabilidades.FormattingEnabled = true;
            this.cmbHabilidades.Location = new System.Drawing.Point(101, 31);
            this.cmbHabilidades.Name = "cmbHabilidades";
            this.cmbHabilidades.Size = new System.Drawing.Size(183, 21);
            this.cmbHabilidades.TabIndex = 2;
            this.cmbHabilidades.ValueMember = "NombreHabilidad";
            // 
            // cmbNivelDestreza
            // 
            this.cmbNivelDestreza.FormattingEnabled = true;
            this.cmbNivelDestreza.Items.AddRange(new object[] {
            "Certificado",
            "No Certificado"});
            this.cmbNivelDestreza.Location = new System.Drawing.Point(422, 31);
            this.cmbNivelDestreza.Name = "cmbNivelDestreza";
            this.cmbNivelDestreza.Size = new System.Drawing.Size(184, 21);
            this.cmbNivelDestreza.TabIndex = 3;
            // 
            // dataGridViewHabilidades
            // 
            this.dataGridViewHabilidades.AllowUserToOrderColumns = true;
            this.dataGridViewHabilidades.AutoGenerateColumns = false;
            this.dataGridViewHabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEmpleadoDataGridViewTextBoxColumn,
            this.codigoHabilidadDataGridViewTextBoxColumn,
            this.nivelDestrezaDataGridViewTextBoxColumn});
            this.dataGridViewHabilidades.DataSource = this.empleadosHabilidadesBindingSource;
            this.dataGridViewHabilidades.Location = new System.Drawing.Point(166, 119);
            this.dataGridViewHabilidades.Name = "dataGridViewHabilidades";
            this.dataGridViewHabilidades.Size = new System.Drawing.Size(417, 150);
            this.dataGridViewHabilidades.TabIndex = 4;
            // 
            // barcaRHBDDataSet
            // 
            this.barcaRHBDDataSet.DataSetName = "BarcaRHBDDataSet";
            this.barcaRHBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosHabilidadesBindingSource
            // 
            this.empleadosHabilidadesBindingSource.DataMember = "EmpleadosHabilidades";
            this.empleadosHabilidadesBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // empleadosHabilidadesTableAdapter
            // 
            this.empleadosHabilidadesTableAdapter.ClearBeforeFill = true;
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.Name = "codigoEmpleadoDataGridViewTextBoxColumn";
            // 
            // codigoHabilidadDataGridViewTextBoxColumn
            // 
            this.codigoHabilidadDataGridViewTextBoxColumn.DataPropertyName = "CodigoHabilidad";
            this.codigoHabilidadDataGridViewTextBoxColumn.HeaderText = "CodigoHabilidad";
            this.codigoHabilidadDataGridViewTextBoxColumn.Name = "codigoHabilidadDataGridViewTextBoxColumn";
            // 
            // nivelDestrezaDataGridViewTextBoxColumn
            // 
            this.nivelDestrezaDataGridViewTextBoxColumn.DataPropertyName = "NivelDestreza";
            this.nivelDestrezaDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nivelDestrezaDataGridViewTextBoxColumn.HeaderText = "NivelDestreza";
            this.nivelDestrezaDataGridViewTextBoxColumn.Name = "nivelDestrezaDataGridViewTextBoxColumn";
            // 
            // habilidadesBindingSource
            // 
            this.habilidadesBindingSource.DataMember = "Habilidades";
            this.habilidadesBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // habilidadesTableAdapter
            // 
            this.habilidadesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarHabilidad
            // 
            this.btnAgregarHabilidad.Location = new System.Drawing.Point(508, 415);
            this.btnAgregarHabilidad.Name = "btnAgregarHabilidad";
            this.btnAgregarHabilidad.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHabilidad.TabIndex = 5;
            this.btnAgregarHabilidad.Text = "Agregar";
            this.btnAgregarHabilidad.UseVisualStyleBackColor = true;
            this.btnAgregarHabilidad.Click += new System.EventHandler(this.btnAgregarHabilidad_Click);
            // 
            // btnEliminarHabilidad
            // 
            this.btnEliminarHabilidad.Location = new System.Drawing.Point(590, 414);
            this.btnEliminarHabilidad.Name = "btnEliminarHabilidad";
            this.btnEliminarHabilidad.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarHabilidad.TabIndex = 6;
            this.btnEliminarHabilidad.Text = "Eliminar";
            this.btnEliminarHabilidad.UseVisualStyleBackColor = true;
            this.btnEliminarHabilidad.Click += new System.EventHandler(this.btnEliminarHabilidad_Click);
            // 
            // frmMisHabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarHabilidad);
            this.Controls.Add(this.btnAgregarHabilidad);
            this.Controls.Add(this.dataGridViewHabilidades);
            this.Controls.Add(this.cmbNivelDestreza);
            this.Controls.Add(this.cmbHabilidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMisHabilidades";
            this.Text = "ACTUALIZACIONES - MIS HABILIDADES";
            this.Load += new System.EventHandler(this.frmMisHabilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabilidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosHabilidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHabilidades;
        private System.Windows.Forms.ComboBox cmbNivelDestreza;
        private System.Windows.Forms.DataGridView dataGridViewHabilidades;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource empleadosHabilidadesBindingSource;
        private BarcaRHBDDataSetTableAdapters.EmpleadosHabilidadesTableAdapter empleadosHabilidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoHabilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDestrezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource habilidadesBindingSource;
        private BarcaRHBDDataSetTableAdapters.HabilidadesTableAdapter habilidadesTableAdapter;
        private System.Windows.Forms.Button btnAgregarHabilidad;
        private System.Windows.Forms.Button btnEliminarHabilidad;
    }
}