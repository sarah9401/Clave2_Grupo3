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
    public partial class Avion : Form
    {
        private MySqlConnection conexionDB;

        public Avion()
        {
            InitializeComponent();
            conexionDB = DatabaseConnection.conexion();
            CargarAerolineas();  // Cargar las aerolíneas
            CargarAviones(); //Cargar los aviones

        }

        private void Avion_Load(object sender, EventArgs e)
        {

        }

        private void CargarAerolineas()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                string query = "SELECT id_aerolinea, nombre_aerolinea FROM aerolineas";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Asignar los datos al ComboBox
                cmbAerolinea.DataSource = dt;
                cmbAerolinea.DisplayMember = "nombre_aerolinea";  // Lo que se muestra en el ComboBox
                cmbAerolinea.ValueMember = "id_aerolinea";       // El valor que se usa internamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las aerolíneas: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                    conexionDB.Close();
            }
        }

        private void CargarAviones()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                // Modificado para usar los nombres de columnas correctos
                string query = "SELECT avion.id_avion, avion.nombre_avion, avion.capacidad_avion, aerolineas.nombre_aerolinea " +
                               "FROM avion " +
                               "INNER JOIN aerolineas ON avion.id_aerolineas = aerolineas.id_aerolinea";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Asignar el DataTable al DataGridView
                dgvAviones.DataSource = dt;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtModelo.Text) || numCapacidad.Value == 0 || cmbAerolinea.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                // Obtén los datos desde los controles
                string modelo = txtModelo.Text;
                int capacidad = (int)numCapacidad.Value;
                int idAerolinea = (int)((DataRowView)cmbAerolinea.SelectedItem)["id_aerolinea"];

                // Abre la conexión
                if (conexionDB.State == ConnectionState.Closed)
                    conexionDB.Open();

                // Consulta SQL para insertar un nuevo avión
                string query = "INSERT INTO avion (nombre_avion, capacidad_avion, id_aerolineas) VALUES (@modelo, @capacidad, @idAerolinea)";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);

                // Agregar los parámetros a la consulta
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@capacidad", capacidad);
                cmd.Parameters.AddWithValue("@idAerolinea", idAerolinea);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();

                // Mostrar mensaje de éxito
                MessageBox.Show("Avión agregado correctamente.");

                // Recargar los aviones en el DataGridView
                CargarAviones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el avión: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                    conexionDB.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void dgvAviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}


