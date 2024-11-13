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
    public partial class Tarifaform : Form
    {
        public Tarifaform()
        {
            InitializeComponent();
        }

        private void Tarifa_Load(object sender, EventArgs e)
        {
            CargarTarifa(); // Carga los datos en el DataGridView al iniciar el formulario
        }

        private void CargarTarifa()
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "SELECT id_tarifa, tarifa, descripcion FROM tarifa";
                using (var adapter = new MySqlDataAdapter(query, conexion))
                {
                    var dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvTarifa.DataSource = dataTable;
                }
            }
        }

        private void btnAgregarTarifa_Click(object sender, EventArgs e)
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                {
                    conexion.Open();
                    string query = "INSERT INTO tarifa (tarifa, descripcion) VALUES (@tarifa, @descripcion)";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@tarifa", txtTarifa.Text);
                        comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Tripulacion agregada exitosamente.");
                    }

                    CargarTarifa();
                }

            }
        }

        private void btnModificarTarifa_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya al menos una fila seleccionada
                if (dgvTarifa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una tarifa para modificar.");
                    return;
                }

                // Obtener el valor del ID de la tripulación de la fila seleccionada
                var selectedCellValue = dgvTarifa.SelectedRows[0].Cells["id_Tarifa"].Value;

                // Verificar que la celda contenga un valor válido
                if (selectedCellValue == null || string.IsNullOrEmpty(selectedCellValue.ToString()))
                {
                    MessageBox.Show("El ID de la tarifa no es válido.");
                    return;
                }

                // Intentar convertir el valor a entero
                int id_Tarifa;
                if (!int.TryParse(selectedCellValue.ToString(), out id_Tarifa))
                {
                    MessageBox.Show("El ID de la tarifa no es un número válido.");
                    return;
                }

                // Ejecutar la actualización en la base de datos
                using (var conexion = DatabaseConnection.conexion())
                {
                    conexion.Open();
                    string query = "UPDATE tarifa SET tarifa = @tarifa, descripcion = @descripcion WHERE id_tarifa = @id";

                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@tarifa", txtTarifa.Text);
                        comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        comando.Parameters.AddWithValue("@id", id_Tarifa);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Tarifa modificada exitosamente.");
                    }
                }
                // Actualizar el DataGridView después de modificar
                CargarTarifa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnEliminarTarifa_Click(object sender, EventArgs e)
        {
            if (dgvTarifa.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una tripulacion para eliminar.");
                return;
            }

            int id_Tarifa = Convert.ToInt32(dgvTarifa.SelectedRows[0].Cells["id_Tarifa"].Value);
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "DELETE FROM tarifa WHERE id_tarifa = @id";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id_Tarifa);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Tarifa eliminada exitosamente.");
                }
            }
            CargarTarifa(); // Actualizar el DataGridView después de eliminar
        }

        private void dgvTarifa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTarifa.CurrentRow != null)
            {
                DataGridViewRow row = dgvTarifa.Rows[e.RowIndex];
                txtTarifa.Text = dgvTarifa.Rows[e.RowIndex].Cells["tarifa"].Value.ToString();
                txtDescripcion.Text = dgvTarifa.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            }
        }
    }
}

