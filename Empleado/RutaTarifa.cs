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
    using MySql.Data.MySqlClient;
    using Mysqlx.Crud;
    using System;
    using System.Data;
    using System.Windows.Forms;

    

    public partial class RutaTarifa : Form
    {

        private int RegistroSeleccionadoId = -1; // ID del registro seleccionado
        MySqlConnection conexionDB = DatabaseConnection.conexion();

        public RutaTarifa()
        {
            InitializeComponent();
            dtRutaTarifa.CellClick += dtRutaTarifa_CellContentClick;
            dtRutaTarifa.DefaultCellStyle.Font = new Font("Arial", 10);
            CargarRutaTarifa();
            CargarRutas();
            CargarTarifas();
            ObtenerSiguienteIdDisponible();

        }

        private void ObtenerSiguienteIdDisponible()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                // Consulta para obtener el máximo id_ruta_tarifa actual
                string query = "SELECT IFNULL(MAX(id_ruta_tarifa), 0) + 1 AS SiguienteId FROM ruta_tarifa";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);

                // Ejecutar la consulta y asignar el resultado a txtid
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


        // Funciones para cargar la informacion 

        private void CargarRutaTarifa()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                // Consulta para obtener las rutas y tarifas con el formato deseado
                string query = @"SELECT 
                                ruta_tarifa.id_ruta_tarifa AS id,
                                CONCAT(rutas.origen, ' - ', rutas.destino) AS Ruta,
                                tarifa.tarifa AS Tarifa
                             FROM 
                                ruta_tarifa
                             INNER JOIN 
                                rutas ON ruta_tarifa.id_ruta = rutas.id_ruta
                             INNER JOIN 
                                tarifa ON ruta_tarifa.id_tarifa = tarifa.id_tarifa;";

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

        private void CargarRutas()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                string cargarRutas = "SELECT id_ruta, origen, destino FROM rutas";
                MySqlCommand cmd = new MySqlCommand(cargarRutas, conexionDB);
                MySqlDataReader rdr = cmd.ExecuteReader();
                cmbRuta.Items.Clear();

                while (rdr.Read())
                {
                    int idRuta = Convert.ToInt32(rdr["id_ruta"]);
                    string rutaDisplay = $"{rdr["origen"]} - {rdr["destino"]}";
                    cmbRuta.Items.Add(new Ruta(idRuta, rutaDisplay));
                }

                rdr.Close();
                if (cmbRuta.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron rutas disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las rutas: " + ex.Message);
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



        // funcion encargada de mostrar de dataGridView a los componentes

        private void dtRutaTarifa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén el id_ruta_tarifa y muestra el valor en txtPrecio
                RegistroSeleccionadoId = Convert.ToInt32(dtRutaTarifa.Rows[e.RowIndex].Cells["id"].Value);
                txtid.Text = RegistroSeleccionadoId.ToString();

                // Establece la ruta seleccionada en cmbRuta
                cmbRuta.Text = dtRutaTarifa.Rows[e.RowIndex].Cells["Ruta"].Value.ToString();

                // Establece la tarifa seleccionada en cmbTarifa
                cmbTarifa.Text = dtRutaTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Verificar que el usuario haya seleccionado una ruta y una tarifa
            if (cmbRuta.SelectedItem is Ruta selectedRuta && cmbTarifa.SelectedItem is Tarifa selectedTarifa)
            {
                int idRuta = selectedRuta.IdRuta;
                int idTarifa = selectedTarifa.IdTarifa;

                try
                {
                    if (conexionDB.State == ConnectionState.Closed)
                    {
                        conexionDB.Open();
                    }

                    string insertQuery = "INSERT INTO ruta_tarifa (id_ruta, id_tarifa) VALUES (@idRuta, @idTarifa)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conexionDB);
                    cmd.Parameters.AddWithValue("@idRuta", idRuta);
                    cmd.Parameters.AddWithValue("@idTarifa", idTarifa);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ruta y tarifa agregadas correctamente.");
                        CargarRutaTarifa(); // Recargar la tabla para mostrar los cambios
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la ruta y tarifa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la ruta y tarifa: " + ex.Message);
                }
                finally
                {
                    if (conexionDB.State == ConnectionState.Open)
                    {
                        conexionDB.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una ruta y una tarifa.");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un registro y que el usuario haya seleccionado una ruta y una tarifa
            if (RegistroSeleccionadoId != -1 && cmbRuta.SelectedItem is Ruta selectedRuta && cmbTarifa.SelectedItem is Tarifa selectedTarifa)
            {
                int idRuta = selectedRuta.IdRuta;
                int idTarifa = selectedTarifa.IdTarifa;

                try
                {
                    if (conexionDB.State == ConnectionState.Closed)
                    {
                        conexionDB.Open();
                    }

                    // Actualizar el registro en la tabla ruta_tarifa
                    string updateQuery = "UPDATE ruta_tarifa SET id_ruta = @idRuta, id_tarifa = @idTarifa WHERE id_ruta_tarifa = @idRutaTarifa";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conexionDB);
                    cmd.Parameters.AddWithValue("@idRuta", idRuta);
                    cmd.Parameters.AddWithValue("@idTarifa", idTarifa);
                    cmd.Parameters.AddWithValue("@idRutaTarifa", RegistroSeleccionadoId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro modificado correctamente.");
                        CargarRutaTarifa(); // Recargar la tabla para mostrar los cambios
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el registro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el registro: " + ex.Message);
                }
                finally
                {
                    if (conexionDB.State == ConnectionState.Open)
                    {
                        conexionDB.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro y elige una ruta y una tarifa.");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un registro
            if (RegistroSeleccionadoId != -1)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (conexionDB.State == ConnectionState.Closed)
                        {
                            conexionDB.Open();
                        }

                        // Eliminar el registro de la tabla ruta_tarifa
                        string deleteQuery = "DELETE FROM ruta_tarifa WHERE id_ruta_tarifa = @idRutaTarifa";
                        MySqlCommand cmd = new MySqlCommand(deleteQuery, conexionDB);
                        cmd.Parameters.AddWithValue("@idRutaTarifa", RegistroSeleccionadoId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.");
                            CargarRutaTarifa(); // Recargar la tabla para mostrar los cambios
                            RegistroSeleccionadoId = -1; // Reiniciar el id del registro seleccionado
                            txtid.Clear();
                            cmbRuta.SelectedIndex = -1;
                            cmbTarifa.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el registro.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    }
                    finally
                    {
                        if (conexionDB.State == ConnectionState.Open)
                        {
                            conexionDB.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void RutaTarifa_Load(object sender, EventArgs e)
        {

        }
    }

    public class Ruta
    {
        public int IdRuta { get; set; }
        public string RutaDisplay { get; set; }

        public Ruta(int idRuta, string rutaDisplay)
        {
            IdRuta = idRuta;
            RutaDisplay = rutaDisplay;
        }

        public override string ToString()
        {
            return RutaDisplay;
        }
    }

    public class Tarifa
    {
        public int IdTarifa { get; set; }
        public string TarifaDisplay { get; set; }

        public Tarifa(int idTarifa, string tarifaDisplay)
        {
            IdTarifa = idTarifa;
            TarifaDisplay = tarifaDisplay;
        }

        public override string ToString()
        {
            return TarifaDisplay;
        }
    }
}
