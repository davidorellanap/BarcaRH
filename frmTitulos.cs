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
    public partial class frmTitulos : Form
    {
        public frmTitulos()
        {
            InitializeComponent();
        }

        private void frmTitulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcaRHBDDataSet.ConsultarTitulos' table. You can move, or remove it, as needed.
            this.consultarTitulosTableAdapter.Fill(this.barcaRHBDDataSet.ConsultarTitulos);

        }

        private void CargarTitulos()
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                DataTable titulos = dbHelper.ExecuteQuery("ConsultarTitulos");
                dataGridViewTitulos.DataSource = titulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar títulos: {ex.Message}");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarTitulos();
        }
        private void LimpiarCampos()
        {
            txtNombreTitulo.Clear();
            cmbEstadoTitulo.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NombreTitulo", SqlDbType.NVarChar) { Value = txtNombreTitulo.Text },
                    new SqlParameter("@EstadoTitulo", SqlDbType.NVarChar) { Value = cmbEstadoTitulo.SelectedItem }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("InsertarTitulo", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Título agregado exitosamente.");
                    CargarTitulos(); // Actualiza el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar título: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTitulos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona un título para eliminar.");
                    return;
                }

                // Obtener el Código del Título seleccionado
                int codigoTituloDataGridViewTextBoxColumn = Convert.ToInt32(dataGridViewTitulos.SelectedRows[0].Cells["codigoTituloDataGridViewTextBoxColumn"].Value);

                // Confirmar eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este título?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Ejecutar la eliminación
                EliminarTitulo(codigoTituloDataGridViewTextBoxColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el título: {ex.Message}");
            }
        }

        private void EliminarTitulo(int codigoTitulo)
        {
            try
            {
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CodigoTitulo", SqlDbType.Int) { Value = codigoTitulo }
                };

                int rowsAffected = dbHelper.ExecuteNonQuery("EliminarTitulo", parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Título eliminado exitosamente.");
                    CargarTitulos(); // Actualiza el DataGridView
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
