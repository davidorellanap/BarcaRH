namespace BarcaRH
{
    partial class frmMisReferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMisReferencias));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreReferencia = new System.Windows.Forms.TextBox();
            this.txtTelefonoReferencia = new System.Windows.Forms.TextBox();
            this.txtCorreoReferencia = new System.Windows.Forms.TextBox();
            this.txtRelacionReferencia = new System.Windows.Forms.TextBox();
            this.btnAgregarReferencia = new System.Windows.Forms.Button();
            this.btnEliminarReferencia = new System.Windows.Forms.Button();
            this.dataGridViewReferencias = new System.Windows.Forms.DataGridView();
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.empleadosReferenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosReferenciasTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.EmpleadosReferenciasTableAdapter();
            this.codigoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentescoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosReferenciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Relacion";
            // 
            // txtNombreReferencia
            // 
            this.txtNombreReferencia.Location = new System.Drawing.Point(88, 30);
            this.txtNombreReferencia.Name = "txtNombreReferencia";
            this.txtNombreReferencia.Size = new System.Drawing.Size(422, 20);
            this.txtNombreReferencia.TabIndex = 4;
            // 
            // txtTelefonoReferencia
            // 
            this.txtTelefonoReferencia.Location = new System.Drawing.Point(88, 74);
            this.txtTelefonoReferencia.Name = "txtTelefonoReferencia";
            this.txtTelefonoReferencia.Size = new System.Drawing.Size(422, 20);
            this.txtTelefonoReferencia.TabIndex = 5;
            // 
            // txtCorreoReferencia
            // 
            this.txtCorreoReferencia.Location = new System.Drawing.Point(88, 120);
            this.txtCorreoReferencia.Name = "txtCorreoReferencia";
            this.txtCorreoReferencia.Size = new System.Drawing.Size(422, 20);
            this.txtCorreoReferencia.TabIndex = 6;
            // 
            // txtRelacionReferencia
            // 
            this.txtRelacionReferencia.Location = new System.Drawing.Point(88, 157);
            this.txtRelacionReferencia.Name = "txtRelacionReferencia";
            this.txtRelacionReferencia.Size = new System.Drawing.Size(422, 20);
            this.txtRelacionReferencia.TabIndex = 7;
            // 
            // btnAgregarReferencia
            // 
            this.btnAgregarReferencia.Location = new System.Drawing.Point(587, 415);
            this.btnAgregarReferencia.Name = "btnAgregarReferencia";
            this.btnAgregarReferencia.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarReferencia.TabIndex = 8;
            this.btnAgregarReferencia.Text = "Agregar";
            this.btnAgregarReferencia.UseVisualStyleBackColor = true;
            this.btnAgregarReferencia.Click += new System.EventHandler(this.btnAgregarReferencia_Click);
            // 
            // btnEliminarReferencia
            // 
            this.btnEliminarReferencia.Location = new System.Drawing.Point(669, 415);
            this.btnEliminarReferencia.Name = "btnEliminarReferencia";
            this.btnEliminarReferencia.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarReferencia.TabIndex = 9;
            this.btnEliminarReferencia.Text = "Eliminar";
            this.btnEliminarReferencia.UseVisualStyleBackColor = true;
            this.btnEliminarReferencia.Click += new System.EventHandler(this.btnEliminarReferencia_Click);
            // 
            // dataGridViewReferencias
            // 
            this.dataGridViewReferencias.AutoGenerateColumns = false;
            this.dataGridViewReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEmpleadoDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.parentescoDataGridViewTextBoxColumn,
            this.telefonoCelularDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn});
            this.dataGridViewReferencias.DataSource = this.empleadosReferenciasBindingSource;
            this.dataGridViewReferencias.Location = new System.Drawing.Point(88, 203);
            this.dataGridViewReferencias.Name = "dataGridViewReferencias";
            this.dataGridViewReferencias.Size = new System.Drawing.Size(606, 150);
            this.dataGridViewReferencias.TabIndex = 10;
            // 
            // barcaRHBDDataSet
            // 
            this.barcaRHBDDataSet.DataSetName = "BarcaRHBDDataSet";
            this.barcaRHBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosReferenciasBindingSource
            // 
            this.empleadosReferenciasBindingSource.DataMember = "EmpleadosReferencias";
            this.empleadosReferenciasBindingSource.DataSource = this.barcaRHBDDataSet;
            // 
            // empleadosReferenciasTableAdapter
            // 
            this.empleadosReferenciasTableAdapter.ClearBeforeFill = true;
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.Name = "codigoEmpleadoDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // parentescoDataGridViewTextBoxColumn
            // 
            this.parentescoDataGridViewTextBoxColumn.DataPropertyName = "Parentesco";
            this.parentescoDataGridViewTextBoxColumn.HeaderText = "Parentesco";
            this.parentescoDataGridViewTextBoxColumn.Name = "parentescoDataGridViewTextBoxColumn";
            // 
            // telefonoCelularDataGridViewTextBoxColumn
            // 
            this.telefonoCelularDataGridViewTextBoxColumn.DataPropertyName = "TelefonoCelular";
            this.telefonoCelularDataGridViewTextBoxColumn.HeaderText = "TelefonoCelular";
            this.telefonoCelularDataGridViewTextBoxColumn.Name = "telefonoCelularDataGridViewTextBoxColumn";
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            // 
            // frmMisReferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReferencias);
            this.Controls.Add(this.btnEliminarReferencia);
            this.Controls.Add(this.btnAgregarReferencia);
            this.Controls.Add(this.txtRelacionReferencia);
            this.Controls.Add(this.txtCorreoReferencia);
            this.Controls.Add(this.txtTelefonoReferencia);
            this.Controls.Add(this.txtNombreReferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMisReferencias";
            this.Text = "ACTUALIZACIONES - MIS REFERENCIAS";
            this.Load += new System.EventHandler(this.frmMisReferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosReferenciasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreReferencia;
        private System.Windows.Forms.TextBox txtTelefonoReferencia;
        private System.Windows.Forms.TextBox txtCorreoReferencia;
        private System.Windows.Forms.TextBox txtRelacionReferencia;
        private System.Windows.Forms.Button btnAgregarReferencia;
        private System.Windows.Forms.Button btnEliminarReferencia;
        private System.Windows.Forms.DataGridView dataGridViewReferencias;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource empleadosReferenciasBindingSource;
        private BarcaRHBDDataSetTableAdapters.EmpleadosReferenciasTableAdapter empleadosReferenciasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentescoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
    }
}