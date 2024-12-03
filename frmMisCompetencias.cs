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
    public partial class frmMisCompetencias : Form
    {
        public frmMisCompetencias()
        {
            InitializeComponent();
        }

        private void frmMisCompetencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.EmpleadosCompetencias' table. You can move, or remove it, as needed.
            this.empleadosCompetenciasTableAdapter.Fill(this.barcaRHBDDataSet.EmpleadosCompetencias);
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Competencias' table. You can move, or remove it, as needed.
            this.competenciasTableAdapter.Fill(this.barcaRHBDDataSet.Competencias);

        }

        private void CargarNivelesDestreza()
        {
            cmbNivelDestreza.Items.AddRange(new string[] { "Novato", "Principiante", "Intermedio", "Avanzado", "Senior" });
            cmbNivelDestreza.SelectedIndex = 0; // Selecciona el primer nivel por defecto
        }


        private void CargarCompetenciasDisponibles()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                DataTable competencias = dbHelper.ExecuteQuery("ConsultarCompetencias");

                cmbCompetencias.DataSource = competencias;
                cmbCompetencias.DisplayMember = "NombreCompetencia"; // Nombre visible
                cmbCompetencias.ValueMember = "CodigoCompetencia";   // Valor asociado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar competencias: {ex.Message}");
            }
        }

        private void CargarMisCompetencias()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado }
                };

                DataTable competencias = dbHelper.ExecuteQuery("ConsultarCompetenciasPorEmpleado", parameters);
                dataGridViewCompetencias.DataSource = competencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar competencias: {ex.Message}");
            }
        }


        private void btnAgregarCompetencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbCompetencias.Text))
                {
                    MessageBox.Show("Por favor, selecciona una competencia.");
                    return;
                }

                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                // Buscar el código de la competencia seleccionada
                SqlParameter[] buscarParameters = new SqlParameter[]
                {
                    new SqlParameter("@NombreCompetencia", SqlDbType.NVarChar) { Value = cmbCompetencias.Text }
                };

                DataTable resultado = dbHelper.ExecuteQuery("BuscarCodigoCompetenciaPorNombre", buscarParameters);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("La competencia seleccionada no se encontró en la base de datos.");
                    return;
                }

                int codigoCompetencia = Convert.ToInt32(resultado.Rows[0]["CodigoCompetencia"]);

                // Insertar la competencia para el empleado autenticado
                SqlParameter[] insertarParameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado },
                    new SqlParameter("@CodigoCompetencia", SqlDbType.Int) { Value = codigoCompetencia },
                    new SqlParameter("@NivelDestreza", SqlDbType.NVarChar) { Value = cmbNivelDestreza.SelectedItem }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarEmpleadoCompetencia", insertarParameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Competencia agregada exitosamente.");
                    CargarMisCompetencias(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar competencia: {ex.Message}");
            }
        }

    }
}
