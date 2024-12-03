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
    public partial class frmHabilidades : Form
    {
        public frmHabilidades()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txtNombreHabilidad.Clear();
            cmbEstadoHabilidad.SelectedIndex = -1;
        }

        private void EliminarHabilidad(int codigoHabilidad)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoHabilidad", SqlDbType.Int) { Value = codigoHabilidad }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("EliminarHabilidad", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Habilidad eliminada exitosamente.");
                    CargarHabilidades(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la eliminación: {ex.Message}");
            }
        }


        private void CargarHabilidades()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                DataTable habilidades = dbHelper.ExecuteQuery("ConsultarHabilidades");
                dataGridViewHabilidades.DataSource = habilidades;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar habilidades: {ex.Message}");
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
                    new SqlParameter("@NombreHabilidad", SqlDbType.NVarChar) { Value = txtNombreHabilidad.Text },
                    new SqlParameter("@EstadoHabilidad", SqlDbType.NVarChar) { Value = cmbEstadoHabilidad.SelectedItem }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarHabilidad", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Habilidad agregada exitosamente.");
                    CargarHabilidades(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar habilidad: {ex.Message}");
            }
        }

        private void frmHabilidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Habilidades' table. You can move, or remove it, as needed.
            this.habilidadesTableAdapter.Fill(this.barcaRHBDDataSet.Habilidades);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHabilidades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una habilidad para eliminar.");
                    return;
                }

                // Obtener el Código de la Habilidad seleccionada
                int codigoHabilidadDataGridViewTextBoxColumn = Convert.ToInt32(dataGridViewHabilidades.SelectedRows[0].Cells["codigoHabilidadDataGridViewTextBoxColumn"].Value);

                // Confirmar eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta habilidad?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Ejecutar la eliminación
                EliminarHabilidad(codigoHabilidadDataGridViewTextBoxColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la habilidad: {ex.Message}");
            }
        }

        private void dataGridViewHabilidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
