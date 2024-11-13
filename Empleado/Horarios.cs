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

        // Método que se ejecuta cuando se carga el formulario
        private void Horarios_Load(object sender, EventArgs e)
        {
            CargarHorarios(); // Carga los datos en el DataGridView al iniciar el formulario
        }

        // Método para cargar los datos de la tabla 'rutas' en el DataGridView
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

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                {
                    conexion.Open();
                    string query = "INSERT INTO horarios (fecha_vuelo, hora_salida, hora_llegada) VALUES (@fecha_vuelo, @hora_salida, @hora_llegada)";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@FechaVuelo", dtpFechaVuelo.Value);
                        comando.Parameters.AddWithValue("@HoraSalida", dtpHoraSalida.Value.TimeOfDay);
                        comando.Parameters.AddWithValue("@HoraLlegada", dtpHoraLlegada.Value.TimeOfDay);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Ruta agregada exitosamente.");
                    }

                    CargarHorarios();
                }

            }
        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            if (dataGridViewHorarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un horario para modificar.");
                return;
            }

            int id_Horario = Convert.ToInt32(dataGridViewHorarios.SelectedRows[0].Cells["id_Horario"].Value);

            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "UPDATE horarios SET fecha_vuelo = @fecha_vuelo, hora_salida = @hora_salida, hora_llegada = @hora_llegada WHERE id_horario = @id";
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

        private void btnEliminarHorario_Click(object sender, EventArgs e)
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
                string query = "DELETE FROM rutas WHERE id_ruta = @id";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id_Horario);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ruta eliminada exitosamente.");
                }
            }
            CargarHorarios(); // Actualizar el DataGridView después de eliminar
        }

        private void dataGridViewHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


        
    
