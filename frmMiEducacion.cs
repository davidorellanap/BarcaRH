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
    public partial class frmMiEducacion : Form
    {
        public frmMiEducacion()
        {
            InitializeComponent();
        }

        private void frmMiEducacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.EmpleadosEducacion' table. You can move, or remove it, as needed.
            this.empleadosEducacionTableAdapter.Fill(this.barcaRHBDDataSet.EmpleadosEducacion);
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Titulos' table. You can move, or remove it, as needed.
            this.titulosTableAdapter.Fill(this.barcaRHBDDataSet.Titulos);
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Academias' table. You can move, or remove it, as needed.
            this.academiasTableAdapter.Fill(this.barcaRHBDDataSet.Academias);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CargarMiEducacion()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado }
                };

                DataTable educacion = dbHelper.ExecuteQuery("ConsultarEducacionPorEmpleado", parameters);
                dataGridViewEducacion.DataSource = educacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar educación: {ex.Message}");
            }
        }

        private void CargarInstituciones()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                DataTable instituciones = dbHelper.ExecuteQuery("ConsultarInstituciones");

                cmbInstituciones.DataSource = instituciones;
                cmbInstituciones.DisplayMember = "NombreInstitucion"; // Nombre visible
                cmbInstituciones.ValueMember = "CodigoInstitucion";   // Valor asociado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar instituciones: {ex.Message}");
            }
        }

        private void CargarTitulos()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                DataTable titulos = dbHelper.ExecuteQuery("ConsultarTitulos");

                cmbTitulos.DataSource = titulos;
                cmbTitulos.DisplayMember = "NombreTitulo"; // Nombre visible
                cmbTitulos.ValueMember = "CodigoTitulo";   // Valor asociado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar títulos: {ex.Message}");
            }
        }

        private void btnAgregarEducacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbInstituciones.Text) || string.IsNullOrEmpty(cmbTitulos.Text))
                {
                    MessageBox.Show("Por favor, selecciona una academia y un título.");
                    return;
                }

                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                // Buscar el código de la academia seleccionada
                SqlParameter[] buscarAcademiaParameters = new SqlParameter[]
                {
            new SqlParameter("@NombreAcademia", SqlDbType.NVarChar) { Value = cmbInstituciones.Text }
                };

                DataTable resultadoAcademia = dbHelper.ExecuteQuery("BuscarCodigoAcademiaPorNombre", buscarAcademiaParameters);

                if (resultadoAcademia.Rows.Count == 0)
                {
                    MessageBox.Show("La academia seleccionada no se encontró en la base de datos.");
                    return;
                }

                int codigoAcademia = Convert.ToInt32(resultadoAcademia.Rows[0]["CodigoAcademia"]);

                // Buscar el código del título seleccionado
                SqlParameter[] buscarTituloParameters = new SqlParameter[]
                {
            new SqlParameter("@NombreTitulo", SqlDbType.NVarChar) { Value = cmbTitulos.Text }
                };

                DataTable resultadoTitulo = dbHelper.ExecuteQuery("BuscarCodigoTituloPorNombre", buscarTituloParameters);

                if (resultadoTitulo.Rows.Count == 0)
                {
                    MessageBox.Show("El título seleccionado no se encontró en la base de datos.");
                    return;
                }

                int codigoTitulo = Convert.ToInt32(resultadoTitulo.Rows[0]["CodigoTitulo"]);

                // Insertar la educación para el empleado autenticado
                SqlParameter[] insertarParameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado },
                    new SqlParameter("@CodigoAcademia", SqlDbType.Int) { Value = codigoAcademia },
                    new SqlParameter("@CodigoTitulo", SqlDbType.Int) { Value = codigoTitulo },
                    new SqlParameter("@FechaInicio", SqlDbType.Date) { Value = dtpFechaInicio.Value },
                    new SqlParameter("@FechaFin", SqlDbType.Date) { Value = dtpFechaFin.Value }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarEmpleadoEducacion", insertarParameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Educación agregada exitosamente.");
                    CargarMiEducacion(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar educación: {ex.Message}");
            }
        }


        private void btnEliminarEducacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewEducacion.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona un registro de educación para eliminar.");
                    return;
                }

                // Obtener los valores necesarios desde el DataGridView
                int codigoInstitucion = Convert.ToInt32(dataGridViewEducacion.SelectedRows[0].Cells["codigoInstitucionDataGridViewTextBoxColumn"].Value);
                int codigoTitulo = Convert.ToInt32(dataGridViewEducacion.SelectedRows[0].Cells["codigoTituloDataGridViewTextBoxColumn"].Value);

                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado },
                    new SqlParameter("@CodigoInstitucion", SqlDbType.Int) { Value = codigoInstitucion },
                    new SqlParameter("@CodigoTitulo", SqlDbType.Int) { Value = codigoTitulo }
                };

                // Confirmar la eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro de educación?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                int rowsAffected = dbHelper.ExecuteNonQuery("EliminarEmpleadoEducacion", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registro de educación eliminado exitosamente.");
                    CargarMiEducacion(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el registro de educación: {ex.Message}");
            }
        }

    }
}
