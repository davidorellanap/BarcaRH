namespace BarcaRH
{
    partial class frmTitulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitulos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreTitulo = new System.Windows.Forms.TextBox();
            this.cmbEstadoTitulo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridViewTitulos = new System.Windows.Forms.DataGridView();
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.consultarTitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultarTitulosTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.ConsultarTitulosTableAdapter();
            this.codigoTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarTitulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // txtNombreTitulo
            // 
            this.txtNombreTitulo.Location = new System.Drawing.Point(91, 34);
            this.txtNombreTitulo.Name = "txtNombreTitulo";
            this.txtNombreTitulo.Size = new System.Drawing.Size(287, 20);
            this.txtNombreTitulo.TabIndex = 2;
            // 
            // cmbEstadoTitulo
            // 
            this.cmbEstadoTitulo.FormattingEnabled = true;
            this.cmbEstadoTitulo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoTitulo.Location = new System.Drawing.Point(93, 72);
            this.cmbEstadoTitulo.Name = "cmbEstadoTitulo";
            this.cmbEstadoTitulo.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoTitulo.TabIndex = 3;
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
            // dataGridViewTitulos
            // 
            this.dataGridViewTitulos.AllowUserToOrderColumns = true;
            this.dataGridViewTitulos.AutoGenerateColumns = false;
            this.dataGridViewTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTitulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTituloDataGridViewTextBoxColumn,
            this.nombreTituloDataGridViewTextBoxColumn,
            this.estadoTituloDataGridViewTextBoxColumn});
            this.dataGridViewTitulos.DataSource = this.consultarTitulosBindingSource;
            this.dataGridViewTitulos.Location = new System.Drawing.Point(39, 167);
            this.dataGridViewTitulos.Name = "dataGridViewTitulos";
            this.dataGridViewTitulos.Size = new System.Drawing.Size(698, 150);
            this.dataGridViewTitulos.TabIndex = 7;
            // 
            // barcaRHBDDataSet
            // 
            this.barcaRHBDDataSet.DataSetName = "BarcaRHBDDataSet";
            this.barcaRHBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultarTitulosBindingSource
            // 
            this.consultarTitulosBindingSource.DataMember = "ConsultarTitulos";
            this.consultarTitulosBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // consultarTitulosTableAdapter
            // 
            this.consultarTitulosTableAdapter.ClearBeforeFill = true;
            // 
            // codigoTituloDataGridViewTextBoxColumn
            // 
            this.codigoTituloDataGridViewTextBoxColumn.DataPropertyName = "CodigoTitulo";
            this.codigoTituloDataGridViewTextBoxColumn.HeaderText = "CodigoTitulo";
            this.codigoTituloDataGridViewTextBoxColumn.Name = "codigoTituloDataGridViewTextBoxColumn";
            this.codigoTituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreTituloDataGridViewTextBoxColumn
            // 
            this.nombreTituloDataGridViewTextBoxColumn.DataPropertyName = "NombreTitulo";
            this.nombreTituloDataGridViewTextBoxColumn.HeaderText = "NombreTitulo";
            this.nombreTituloDataGridViewTextBoxColumn.Name = "nombreTituloDataGridViewTextBoxColumn";
            this.nombreTituloDataGridViewTextBoxColumn.Width = 450;
            // 
            // estadoTituloDataGridViewTextBoxColumn
            // 
            this.estadoTituloDataGridViewTextBoxColumn.DataPropertyName = "EstadoTitulo";
            this.estadoTituloDataGridViewTextBoxColumn.HeaderText = "EstadoTitulo";
            this.estadoTituloDataGridViewTextBoxColumn.Name = "estadoTituloDataGridViewTextBoxColumn";
            // 
            // frmTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTitulos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbEstadoTitulo);
            this.Controls.Add(this.txtNombreTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTitulos";
            this.Text = "GESTION - TITULOS";
            this.Load += new System.EventHandler(this.frmTitulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarTitulosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreTitulo;
        private System.Windows.Forms.ComboBox cmbEstadoTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridViewTitulos;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource consultarTitulosBindingSource;
        private BarcaRHBDDataSetTableAdapters.ConsultarTitulosTableAdapter consultarTitulosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoTituloDataGridViewTextBoxColumn;
    }
}