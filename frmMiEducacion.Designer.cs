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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.barcaRHBDDataSet = new BarcaRH.BarcaRHBDDataSet();
            this.academiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academiasTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.AcademiasTableAdapter();
            this.titulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titulosTableAdapter = new BarcaRH.BarcaRHBDDataSetTableAdapters.TitulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).BeginInit();
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.academiasBindingSource;
            this.comboBox1.DisplayMember = "NombreAcademia";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "NombreAcademia";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.titulosBindingSource;
            this.comboBox2.DisplayMember = "NombreTitulo";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "NombreTitulo";
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
            // frmMiEducacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMiEducacion";
            this.Text = "ACTUALIZACION - MI EDUCACION";
            this.Load += new System.EventHandler(this.frmMiEducacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcaRHBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private BarcaRHBDDataSet barcaRHBDDataSet;
        private System.Windows.Forms.BindingSource academiasBindingSource;
        private BarcaRHBDDataSetTableAdapters.AcademiasTableAdapter academiasTableAdapter;
        private System.Windows.Forms.BindingSource titulosBindingSource;
        private BarcaRHBDDataSetTableAdapters.TitulosTableAdapter titulosTableAdapter;
    }
}