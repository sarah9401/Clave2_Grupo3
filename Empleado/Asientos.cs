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
using SystemAirline___PROYECTO.Empleado;
using static SystemAirline___PROYECTO.Asientos;

namespace SystemAirline___PROYECTO
{
    public partial class Asientos : Form
    {
        private int RegistroSeleccionadoId = -1; // ID del registro seleccionado
        MySqlConnection conexionDB = DatabaseConnection.conexion();

        public Asientos()
        {
            InitializeComponent();
            dtAsientos.CellClick += dtAsientos_CellContentClick;
            ObtenerSiguienteIdDisponible();
            CargarTablaAsientos();
            CargarVuelo();
            CargarTarifas();
        }

        private void ObtenerSiguienteIdDisponible()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                string query = "SELECT IFNULL(MAX(id_asiento), 0) + 1 AS SiguienteId FROM asientos";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);

                object result = cmd.ExecuteScalar();
                txtid.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID disponible: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }
        }

        private void CargarTablaAsientos()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                string query = @"SELECT 
                    a.id_asiento AS id,
                    a.numero_asiento AS asiento,
                    v.numero_vuelo AS NumeroVuelo,
                    t.tarifa AS Tarifa
                FROM 
                    grupo3.asientos a
                INNER JOIN
                    grupo3.vuelo v ON a.id_vuelo = v.id_vuelo
                INNER JOIN
                    grupo3.tarifa t ON a.id_tarifa = t.id_tarifa;;";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtAsientos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de los asientos: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }
        }

        private void CargarVuelo()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                string cargarVuelos = "SELECT id_vuelo, numero_vuelo FROM vuelo";
                MySqlCommand cmd = new MySqlCommand(cargarVuelos, conexionDB);
                MySqlDataReader rdr = cmd.ExecuteReader();
                cmbVuelo.Items.Clear();

                while (rdr.Read())
                {
                    int idVuelo = Convert.ToInt32(rdr["id_vuelo"]);
                    string Vuelo = $"{rdr["numero_vuelo"]}";
                    cmbVuelo.Items.Add(new Vuelo(idVuelo, Vuelo));
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vuelos: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }
        }

        private void CargarTarifas()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                string cargarTarifas = "SELECT id_tarifa, tarifa FROM tarifa";
                MySqlCommand cmd = new MySqlCommand(cargarTarifas, conexionDB);
                MySqlDataReader rdr = cmd.ExecuteReader();
                cmbTarifa.Items.Clear();

                while (rdr.Read())
                {
                    int idTarifa = Convert.ToInt32(rdr["id_tarifa"]);
                    string tarifaDisplay = rdr["tarifa"].ToString();
                    cmbTarifa.Items.Add(new Tarifa(idTarifa, tarifaDisplay));
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las tarifas: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }
        }

        // Evento cuando se hace clic en la celda
        private void dtAsientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RegistroSeleccionadoId = Convert.ToInt32(dtAsientos.Rows[e.RowIndex].Cells["id"].Value);
                txtid.Text = RegistroSeleccionadoId.ToString();
                txtAsiento.Text = dtAsientos.Rows[e.RowIndex].Cells["asiento"].Value.ToString(); // Asignar el número de asiento a txtAsiento
                cmbVuelo.Text = dtAsientos.Rows[e.RowIndex].Cells["NumeroVuelo"].Value.ToString();
                cmbTarifa.Text = dtAsientos.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString();
            }
        }

        // Función para agregar asiento
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                // Verifica si el asiento ya existe
                string checkQuery = "SELECT COUNT(*) FROM asientos WHERE numero_asiento = @numeroAsiento";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conexionDB);
                checkCmd.Parameters.AddWithValue("@numeroAsiento", txtAsiento.Text);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("El asiento con este número ya existe.");
                    return;
                }

                // Inserta el nuevo asiento
                string insertQuery = @"INSERT INTO asientos (numero_asiento, id_vuelo, id_tarifa,reservado) 
                               VALUES (@numeroAsiento, @idVuelo, @idTarifa,@reservado)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conexionDB);
                insertCmd.Parameters.AddWithValue("@numeroAsiento", txtAsiento.Text); // Número del asiento
                insertCmd.Parameters.AddWithValue("@idVuelo", ((Vuelo)cmbVuelo.SelectedItem).idVuelo); // ID del vuelo seleccionado
                insertCmd.Parameters.AddWithValue("@idTarifa", ((Tarifa)cmbTarifa.SelectedItem).IdTarifa); // ID de tarifa seleccionado
                insertCmd.Parameters.AddWithValue("@reservado", 0);
                insertCmd.ExecuteNonQuery();  // Ejecuta la inserción

                MessageBox.Show("Asiento agregado correctamente.");
                CargarTablaAsientos(); // Recarga la tabla de asientos para mostrar el nuevo asiento
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el asiento: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }
        }


        // Función para modificar asiento
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (RegistroSeleccionadoId == -1)
            {
                MessageBox.Show("Por favor, seleccione un asiento para modificar.");
                return;
            }

            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                // Obtener el número de asiento a modificar
                string numeroAsiento = txtAsiento.Text;

                // Verificar si el número de asiento ya está registrado en otro asiento (excluyendo el actual)
                string checkQuery = "SELECT COUNT(*) FROM asientos WHERE numero_asiento = @numeroAsiento AND id_asiento != @idAsiento";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conexionDB);
                checkCmd.Parameters.AddWithValue("@numeroAsiento", numeroAsiento);
                checkCmd.Parameters.AddWithValue("@idAsiento", RegistroSeleccionadoId);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("El número de asiento ya está registrado. No se puede modificar.");
                    return;
                }

                // Obtener el idVuelo y idTarifa desde los ComboBoxes
                int idVueloSeleccionado = ((Vuelo)cmbVuelo.SelectedItem).idVuelo;
                int idTarifaSeleccionada = ((Tarifa)cmbTarifa.SelectedItem).IdTarifa;

                string updateQuery = @"UPDATE asientos SET 
                            numero_asiento = @numeroAsiento, 
                            id_vuelo = @idVuelo, 
                            id_tarifa = @idTarifa 
                            WHERE id_asiento = @idAsiento";

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conexionDB);
                updateCmd.Parameters.AddWithValue("@numeroAsiento", numeroAsiento); // Asumiendo que txtAsiento contiene el número del asiento
                updateCmd.Parameters.AddWithValue("@idVuelo", idVueloSeleccionado);
                updateCmd.Parameters.AddWithValue("@idTarifa", idTarifaSeleccionada);
                updateCmd.Parameters.AddWithValue("@idAsiento", RegistroSeleccionadoId); // ID del asiento a modificar
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Asiento modificado correctamente.");
                CargarTablaAsientos(); // Recarga la tabla de asientos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el asiento: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }
        }




        // Función para eliminar asiento
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (RegistroSeleccionadoId == -1)
            {
                MessageBox.Show("Por favor, seleccione un asiento para eliminar.");
                return;
            }

            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                string deleteQuery = "DELETE FROM asientos WHERE id_asiento = @idAsiento";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conexionDB);
                deleteCmd.Parameters.AddWithValue("@idAsiento", RegistroSeleccionadoId);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Asiento eliminado correctamente.");
                CargarTablaAsientos(); // Recarga la tabla de asientos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el asiento: " + ex.Message);
            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }
        }
       
        
        
        public class Vuelo
        {
            public int idVuelo { get; set; }
            public string vueloDisplay { get; set; }

            // Constructor corregido
            public Vuelo(int idVuelo, string vueloDisplay)
            {
                this.idVuelo = idVuelo;  // Asigna correctamente a la propiedad de la clase
                this.vueloDisplay = vueloDisplay; // Asigna correctamente a la propiedad de la clase
            }

            public override string ToString()
            {
                return vueloDisplay;
            }
        }


        public class Tarifa
        {
            public int IdTarifa { get; set; }
            public string TarifaDisplay { get; set; }

            // Constructor corregido
            public Tarifa(int idTarifa, string tarifaDisplay)
            {
                this.IdTarifa = idTarifa; // Asigna correctamente a la propiedad de la clase
                this.TarifaDisplay = tarifaDisplay; // Asigna correctamente a la propiedad de la clase
            }

            public override string ToString()
            {
                return TarifaDisplay;
            }
        }

    }

}
