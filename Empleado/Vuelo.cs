using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
           
           
            CargarRutas();
            CargarTripulaciones();
            CargarVuelos();
        }
       
       
        private void CargarRutas()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = "SELECT id_ruta, descripcion FROM rutas";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbRuta.DataSource = dt;
                cmbRuta.DisplayMember = "descripcion";
                cmbRuta.ValueMember = "id_ruta";
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
        private void CargarTripulaciones()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = "SELECT id_tripulacion, nombre FROM tripulacion";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbTripulacion.DataSource = dt;
                cmbTripulacion.DisplayMember = "nombre";
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

                string query = "SELECT v.id_vuelo, v.numero_vuelo, a.nombre_avion, h.descripcion AS horario, t.nombre AS tripulacion, r.descripcion AS ruta " +
                               "FROM vuelo v " +
                               "JOIN avion a ON v.id_avion = a.id_avion " +
                               "JOIN horarios h ON v.id_horario = h.id_horario " +
                               "JOIN tripulacion t ON v.id_tripulacion = t.id_tripulacion " +
                               "JOIN rutas r ON v.id_ruta = r.id_ruta";

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
                if (string.IsNullOrEmpty(txtNumVuelo.Text) || cmbAvion.SelectedItem == null ||
                    cmbHorario.SelectedItem == null || cmbRuta.SelectedItem == null || cmbTripulacion.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string numeroVuelo = txtNumVuelo.Text;
                int idAvion = (int)cmbAvion.SelectedValue;
                int idHorario = (int)cmbHorario.SelectedValue;
                int idRuta = (int)cmbRuta.SelectedValue;
                int idTripulacion = (int)cmbTripulacion.SelectedValue;

                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = "INSERT INTO vuelo (numero_vuelo, id_avion, id_horario, id_ruta, id_tripulacion) " +
                               "VALUES (@numeroVuelo, @idAvion, @idHorario, @idRuta, @idTripulacion)";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@numeroVuelo", numeroVuelo);
                cmd.Parameters.AddWithValue("@idAvion", idAvion);
                cmd.Parameters.AddWithValue("@idHorario", idHorario);
                cmd.Parameters.AddWithValue("@idRuta", idRuta);
                cmd.Parameters.AddWithValue("@idTripulacion", idTripulacion);

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

        private void Vuelo_Load(object sender, EventArgs e)
        {
            LlenarComboAviones();
            LlenarComboHorarios();
           

        }
        
            private void LlenarComboAviones()
            {
                using (var conexion = DatabaseConnection.conexion())
                {
                    conexion.Open();
                    string query = "SELECT id_avion, nombre_avion FROM avion";
                    using (var comando = new MySqlCommand(query, conexion))
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbAvion.Items.Add(new ComboBoxAvion(
                                reader["nombre_avion"].ToString(),
                                Convert.ToInt32(reader["id_avion"])
                            ));
                        }
                    }
                }
            }
        private void LlenarComboHorarios()
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "SELECT id_horario, fecha_vuelo, hora_salida, hora_llegada FROM horarios";
                using (var comando = new MySqlCommand(query, conexion))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbHorario.Items.Add(new ComboBoxHorarios(
                            reader["fecha_vuelo"].ToString(),
                            Convert.ToInt32(reader["id_horario"])
                        ));
                    }
                }
            }
        }

        public class ComboBoxAvion
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxAvion(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public class ComboBoxHorarios
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxHorarios(string text, int value)
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

