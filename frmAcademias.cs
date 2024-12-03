using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcaRH
{
    public partial class frmAcademias : Form
    {
        public frmAcademias()
        {
            InitializeComponent();
        }

        private void frmAcademias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Academias' table. You can move, or remove it, as needed.
            this.academiasTableAdapter.Fill(this.barcaRHBDDataSet.Academias);

        }

        private void LimpiarCampos()
        {
            txtNombreAcademia.Clear();
            cmbEstadoAcademia.SelectedIndex = -1;
        }

        private void CargarAcademias()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                DataTable academias = dbHelper.ExecuteQuery("ConsultarAcademias");
                dataGridViewAcademias.DataSource = academias;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar academias: {ex.Message}");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarAcademias();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NombreAcademia", SqlDbType.NVarChar) { Value = txtNombreAcademia.Text },
                    new SqlParameter("@EstadoAcademia", SqlDbType.NVarChar) { Value = cmbEstadoAcademia.SelectedItem }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarAcademia", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Academia agregada exitosamente.");
                    CargarAcademias(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar academia: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAcademias.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una academia para eliminar.");
                    return;
                }

                // Obtener el Código de la Academia seleccionada
                int codigoAcademiaDataGridViewTextBoxColumn = Convert.ToInt32(dataGridViewAcademias.SelectedRows[0].Cells["codigoAcademiaDataGridViewTextBoxColumn"].Value);

                // Confirmar eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta academia?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Ejecutar la eliminación
                EliminarAcademia(codigoAcademiaDataGridViewTextBoxColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la academia: {ex.Message}");
            }
        }

        private void EliminarAcademia(int codigoAcademia)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CodigoAcademia", SqlDbType.Int) { Value = codigoAcademia }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("EliminarAcademia", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Academia eliminada exitosamente.");
                    CargarAcademias(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la eliminación: {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
