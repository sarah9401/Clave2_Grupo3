using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemAirline___PROYECTO.Empleado
{
    public partial class Vuelo : Form
    {
        private MySqlConnection conexionDB;

        public Vuelo()
        {
            InitializeComponent();
            conexionDB = DatabaseConnection.conexion();
            CargarAviones();
            CargarHorarios();
            CargarRutas();
            CargarTripulacion();
            CargarVuelos();
        }

        private void Vuelos_Load(object sender, EventArgs e)
        {
            CargarVuelos();  // Cargar los datos de los vuelos
        }

        private void CargarAviones()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = "SELECT id_avion, nombre_avion FROM avion";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbAvion.DataSource = dt;
                cmbAvion.DisplayMember = "nombre_avion"; // Lo que se muestra en el ComboBox
                cmbAvion.ValueMember = "id_avion"; // Valor que se guarda internamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los aviones: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                    conexionDB.Close();
            }
        }

        private void CargarHorarios()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = "SELECT id_horario, CONCAT(fecha_vuelo, ' ', hora_salida) AS horario FROM horarios";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbHorario.DataSource = dt;
                cmbHorario.DisplayMember = "horario";   // Lo que se ve en el ComboBox
                cmbHorario.ValueMember = "id_horario"; // Lo que se usa internamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los horarios: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                    conexionDB.Close();
            }
        }

        private void CargarRutas()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = "SELECT id_ruta, CONCAT(origen, ' a ', destino, ' - ', hora_estimada) AS ruta_completa FROM rutas";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbRuta.DataSource = dt;
                cmbRuta.DisplayMember = "ruta_completa"; // Lo que se muestra en el ComboBox
                cmbRuta.ValueMember = "id_ruta"; // El valor que se guarda es el id_ruta
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las rutas: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                    conexionDB.Close();
            }
        }

        private void CargarTripulacion()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = "SELECT id_tripulacion, nombre_tripulacion FROM tripulacion";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbTripulacion.DataSource = dt;
                cmbTripulacion.DisplayMember = "nombre_tripulacion";
                cmbTripulacion.ValueMember = "id_tripulacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las tripulaciones: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                    conexionDB.Close();
            }
        }

        private void CargarVuelos()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = @"SELECT 
                            v.id_vuelo, 
                            v.numero_vuelo, 
                            a.nombre_avion, 
                            h.fecha_vuelo, 
                            h.hora_salida, 
                            h.hora_llegada, 
                            t.nombre_tripulacion, 
                            r.origen, 
                            r.destino
                         FROM vuelo v
                         JOIN avion a ON v.id_avion = a.id_avion
                         JOIN horarios h ON v.id_horario = h.id_horario
                         JOIN tripulacion t ON v.id_tripulacion = t.id_tripulacion
                         JOIN rutas r ON v.id_ruta = r.id_ruta";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvVuelos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vuelos: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                    conexionDB.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNumVuelo.Text) || cmbAvion.SelectedItem == null || cmbHorario.SelectedItem == null ||
                    cmbRuta.SelectedItem == null || cmbTripulacion.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string numVuelo = txtNumVuelo.Text;
                int idAvion = (int)((DataRowView)cmbAvion.SelectedItem)["id_avion"];
                int idHorario = (int)((DataRowView)cmbHorario.SelectedItem)["id_horario"];
                int idRuta = (int)((DataRowView)cmbRuta.SelectedItem)["id_ruta"];
                int idTripulacion = (int)((DataRowView)cmbTripulacion.SelectedItem)["id_tripulacion"];

                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string checkQuery = "SELECT COUNT(*) FROM vuelo WHERE id_horario = @idHorario";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conexionDB);
                checkCmd.Parameters.AddWithValue("@idHorario", idHorario);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un vuelo con este horario.");
                    return;
                }

                string query = "INSERT INTO vuelo (numero_vuelo, id_avion, id_horario, id_tripulacion, id_ruta) " +
                               "VALUES (@numVuelo, @idAvion, @idHorario, @idTripulacion, @idRuta)";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);

                cmd.Parameters.AddWithValue("@numVuelo", numVuelo);
                cmd.Parameters.AddWithValue("@idAvion", idAvion);
                cmd.Parameters.AddWithValue("@idHorario", idHorario);
                cmd.Parameters.AddWithValue("@idTripulacion", idTripulacion);
                cmd.Parameters.AddWithValue("@idRuta", idRuta);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Vuelo agregado correctamente.");

                CargarVuelos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el vuelo: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                    conexionDB.Close();
            }
        }
    }
}
