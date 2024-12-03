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
    public partial class frmMisHabilidades : Form
    {
        public frmMisHabilidades()
        {
            InitializeComponent();
        }

        private void frmMisHabilidades_Load(object sender, EventArgs e)
        {
            CargarMisHabilidades();
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Habilidades' table. You can move, or remove it, as needed.
            this.habilidadesTableAdapter.Fill(this.barcaRHBDDataSet.Habilidades);
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.EmpleadosHabilidades' table. You can move, or remove it, as needed.
            this.empleadosHabilidadesTableAdapter.Fill(this.barcaRHBDDataSet.EmpleadosHabilidades);

        }

        private void CargarMisHabilidades()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado }
                };

                DataTable habilidades = dbHelper.ExecuteQuery("ConsultarHabilidadesPorEmpleado", parameters);
                dataGridViewHabilidades.DataSource = habilidades;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar habilidades: {ex.Message}");
            }
        }

        private void btnAgregarHabilidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbHabilidades.Text))
                {
                    MessageBox.Show("Por favor, selecciona una habilidad.");
                    return;
                }

                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                // Buscar el código de la habilidad seleccionada
                SqlParameter[] buscarParameters = new SqlParameter[]
                {
                    new SqlParameter("@NombreHabilidad", SqlDbType.NVarChar) { Value = cmbHabilidades.Text }
                };

                DataTable resultado = dbHelper.ExecuteQuery("BuscarCodigoHabilidadPorNombre", buscarParameters);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("La habilidad seleccionada no se encontró en la base de datos.");
                    return;
                }

                int codigoHabilidad = Convert.ToInt32(resultado.Rows[0]["CodigoHabilidad"]);

                // Insertar la habilidad para el empleado autenticado
                SqlParameter[] insertarParameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado },
                    new SqlParameter("@CodigoHabilidad", SqlDbType.Int) { Value = codigoHabilidad },
                    new SqlParameter("@NivelDestreza", SqlDbType.NVarChar) { Value = cmbNivelDestreza.SelectedItem }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarEmpleadoHabilidad", insertarParameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Habilidad agregada exitosamente.");
                    CargarMisHabilidades(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar habilidad: {ex.Message}");
            }
        }


        private void btnEliminarHabilidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHabilidades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una habilidad para eliminar.");
                    return;
                }

                int codigoHabilidadDataGridViewTextBoxColumn = Convert.ToInt32(dataGridViewHabilidades.SelectedRows[0].Cells["codigoHabilidadDataGridViewTextBoxColumn"].Value);

                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado },
                    new SqlParameter("@CodigoHabilidad", SqlDbType.Int) { Value = codigoHabilidadDataGridViewTextBoxColumn }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("EliminarEmpleadoHabilidad", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Habilidad eliminada exitosamente.");
                    CargarMisHabilidades(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar habilidad: {ex.Message}");
            }
        }

    }
}
