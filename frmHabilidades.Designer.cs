﻿namespace BarcaRH
{
    partial class frmHabilidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHabilidades));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreHabilidad = new System.Windows.Forms.TextBox();
            this.cmbEstadoHabilidad = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridViewHabilidades = new System.Windows.Forms.DataGridView();
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.habilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habilidadesTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.HabilidadesTableAdapter();
            this.codigoHabilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreHabilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoHabilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabilidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Habilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // txtNombreHabilidad
            // 
            this.txtNombreHabilidad.Location = new System.Drawing.Point(147, 45);
            this.txtNombreHabilidad.Name = "txtNombreHabilidad";
            this.txtNombreHabilidad.Size = new System.Drawing.Size(184, 20);
            this.txtNombreHabilidad.TabIndex = 2;
            // 
            // cmbEstadoHabilidad
            // 
            this.cmbEstadoHabilidad.FormattingEnabled = true;
            this.cmbEstadoHabilidad.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoHabilidad.Location = new System.Drawing.Point(147, 83);
            this.cmbEstadoHabilidad.Name = "cmbEstadoHabilidad";
            this.cmbEstadoHabilidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoHabilidad.TabIndex = 3;
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
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridViewHabilidades
            // 
            this.dataGridViewHabilidades.AllowUserToOrderColumns = true;
            this.dataGridViewHabilidades.AutoGenerateColumns = false;
            this.dataGridViewHabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoHabilidadDataGridViewTextBoxColumn,
            this.nombreHabilidadDataGridViewTextBoxColumn,
            this.estadoHabilidadDataGridViewTextBoxColumn});
            this.dataGridViewHabilidades.DataSource = this.habilidadesBindingSource;
            this.dataGridViewHabilidades.Location = new System.Drawing.Point(147, 140);
            this.dataGridViewHabilidades.Name = "dataGridViewHabilidades";
            this.dataGridViewHabilidades.Size = new System.Drawing.Size(427, 150);
            this.dataGridViewHabilidades.TabIndex = 8;
            this.dataGridViewHabilidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHabilidades_CellContentClick);
            // 
            // barcaRHBDDataSet
            // 
            this.barcaRHBDDataSet.DataSetName = "BarcaRHBDDataSet";
            this.barcaRHBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // codigoHabilidadDataGridViewTextBoxColumn
            // 
            this.codigoHabilidadDataGridViewTextBoxColumn.DataPropertyName = "CodigoHabilidad";
            this.codigoHabilidadDataGridViewTextBoxColumn.HeaderText = "CodigoHabilidad";
            this.codigoHabilidadDataGridViewTextBoxColumn.Name = "codigoHabilidadDataGridViewTextBoxColumn";
            this.codigoHabilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreHabilidadDataGridViewTextBoxColumn
            // 
            this.nombreHabilidadDataGridViewTextBoxColumn.DataPropertyName = "NombreHabilidad";
            this.nombreHabilidadDataGridViewTextBoxColumn.HeaderText = "NombreHabilidad";
            this.nombreHabilidadDataGridViewTextBoxColumn.Name = "nombreHabilidadDataGridViewTextBoxColumn";
            // 
            // estadoHabilidadDataGridViewTextBoxColumn
            // 
            this.estadoHabilidadDataGridViewTextBoxColumn.DataPropertyName = "EstadoHabilidad";
            this.estadoHabilidadDataGridViewTextBoxColumn.HeaderText = "EstadoHabilidad";
            this.estadoHabilidadDataGridViewTextBoxColumn.Name = "estadoHabilidadDataGridViewTextBoxColumn";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(713, 415);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar celdas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmHabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGridViewHabilidades);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbEstadoHabilidad);
            this.Controls.Add(this.txtNombreHabilidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHabilidades";
            this.Text = "GESTION - HABILIDADES";
            this.Load += new System.EventHandler(this.frmHabilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabilidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreHabilidad;
        private System.Windows.Forms.ComboBox cmbEstadoHabilidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewHabilidades;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource habilidadesBindingSource;
        private BarcaRHBDDataSetTableAdapters.HabilidadesTableAdapter habilidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoHabilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreHabilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoHabilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpiar;
    }
}