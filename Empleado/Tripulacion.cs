using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SystemAirline___PROYECTO.Empleado
{
    public partial class Tripulacion : Form
    {
        public Tripulacion()
        {
            InitializeComponent();
        }

        private void Tripulacion_Load(object sender, EventArgs e)
        {
            CargarTripulacion(); // Carga los datos en el DataGridView al iniciar el formulario
        }

        // Método para cargar los datos de la tabla 'rutas' en el DataGridView
        private void CargarTripulacion()
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "SELECT id_tripulacion, nombre_tripulacion FROM tripulacion";
                using (var adapter = new MySqlDataAdapter(query, conexion))
                {
                    var dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvTripulacion.DataSource = dataTable;
                }
            }
        }

        private void btnAgregarTripulacion_Click(object sender, EventArgs e)
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                {
                    conexion.Open();
                    string query = "INSERT INTO tripulacion (nombre_tripulacion) VALUES (@nombre_tripulacion)";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre_tripulacion", txtNombreTripulacion.Text);
                     

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Tripulacion agregada exitosamente.");
                    }

                    CargarTripulacion();
                }

            }
        }

        private void btnModificartripulacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya al menos una fila seleccionada
                if (dgvTripulacion.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una tripulación para modificar.");
                    return;
                }

                // Obtener el valor del ID de la tripulación de la fila seleccionada
                var selectedCellValue = dgvTripulacion.SelectedRows[0].Cells["id_Tripulacion"].Value;

                // Verificar que la celda contenga un valor válido
                if (selectedCellValue == null || string.IsNullOrEmpty(selectedCellValue.ToString()))
                {
                    MessageBox.Show("El ID de la tripulación no es válido.");
                    return;
                }

                // Intentar convertir el valor a entero
                int id_Tripulacion;
                if (!int.TryParse(selectedCellValue.ToString(), out id_Tripulacion))
                {
                    MessageBox.Show("El ID de la tripulación no es un número válido.");
                    return;
                }

                // Ejecutar la actualización en la base de datos
                using (var conexion = DatabaseConnection.conexion())
                {
                    conexion.Open();
                    string query = "UPDATE tripulacion SET nombre_tripulacion = @nombre_tripulacion WHERE id_tripulacion = @id";

                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre_tripulacion", txtNombreTripulacion.Text);
                        comando.Parameters.AddWithValue("@id", id_Tripulacion);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Tripulación modificada exitosamente.");
                    }
                }

                // Actualizar el DataGridView después de modificar
                CargarTripulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnEliminarTripulacion_Click(object sender, EventArgs e)
        {
            if (dgvTripulacion.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una tripulacion para eliminar.");
                return;
            }

            int id_Tripulacion = Convert.ToInt32(dgvTripulacion.SelectedRows[0].Cells["id_Tripulacion"].Value);
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "DELETE FROM tripulacion WHERE id_tripulacion = @id";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id_Tripulacion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Tripulacion eliminada exitosamente.");
                }
            }
            CargarTripulacion(); // Actualizar el DataGridView después de eliminar
        }

        private void dgvTripulacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTripulacion.CurrentRow != null)
            {
                DataGridViewRow row = dgvTripulacion.Rows[e.RowIndex];
                txtNombreTripulacion.Text = dgvTripulacion.Rows[e.RowIndex].Cells["nombre_tripulacion"].Value.ToString();
            }
        }
    }
}
