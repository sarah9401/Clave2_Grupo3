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
    public partial class Aerolineas : Form
    {
        private int aerolineaSeleccionadaId = -1; // ID de la aerolínea seleccionada
        MySqlConnection conexionDB = DatabaseConnection.conexion();
        public Aerolineas()
        {
            InitializeComponent();
            dgvAerolineas.CellClick += dgvAerolineas_CellClick;
            CargarAerolineas();
        }
   
         private void CargarAerolineas()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                
                string query = "SELECT * FROM aerolineas";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAerolineas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar aerolíneas: " + ex.Message);
            }
            finally
            {
                if(conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
                
            }
        }
        private void btnAgregarAerolinea_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombreAerolinea.Text.Trim();
            string paisOrigen = txtPaisOrigen.Text.Trim();

            if (nombre == "" || paisOrigen == "")
            {
                MessageBox.Show("Por favor ingrese todos los datos.");
                return;
            }

            try
            {
                conexionDB.Open();
                string query = "INSERT INTO aerolineas (nombre_aerolinea, pais_origen) VALUES (@nombre, @pais)";
                MySqlCommand aerolinea = new MySqlCommand(query, conexionDB);
                aerolinea.Parameters.AddWithValue("@nombre", nombre);
                aerolinea.Parameters.AddWithValue("@pais", paisOrigen);
                aerolinea.ExecuteNonQuery();
                MessageBox.Show("Aerolínea agregada exitosamente.");
                CargarAerolineas();
                LimpiarCampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar aerolínea: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }

        }

        private void btnModificarAerolinea_Click(object sender, EventArgs e)
        {
            if (aerolineaSeleccionadaId == -1)
            {
                MessageBox.Show("Seleccione una aerolínea para modificar.");
                return;
            }

            string nombre = txtNombreAerolinea.Text.Trim();
            string paisOrigen = txtPaisOrigen.Text.Trim();

            if (nombre == "" || paisOrigen == "")
            {
                MessageBox.Show("Por favor ingrese todos los datos.");
                return;
            }

            try
            {
                conexionDB.Open();
                string query = "UPDATE aerolineas SET nombre_aerolinea = @nombre, pais_origen = @pais WHERE id_aerolinea = @id";
                MySqlCommand aerolinea = new MySqlCommand(query, conexionDB);
                aerolinea.Parameters.AddWithValue("@nombre", nombre);
                aerolinea.Parameters.AddWithValue("@pais", paisOrigen);
                aerolinea.Parameters.AddWithValue("@id", aerolineaSeleccionadaId);
                aerolinea.ExecuteNonQuery();
                MessageBox.Show("Aerolínea modificada exitosamente.");
                CargarAerolineas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar aerolínea: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void btnEliminarAerolinea_Click(object sender, EventArgs e)
        {
            if (aerolineaSeleccionadaId == -1)
            {
                MessageBox.Show("Seleccione una aerolínea para eliminar.");
                return;
            }

            try
            {
                conexionDB.Open();
                string query = "DELETE FROM aerolineas WHERE id_aerolinea = @id";
                MySqlCommand aerolinea = new MySqlCommand(query, conexionDB);
                aerolinea.Parameters.AddWithValue("@id", aerolineaSeleccionadaId);
                aerolinea.ExecuteNonQuery();
                MessageBox.Show("Aerolínea eliminada exitosamente.");
                CargarAerolineas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar aerolínea: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void dgvAerolineas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                aerolineaSeleccionadaId = Convert.ToInt32(dgvAerolineas.Rows[e.RowIndex].Cells["id_aerolinea"].Value);
                txtIdAerolinea.Text = aerolineaSeleccionadaId.ToString();
                txtNombreAerolinea.Text = dgvAerolineas.Rows[e.RowIndex].Cells["nombre_aerolinea"].Value.ToString();
                txtPaisOrigen.Text = dgvAerolineas.Rows[e.RowIndex].Cells["pais_origen"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtIdAerolinea.Clear();
            txtNombreAerolinea.Clear();
            txtPaisOrigen.Clear();
            aerolineaSeleccionadaId = -1;
        }
    }
}
