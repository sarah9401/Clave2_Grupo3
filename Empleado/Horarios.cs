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
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            CargarHorarios(); // Carga los datos en el DataGridView al iniciar el formulario

            // Configuración de los DateTimePickers para Hora de Salida y Hora de Llegada

            // Configurar HoraSalida
            dtpHoraSalida.Format = DateTimePickerFormat.Custom;
            dtpHoraSalida.CustomFormat = "HH:mm"; // Solo muestra la hora y los minutos

            // Configurar HoraLlegada
            dtpHoraLlegada.Format = DateTimePickerFormat.Custom;
            dtpHoraLlegada.CustomFormat = "HH:mm"; // Solo muestra la hora y los minutos


           
        }

        private void CargarHorarios()
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "SELECT id_horario, fecha_vuelo, hora_salida, hora_llegada FROM horarios";
                using (var adapter = new MySqlDataAdapter(query, conexion))
                {
                    var dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewHorarios.DataSource = dataTable;
                }
            }
        }

        private void btnAgregarHorario_Click_1(object sender, EventArgs e)
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();

                string query = "INSERT INTO horarios (fecha_vuelo, hora_salida, hora_llegada) VALUES (@fecha_vuelo, @hora_salida, @hora_llegada)";

                using (var comando = new MySqlCommand(query, conexion))
                {
                    // Asegúrate de añadir el parámetro para la fecha del vuelo correctamente
                    comando.Parameters.AddWithValue("@fecha_vuelo", dtpFechaVuelo.Value.Date);  // Usar solo la fecha, sin hora

                    // Añadir los parámetros para hora de salida y llegada
                    comando.Parameters.AddWithValue("@hora_salida", dtpHoraSalida.Value.ToString("HH:mm:ss"));
                    comando.Parameters.AddWithValue("@hora_llegada", dtpHoraLlegada.Value.ToString("HH:mm:ss"));

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ruta agregada exitosamente.");
                }

                // Llamar a la función para recargar los horarios (si es necesario)
                CargarHorarios();
            }
        }

        private void btnModificarHorario_Click_1(object sender, EventArgs e)
        {
            int id_Horario; // Declarar la variable fuera del bloque if

            if (dataGridViewHorarios.SelectedRows.Count > 0)
            {
                id_Horario = Convert.ToInt32(dataGridViewHorarios.SelectedRows[0].Cells["id_Horario"].Value);
            }
            else
            {
                MessageBox.Show("Seleccione un horario para modificar.");
                return;
            }

            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "UPDATE horarios SET fecha_vuelo = @FechaVuelo, hora_salida = @HoraSalida, hora_llegada = @HoraLlegada WHERE id_horario = @Id";

                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@FechaVuelo", dtpFechaVuelo.Value);
                    comando.Parameters.AddWithValue("@HoraSalida", dtpHoraSalida.Value.TimeOfDay);
                    comando.Parameters.AddWithValue("@HoraLlegada", dtpHoraLlegada.Value.TimeOfDay);
                    comando.Parameters.AddWithValue("@Id", id_Horario);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ruta modificada exitosamente.");
                }
            }

            CargarHorarios(); // Actualizar el DataGridView después de modificar
        }

        private void btnEliminarHorario_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewHorarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un horario para eliminar.");
                return;
            }
            int id_Horario = Convert.ToInt32(dataGridViewHorarios.SelectedRows[0].Cells["id_Horario"].Value);
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "DELETE FROM horarios WHERE id_horario = @id";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id_Horario);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Horario eliminado exitosamente.");
                }
            }
            CargarHorarios(); // Actualizar el DataGridView después de eliminar
        }

        private void dataGridViewHorarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHorarios.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewHorarios.Rows[e.RowIndex];
                dtpFechaVuelo.Value = Convert.ToDateTime(row.Cells["fecha_vuelo"].Value);
                dtpHoraSalida.Value = DateTime.Today.Add((TimeSpan)row.Cells["hora_salida"].Value);
                dtpHoraLlegada.Value = DateTime.Today.Add((TimeSpan)row.Cells["hora_llegada"].Value);
            }
        }
    }
    }

    

