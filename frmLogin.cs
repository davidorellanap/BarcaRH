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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NombreUsuario", SqlDbType.NVarChar) { Value = txtNombreUsuario.Text },
                    new SqlParameter("@Contrasena", SqlDbType.NVarChar) { Value = txtContrasena.Text }
                };

                DataTable resultado = dbHelper.ExecuteQuery("ValidarUsuario", parameters);

                if (resultado.Rows.Count > 0)
                {
                    // Recuperar datos del usuario autenticado
                    DataRow usuario = resultado.Rows[0];
                    int idUsuario = Convert.ToInt32(usuario["IdUsuario"]);
                    int codigoEmpleado = Convert.ToInt32(usuario["CodigoEmpleado"]);
                    string rol = usuario["Rol"].ToString();

                    // Guardar datos en la sesión global
                    SesionActual.IdUsuario = idUsuario;
                    SesionActual.CodigoEmpleado = codigoEmpleado;
                    SesionActual.Rol = rol;

                    // Abrir el formulario principal
                    frmPrincipal principal = new frmPrincipal();
                    this.Hide();
                    principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}");
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Confirmar cierre de la aplicación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas salir?",
                                                "Confirmar Salida",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); // Cierra la aplicación
            }
        }
    }
}
