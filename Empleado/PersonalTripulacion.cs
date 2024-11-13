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
    public partial class PersonalTripulacion : Form
    {
        public PersonalTripulacion()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {

        }


        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            if (cmbTripulacion.SelectedItem is ComboBoxItem selectedTripulacion)
            {
                int idTripulacion = selectedTripulacion.Value;

                using (var conexion = DatabaseConnection.conexion())
                {
                    conexion.Open();
                    using (var transaction = conexion.BeginTransaction())
                    {
                        try
                        {
                            // 1. Inserta el nuevo personal en la tabla personal
                            string insertPersonalQuery = "INSERT INTO personal (nombre, cargo) VALUES (@nombre, @cargo)";
                            using (var insertPersonalCommand = new MySqlCommand(insertPersonalQuery, conexion, transaction))
                            {
                                insertPersonalCommand.Parameters.AddWithValue("@nombre", txtPersonal.Text);
                                insertPersonalCommand.Parameters.AddWithValue("@cargo", cmbCargo.SelectedItem.ToString());
                                insertPersonalCommand.ExecuteNonQuery();

                                // Recupera el ID del nuevo personal
                                int idPersonal = (int)insertPersonalCommand.LastInsertedId;

                                // 2. Inserta la relación en la tabla personal_tripulacion
                                string insertRelationQuery = "INSERT INTO personal_tripulacion (id_miembro_tripulacion, id_tripulacion) VALUES (@idPersonal, @idTripulacion)";
                                using (var insertRelationCommand = new MySqlCommand(insertRelationQuery, conexion, transaction))
                                {
                                    insertRelationCommand.Parameters.AddWithValue("@idPersonal", idPersonal);
                                    insertRelationCommand.Parameters.AddWithValue("@idTripulacion", idTripulacion);
                                    insertRelationCommand.ExecuteNonQuery();
                                }
                            }

                            // Confirmar transacción
                            transaction.Commit();
                            MessageBox.Show("Personal agregado exitosamente.");
                        }
                        catch (Exception ex)
                        {
                            // En caso de error, deshacer la transacción
                            transaction.Rollback();
                            MessageBox.Show("Error al agregar personal: " + ex.Message);
                        }
                    }
                }

                CargarPersonal(); // Actualizar el DataGridView después de agregar
            }
            else
            {
                MessageBox.Show("Seleccione una tripulación.");
            }
        }

        private void btnModificarPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya al menos una fila seleccionada
                if (dgvPersonal.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado para modificar.");
                    return;
                }

                // Obtener el valor del ID de la fila seleccionada
                var selectedCellValue = dgvPersonal.SelectedRows[0].Cells["id_personal"].Value;

                // Verificar que la celda contenga un valor válido
                if (selectedCellValue == null || string.IsNullOrEmpty(selectedCellValue.ToString()))
                {
                    MessageBox.Show("El ID del empleado no es válido.");
                    return;
                }

                // Convertir el valor a entero
                int id_Personal;
                if (!int.TryParse(selectedCellValue.ToString(), out id_Personal))
                {
                    MessageBox.Show("El ID del empleado no es un número válido.");
                    return;
                }

                // Ejecutar la actualización en la base de datos
                using (var conexion = DatabaseConnection.conexion())
                {
                    conexion.Open();
                    string query = "UPDATE personal SET nombre = @nombre, cargo = @cargo WHERE id_personal = @id";

                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", txtPersonal.Text);
                        comando.Parameters.AddWithValue("@cargo", cmbCargo.Text);
                        comando.Parameters.AddWithValue("@id", id_Personal);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Personal modificado exitosamente.");
                    }
                }
                // Actualizar el DataGridView después de modificar
                CargarPersonal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.SelectedRows.Count > 0)
            {
                int idPersonal = Convert.ToInt32(dgvPersonal.SelectedRows[0].Cells["id_personal"].Value);

                using (var conexion = DatabaseConnection.conexion())
                {
                    conexion.Open();
                    using (var transaction = conexion.BeginTransaction())
                    {
                        try
                        {
                            // 1. Eliminar las relaciones en la tabla personal_tripulacion
                            string deleteRelationQuery = "DELETE FROM personal_tripulacion WHERE id_miembro_tripulacion = @idPersonal";
                            using (var comandoRelacion = new MySqlCommand(deleteRelationQuery, conexion, transaction))
                            {
                                comandoRelacion.Parameters.AddWithValue("@idPersonal", idPersonal);
                                comandoRelacion.ExecuteNonQuery();
                            }

                            // 2. Eliminar el registro en la tabla personal
                            string deletePersonalQuery = "DELETE FROM personal WHERE id_personal = @idPersonal";
                            using (var comandoPersonal = new MySqlCommand(deletePersonalQuery, conexion, transaction))
                            {
                                comandoPersonal.Parameters.AddWithValue("@idPersonal", idPersonal);
                                comandoPersonal.ExecuteNonQuery();
                            }

                            // Confirmar transacción
                            transaction.Commit();
                            MessageBox.Show("Personal eliminado exitosamente.");
                        }
                        catch (Exception ex)
                        {
                            // En caso de error, deshacer la transacción
                            transaction.Rollback();
                            MessageBox.Show("Error al eliminar personal: " + ex.Message);
                        }
                    }
                }
                CargarPersonal(); // Actualizar el DataGridView después de eliminar
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }

        private void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonal.CurrentRow != null)
            {
                DataGridViewRow row = dgvPersonal.Rows[e.RowIndex];
                txtPersonal.Text = dgvPersonal.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                cmbCargo.Text = dgvPersonal.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            }
        }

        private void PersonalTripulacion_Load(object sender, EventArgs e)
        {
            CargarPersonal(); // Carga los datos en el DataGridView al iniciar el formulario
            LlenarComboTripulacion();
          

        }

        private void CargarPersonal()
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "SELECT p.id_personal, p.nombre, p.cargo, t.nombre_tripulacion " +
                               "FROM personal p " +
                               "INNER JOIN personal_tripulacion pt ON p.id_personal = pt.id_miembro_tripulacion " +
                               "INNER JOIN tripulacion t ON pt.id_tripulacion = t.id_tripulacion " +
                               "LIMIT 0, 1000";
                using (var adapter = new MySqlDataAdapter(query, conexion))
                {
                    var dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvPersonal.DataSource = dataTable;
                }
            }
        }

        private void LlenarComboTripulacion()
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "SELECT id_tripulacion, nombre_tripulacion FROM tripulacion";
                using (var comando = new MySqlCommand(query, conexion))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbTripulacion.Items.Add(new ComboBoxItem(
                            reader["nombre_tripulacion"].ToString(),
                            Convert.ToInt32(reader["id_tripulacion"])
                        ));
                    }
                }
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}

        

