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
    public partial class frmMisReferencias : Form
    {
        public frmMisReferencias()
        {
            InitializeComponent();
        }

        private void frmMisReferencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.EmpleadosReferencias' table. You can move, or remove it, as needed.
            this.empleadosReferenciasTableAdapter.Fill(this.barcaRHBDDataSet.EmpleadosReferencias);
            CargarMisReferencias();

        }

        private void CargarMisReferencias()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado }
                };

                DataTable referencias = dbHelper.ExecuteQuery("ConsultarReferenciasPorEmpleado", parameters);
                dataGridViewReferencias.DataSource = referencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar referencias: {ex.Message}");
            }
        }

        private void btnAgregarReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreReferencia.Text) || string.IsNullOrEmpty(txtTelefonoReferencia.Text) || string.IsNullOrEmpty(txtCorreoReferencia.Text) || string.IsNullOrEmpty(txtRelacionReferencia.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado },
                    new SqlParameter("@Nombres", SqlDbType.NVarChar) { Value = txtNombreReferencia.Text },
                    new SqlParameter("@TelefonoCelular", SqlDbType.NVarChar) { Value = txtTelefonoReferencia.Text },
                    new SqlParameter("@CorreoElectronico", SqlDbType.NVarChar) { Value = txtCorreoReferencia.Text },
                    new SqlParameter("@Parentesco", SqlDbType.NVarChar) { Value = txtRelacionReferencia.Text }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarEmpleadoReferencia", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Referencia agregada exitosamente.");
                    CargarMisReferencias(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar referencia: {ex.Message}");
            }
        }

        private void btnEliminarReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewReferencias.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una referencia para eliminar.");
                    return;
                }

                // Obtener el nombre de la referencia seleccionada
                string nombreReferencia = dataGridViewReferencias.SelectedRows[0].Cells["NombreReferencia"].Value.ToString();

                if (string.IsNullOrEmpty(nombreReferencia))
                {
                    MessageBox.Show("No se ha seleccionado una referencia válida.");
                    return;
                }

                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado },
            new SqlParameter("@NombreReferencia", SqlDbType.NVarChar) { Value = nombreReferencia }
                };

                // Confirmar la eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta referencia?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Llamar al procedimiento para eliminar la referencia
                int rowsAffected = dbHelper.ExecuteNonQuery("EliminarEmpleadoReferencia", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Referencia eliminada exitosamente.");
                    CargarMisReferencias(); // Actualiza el DataGridView
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la referencia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la referencia: {ex.Message}");
            }
        }


    }
}
