using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BarcaRH
{
    public partial class frmCompetencias : Form
    {
        public frmCompetencias()
        {
            InitializeComponent();
        }

        private void frmCompetencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Competencias' table. You can move, or remove it, as needed.
            this.competenciasTableAdapter.Fill(this.barcaRHBDDataSet.Competencias);

        }

        private void LimpiarCampos()
        {
            txtNombreCompetencia.Clear();
            cmbEstadoCompetencia.SelectedIndex = -1;
        }

        private void CargarCompetencias()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                DataTable competencias = dbHelper.ExecuteQuery("ConsultarCompetencias");
                dataGridViewCompetencias.DataSource = competencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar competencias: {ex.Message}");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NombreCompetencia", SqlDbType.NVarChar) { Value = txtNombreCompetencia.Text },
                    new SqlParameter("@EstadoCompetencia", SqlDbType.NVarChar) { Value = cmbEstadoCompetencia.SelectedItem }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarCompetencia", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Competencia agregada exitosamente.");
                    CargarCompetencias(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar competencia: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCompetencias.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una competencia para eliminar.");
                    return;
                }

                // Obtener el Código de la Competencia seleccionada
                int codigoCompetenciaDataGridViewTextBoxColumn = Convert.ToInt32(dataGridViewCompetencias.SelectedRows[0].Cells["codigoCompetenciaDataGridViewTextBoxColumn"].Value);

                // Confirmar eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta competencia?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Ejecutar la eliminación
                EliminarCompetencia(codigoCompetenciaDataGridViewTextBoxColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la competencia: {ex.Message}");
            }
        }

        private void EliminarCompetencia(int codigoCompetencia)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CodigoCompetencia", SqlDbType.Int) { Value = codigoCompetencia }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("EliminarCompetencia", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Competencia eliminada exitosamente.");
                    CargarCompetencias(); // Actualiza el DataGridView
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
