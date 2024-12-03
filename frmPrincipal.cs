using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarcaRH.frmLogin;
using static System.Net.Mime.MediaTypeNames;

namespace BarcaRH
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados form = new frmEmpleados
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }

        private void habilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabilidades form = new frmHabilidades
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }

        private void competenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompetencias form = new frmCompetencias
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }

        private void academiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademias form = new frmAcademias
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }

        private void titulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTitulos form = new frmTitulos
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (SesionActual.Rol == "Empleado")
            {
                // Deshabilitar opciones exclusivas de Gerente
                menuGestion.Visible = false;
            }
        }

        private void datosEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEmpleado form = new frmDatosEmpleado
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // Cierra la aplicación
        }

        private void complementosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosHabilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMisHabilidades form = new frmMisHabilidades
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }

        private void empleadosCompetenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMisCompetencias form = new frmMisCompetencias
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }

        private void empleadosEducacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMiEducacion form = new frmMiEducacion
            {
                MdiParent = this // Establece el formulario principal como contenedor
            };
            form.Show();
        }
    }
}
