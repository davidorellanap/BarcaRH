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
    public partial class frmDatosEmpleado : Form
    {
        public frmDatosEmpleado()
        {
            InitializeComponent();
        }

        private void CargarDatosEmpleado(int codigoEmpleado)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = codigoEmpleado }
                };

                DataTable empleado = dbHelper.ExecuteQuery("ConsultarEmpleadoPorCodigo", parameters);

                if (empleado.Rows.Count > 0)
                {
                    DataRow row = empleado.Rows[0];
                    txtNombres.Text = row["Nombres"].ToString();
                    txtApellidos.Text = row["Apellidos"].ToString();
                    txtDireccion.Text = row["Direccion"].ToString();
                    txtCelular.Text = row["TelefonoCelular"].ToString();
                    txtEmail.Text = row["CorreoElectronico"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró información del empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }



        private void frmDatosEmpleado_Load(object sender, EventArgs e)
        {
            //SesionActual.CodigoEmpleado = 5;
            CargarDatosEmpleado(SesionActual.CodigoEmpleado);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoEmpleado", SqlDbType.Int) { Value = SesionActual.CodigoEmpleado },
                    new SqlParameter("@Nombres", SqlDbType.NVarChar) { Value = txtNombres.Text },
                    new SqlParameter("@Apellidos", SqlDbType.NVarChar) { Value = txtApellidos.Text },
                    new SqlParameter("@Direccion", SqlDbType.NVarChar) { Value = txtDireccion.Text },
                    new SqlParameter("@TelefonoCelular", SqlDbType.Char) { Value = txtCelular.Text },
                    new SqlParameter("@CorreoElectronico", SqlDbType.NVarChar) { Value = txtEmail.Text },
                    new SqlParameter("@Municipio", SqlDbType.NVarChar) { Value = txtMunicipio.Text },
                    new SqlParameter("@EstadoCivil", SqlDbType.NVarChar) { Value = cmbEstadoCivil.SelectedItem },
                    new SqlParameter("@EstadoLaboral", SqlDbType.NVarChar) { Value = cmbEstado.SelectedItem },
                    new SqlParameter("@Sexo", SqlDbType.NVarChar) { Value = cmbSexo.SelectedItem }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("ActualizarEmpleado", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Información actualizada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los datos: {ex.Message}");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
