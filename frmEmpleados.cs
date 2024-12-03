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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtIdentificacion.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            cmbEstadoCivil.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            txtDireccion.Clear();
            txtMunicipio.Clear();
            txtCorreoElectronico.Clear();
            txtTelefonoCelular.Clear();
            cmbEstadoLaboral.SelectedIndex = -1;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Identificacion", SqlDbType.BigInt) { Value = txtIdentificacion.Text },
                    new SqlParameter("@Nombres", SqlDbType.NVarChar) { Value = txtNombres.Text },
                    new SqlParameter("@Apellidos", SqlDbType.NVarChar) { Value = txtApellidos.Text },
                    new SqlParameter("@EstadoCivil", SqlDbType.NVarChar) { Value = cmbEstadoCivil.SelectedItem },
                    new SqlParameter("@Sexo", SqlDbType.NVarChar) { Value = cmbSexo.SelectedItem },
                    new SqlParameter("@Direccion", SqlDbType.NVarChar) { Value = txtDireccion.Text },
                    new SqlParameter("@Municipio", SqlDbType.NVarChar) { Value = txtMunicipio.Text },
                    new SqlParameter("@CorreoElectronico", SqlDbType.NVarChar) { Value = txtCorreoElectronico.Text },
                    new SqlParameter("@TelefonoCelular", SqlDbType.Char) { Value = txtTelefonoCelular.Text },
                    new SqlParameter("@EstadoLaboral", SqlDbType.NVarChar) { Value = cmbEstadoLaboral.SelectedItem }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarEmpleado", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Empleado agregado exitosamente.");
                    LimpiarCampos(); // Limpia los campos después de guardar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar empleado: {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.barcaRHBDDataSet.Empleados);

        }
    }
}
