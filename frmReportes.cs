using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Data.SqlClient;

namespace BarcaRH
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos de los empleados junto con las relaciones (habilidades, competencias, títulos, etc.)
                string connectionString = "Server=SV-11L5AN0\\SQLEXPRESS;Database=BarcaRHBD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                SqlParameter[] parameters = new SqlParameter[] { };

                // Consultar todos los empleados y sus datos relacionados
                DataTable empleadosData = dbHelper.ExecuteQuery("ConsultaEmpleadosConDatosRelacionados", parameters);

                // Si no hay datos, mostrar un mensaje y salir
                if (empleadosData.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para generar el reporte.");
                    return;
                }
                

                // Crear un archivo Excel
                using (var package = new ExcelPackage())
                {
                    // Crear la primera hoja "Sheet1"
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Insertar los encabezados
                    worksheet.Cells[1, 1].Value = "CodigoEmpleado";
                    worksheet.Cells[1, 2].Value = "Nombres";
                    worksheet.Cells[1, 3].Value = "Apellidos";
                    worksheet.Cells[1, 4].Value = "Direccion";
                    worksheet.Cells[1, 5].Value = "TelefonoCelular";
                    worksheet.Cells[1, 6].Value = "CorreoElectronico";
                    worksheet.Cells[1, 7].Value = "Habilidades";
                    worksheet.Cells[1, 8].Value = "Competencias";
                    worksheet.Cells[1, 9].Value = "Titulos";
                    worksheet.Cells[1, 10].Value = "Instituciones";
                    worksheet.Cells[1, 11].Value = "Referencias";

                    // Insertar los datos
                    int row = 2;
                    foreach (DataRow dataRow in empleadosData.Rows)
                    {
                        worksheet.Cells[row, 1].Value = dataRow["CodigoEmpleado"];
                        worksheet.Cells[row, 2].Value = dataRow["Nombres"];
                        worksheet.Cells[row, 3].Value = dataRow["Apellidos"];
                        worksheet.Cells[row, 4].Value = dataRow["Direccion"];
                        worksheet.Cells[row, 5].Value = dataRow["TelefonoCelular"];
                        worksheet.Cells[row, 6].Value = dataRow["CorreoElectronico"];
                        worksheet.Cells[row, 7].Value = dataRow["Habilidades"];
                        worksheet.Cells[row, 8].Value = dataRow["Competencias"];
                        worksheet.Cells[row, 9].Value = dataRow["Titulos"];
                        worksheet.Cells[row, 10].Value = dataRow["Instituciones"];
                        worksheet.Cells[row, 11].Value = dataRow["Referencias"];
                        row++;
                    }

                    // Abrir el cuadro de diálogo para guardar el archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Guardar Reporte de Empleados";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo en la ubicación seleccionada
                        FileInfo file = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(file);

                        MessageBox.Show("Reporte generado y guardado exitosamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}");
            }
        }
    }
}
