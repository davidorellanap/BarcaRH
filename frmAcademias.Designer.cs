namespace BarcaRH
{
    partial class frmAcademias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcademias));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAcademia = new System.Windows.Forms.TextBox();
            this.cmbEstadoAcademia = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridViewAcademias = new System.Windows.Forms.DataGridView();
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.academiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academiasTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.AcademiasTableAdapter();
            this.codigoAcademiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAcademiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoAcademiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcademias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Academia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // txtNombreAcademia
            // 
            this.txtNombreAcademia.Location = new System.Drawing.Point(125, 38);
            this.txtNombreAcademia.Name = "txtNombreAcademia";
            this.txtNombreAcademia.Size = new System.Drawing.Size(230, 20);
            this.txtNombreAcademia.TabIndex = 2;
            // 
            // cmbEstadoAcademia
            // 
            this.cmbEstadoAcademia.FormattingEnabled = true;
            this.cmbEstadoAcademia.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoAcademia.Location = new System.Drawing.Point(125, 76);
            this.cmbEstadoAcademia.Name = "cmbEstadoAcademia";
            this.cmbEstadoAcademia.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoAcademia.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(551, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(632, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(713, 415);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridViewAcademias
            // 
            this.dataGridViewAcademias.AllowUserToOrderColumns = true;
            this.dataGridViewAcademias.AutoGenerateColumns = false;
            this.dataGridViewAcademias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcademias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoAcademiaDataGridViewTextBoxColumn,
            this.nombreAcademiaDataGridViewTextBoxColumn,
            this.estadoAcademiaDataGridViewTextBoxColumn});
            this.dataGridViewAcademias.DataSource = this.academiasBindingSource;
            this.dataGridViewAcademias.Location = new System.Drawing.Point(15, 139);
            this.dataGridViewAcademias.Name = "dataGridViewAcademias";
            this.dataGridViewAcademias.Size = new System.Drawing.Size(773, 174);
            this.dataGridViewAcademias.TabIndex = 7;
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
            // codigoAcademiaDataGridViewTextBoxColumn
            // 
            this.codigoAcademiaDataGridViewTextBoxColumn.DataPropertyName = "CodigoAcademia";
            this.codigoAcademiaDataGridViewTextBoxColumn.HeaderText = "CodigoAcademia";
            this.codigoAcademiaDataGridViewTextBoxColumn.Name = "codigoAcademiaDataGridViewTextBoxColumn";
            this.codigoAcademiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreAcademiaDataGridViewTextBoxColumn
            // 
            this.nombreAcademiaDataGridViewTextBoxColumn.DataPropertyName = "NombreAcademia";
            this.nombreAcademiaDataGridViewTextBoxColumn.HeaderText = "NombreAcademia";
            this.nombreAcademiaDataGridViewTextBoxColumn.Name = "nombreAcademiaDataGridViewTextBoxColumn";
            this.nombreAcademiaDataGridViewTextBoxColumn.Width = 500;
            // 
            // estadoAcademiaDataGridViewTextBoxColumn
            // 
            this.estadoAcademiaDataGridViewTextBoxColumn.DataPropertyName = "EstadoAcademia";
            this.estadoAcademiaDataGridViewTextBoxColumn.HeaderText = "EstadoAcademia";
            this.estadoAcademiaDataGridViewTextBoxColumn.Name = "estadoAcademiaDataGridViewTextBoxColumn";
            // 
            // frmAcademias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAcademias);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbEstadoAcademia);
            this.Controls.Add(this.txtNombreAcademia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcademias";
            this.Text = "GESTION - ACADEMIAS";
            this.Load += new System.EventHandler(this.frmAcademias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcademias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAcademia;
        private System.Windows.Forms.ComboBox cmbEstadoAcademia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridViewAcademias;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource academiasBindingSource;
        private BarcaRHBDDataSetTableAdapters.AcademiasTableAdapter academiasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAcademiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAcademiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoAcademiaDataGridViewTextBoxColumn;
    }
}