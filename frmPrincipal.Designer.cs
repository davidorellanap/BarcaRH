namespace BarcaRH
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuGestion = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosHabilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosCompetenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosEducacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosReferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGestion
            // 
            this.menuGestion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestiónToolStripMenuItem,
            this.complementosToolStripMenuItem});
            this.menuGestion.Location = new System.Drawing.Point(0, 0);
            this.menuGestion.Name = "menuGestion";
            this.menuGestion.Size = new System.Drawing.Size(800, 24);
            this.menuGestion.TabIndex = 1;
            this.menuGestion.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integrantesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.habilidadesToolStripMenuItem,
            this.competenciasToolStripMenuItem,
            this.academiasToolStripMenuItem,
            this.titulosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // habilidadesToolStripMenuItem
            // 
            this.habilidadesToolStripMenuItem.Name = "habilidadesToolStripMenuItem";
            this.habilidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habilidadesToolStripMenuItem.Text = "Habilidades";
            this.habilidadesToolStripMenuItem.Click += new System.EventHandler(this.habilidadesToolStripMenuItem_Click);
            // 
            // competenciasToolStripMenuItem
            // 
            this.competenciasToolStripMenuItem.Name = "competenciasToolStripMenuItem";
            this.competenciasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.competenciasToolStripMenuItem.Text = "Competencias";
            this.competenciasToolStripMenuItem.Click += new System.EventHandler(this.competenciasToolStripMenuItem_Click);
            // 
            // academiasToolStripMenuItem
            // 
            this.academiasToolStripMenuItem.Name = "academiasToolStripMenuItem";
            this.academiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.academiasToolStripMenuItem.Text = "Academias";
            this.academiasToolStripMenuItem.Click += new System.EventHandler(this.academiasToolStripMenuItem_Click);
            // 
            // titulosToolStripMenuItem
            // 
            this.titulosToolStripMenuItem.Name = "titulosToolStripMenuItem";
            this.titulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.titulosToolStripMenuItem.Text = "Titulos";
            this.titulosToolStripMenuItem.Click += new System.EventHandler(this.titulosToolStripMenuItem_Click);
            // 
            // complementosToolStripMenuItem
            // 
            this.complementosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosEmpleadosToolStripMenuItem,
            this.empleadosHabilidadesToolStripMenuItem,
            this.empleadosCompetenciasToolStripMenuItem,
            this.empleadosEducacionToolStripMenuItem,
            this.empleadosReferenciasToolStripMenuItem});
            this.complementosToolStripMenuItem.Name = "complementosToolStripMenuItem";
            this.complementosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.complementosToolStripMenuItem.Text = "Actualizaciones";
            this.complementosToolStripMenuItem.Click += new System.EventHandler(this.complementosToolStripMenuItem_Click);
            // 
            // datosEmpleadosToolStripMenuItem
            // 
            this.datosEmpleadosToolStripMenuItem.Name = "datosEmpleadosToolStripMenuItem";
            this.datosEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.datosEmpleadosToolStripMenuItem.Text = "Empleados Generales";
            this.datosEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.datosEmpleadosToolStripMenuItem_Click);
            // 
            // empleadosHabilidadesToolStripMenuItem
            // 
            this.empleadosHabilidadesToolStripMenuItem.Name = "empleadosHabilidadesToolStripMenuItem";
            this.empleadosHabilidadesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.empleadosHabilidadesToolStripMenuItem.Text = "Empleados Habilidades";
            this.empleadosHabilidadesToolStripMenuItem.Click += new System.EventHandler(this.empleadosHabilidadesToolStripMenuItem_Click);
            // 
            // empleadosCompetenciasToolStripMenuItem
            // 
            this.empleadosCompetenciasToolStripMenuItem.Name = "empleadosCompetenciasToolStripMenuItem";
            this.empleadosCompetenciasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.empleadosCompetenciasToolStripMenuItem.Text = "Empleados Competencias";
            this.empleadosCompetenciasToolStripMenuItem.Click += new System.EventHandler(this.empleadosCompetenciasToolStripMenuItem_Click);
            // 
            // empleadosEducacionToolStripMenuItem
            // 
            this.empleadosEducacionToolStripMenuItem.Name = "empleadosEducacionToolStripMenuItem";
            this.empleadosEducacionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.empleadosEducacionToolStripMenuItem.Text = "Empleados Educacion";
            this.empleadosEducacionToolStripMenuItem.Click += new System.EventHandler(this.empleadosEducacionToolStripMenuItem_Click);
            // 
            // empleadosReferenciasToolStripMenuItem
            // 
            this.empleadosReferenciasToolStripMenuItem.Name = "empleadosReferenciasToolStripMenuItem";
            this.empleadosReferenciasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.empleadosReferenciasToolStripMenuItem.Text = "Empleados Referencias";
            this.empleadosReferenciasToolStripMenuItem.Click += new System.EventHandler(this.empleadosReferenciasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // integrantesToolStripMenuItem
            // 
            this.integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            this.integrantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.integrantesToolStripMenuItem.Text = "Integrantes";
            this.integrantesToolStripMenuItem.Click += new System.EventHandler(this.integrantesToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuGestion);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGestion;
            this.Name = "frmPrincipal";
            this.Text = "BARCARH - INICIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuGestion.ResumeLayout(false);
            this.menuGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGestion;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complementosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosHabilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosCompetenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosEducacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosReferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrantesToolStripMenuItem;
    }
}