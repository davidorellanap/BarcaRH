using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcaRH
{
    public partial class frmMiEducacion : Form
    {
        public frmMiEducacion()
        {
            InitializeComponent();
        }

        private void frmMiEducacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Titulos' table. You can move, or remove it, as needed.
            this.titulosTableAdapter.Fill(this.barcaRHBDDataSet.Titulos);
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Academias' table. You can move, or remove it, as needed.
            this.academiasTableAdapter.Fill(this.barcaRHBDDataSet.Academias);

        }
    }
}
