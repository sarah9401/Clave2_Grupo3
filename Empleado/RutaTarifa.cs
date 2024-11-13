using MySql.Data.MySqlClient;
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

namespace SystemAirline___PROYECTO.Empleado
{
    public partial class RutaTarifa : Form
    {
        private int RegistroSeleccionadoId = -1; // ID del registro seleccionado
        MySqlConnection conexionDB = DatabaseConnection.conexion();
        public RutaTarifa()
        {
            InitializeComponent();
            dtRutaTarifa.CellClick += dtRutaTarifa_CellContentClick;
            CargarRutaTarifa();

        }
        private void CargarRutaTarifa()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }


                string query = "SELECT \r\n    rutas.origen AS Origen,\r\n    rutas.destino AS Destino,\r\n    tarifa.tarifa AS Tarifa\r\nFROM \r\n    ruta_tarifa\r\nINNER JOIN \r\n    rutas ON ruta_tarifa.id_ruta = rutas.id_ruta\r\nINNER JOIN \r\n    tarifa ON ruta_tarifa.id_tarifa = tarifa.id_tarifa;";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtRutaTarifa.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las tarifas de las rutas: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }

            }
        }

        private void dtRutaTarifa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el id_ruta_tarifa y asigna el valor en txtPrecio
                RegistroSeleccionadoId = Convert.ToInt32(dtRutaTarifa.Rows[e.RowIndex].Cells["id_ruta_tarifa"].Value);
                txtPrecio.Text = RegistroSeleccionadoId.ToString();

                // Obtiene el id_ruta de la fila seleccionada
                int idRuta = Convert.ToInt32(dtRutaTarifa.Rows[e.RowIndex].Cells["id_ruta"].Value);

                // Realiza una consulta a la tabla "rutas" para obtener origen y destino
                string query = "SELECT origen, destino FROM rutas WHERE id_ruta = @idRuta";

                using (SqlConnection connection = new SqlConnection("your_connection_string"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idRuta", idRuta);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Concatenar origen y destino y asignarlo al cmbRuta
                            string origen = reader["origen"].ToString();
                            string destino = reader["destino"].ToString();
                            cmbRuta.Text = $"{origen} - {destino}";
                        }
                    }
                }

                // Asigna el valor de tarifa al comboBox cmbTarifa
                if (dtRutaTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value != null)
                    cmbTarifa.Text = dtRutaTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
