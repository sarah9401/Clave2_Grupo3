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
using System.Text.RegularExpressions;
namespace SystemAirline___PROYECTO.Empleado
{
    public partial class Rutas : Form
    {
        public Rutas()
        {
            InitializeComponent();
        }

        private void Rutas_Load(object sender, EventArgs e)
        { 
           CargarRutas(); // Carga los datos en el DataGridView al iniciar el formulario
        }

        private void CargarRutas()
        {
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "SELECT id_ruta, origen, destino, hora_estimada FROM rutas";
                using (var adapter = new MySqlDataAdapter(query, conexion))
                {
                    var dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvRutas.DataSource = dataTable;
                }
            }
        }

        // Validar formato de hora estimada (HH:MM)
        private bool EsHoraEstimadaValida(string horaEstimada)
        {
            return Regex.IsMatch(horaEstimada, @"^\d{1,2}:\d{2}$");
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            if (!EsHoraEstimadaValida(txtHoraEstimada.Text))
            {
                MessageBox.Show("Ingrese la hora estimada en el formato HH:MM.");
                return;
            }
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "INSERT INTO rutas (origen, destino, hora_estimada) VALUES (@origen, @destino, @hora_estimada)";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@origen", txtOrigen.Text);
                    comando.Parameters.AddWithValue("@destino", txtDestino.Text);
                    comando.Parameters.AddWithValue("@hora_estimada", txtHoraEstimada.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ruta agregada exitosamente.");
                }
            }
            CargarRutas(); // Actualizar el DataGridView después de agregar
        }

        private void btnModificarRuta_Click(object sender, EventArgs e)
        {
            if (dgvRutas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una ruta para modificar.");
                return;
            }
            if (!EsHoraEstimadaValida(txtHoraEstimada.Text))
            {
                MessageBox.Show("Ingrese la hora estimada en el formato HH:MM.");
                return;
            }
            int idRuta = Convert.ToInt32(dgvRutas.CurrentRow.Cells["id_ruta"].Value);
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "UPDATE rutas SET origen = @origen, destino = @destino, hora_estimada = @hora_estimada WHERE id_ruta = @id";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idRuta);
                    comando.Parameters.AddWithValue("@origen", txtOrigen.Text);
                    comando.Parameters.AddWithValue("@destino", txtDestino.Text);
                    comando.Parameters.AddWithValue("@hora_estimada", txtHoraEstimada.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ruta modificada exitosamente.");
                }
            }
            CargarRutas(); // Actualizar el DataGridView después de modificar
        }

        private void btnEliminarRuta_Click(object sender, EventArgs e)
        {
            if (dgvRutas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una ruta para eliminar.");
                return;
            }
            int idRuta = Convert.ToInt32(dgvRutas.CurrentRow.Cells["id_ruta"].Value);
            using (var conexion = DatabaseConnection.conexion())
            {
                conexion.Open();
                string query = "DELETE FROM rutas WHERE id_ruta = @id";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idRuta);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ruta eliminada exitosamente.");
                }
            }
            CargarRutas(); // Actualizar el DataGridView después de eliminar
        }

        private void dgvRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRutas.CurrentRow != null)
            {
                txtOrigen.Text = dgvRutas.CurrentRow.Cells["origen"].Value.ToString();
                txtDestino.Text = dgvRutas.CurrentRow.Cells["destino"].Value.ToString();
                txtHoraEstimada.Text = dgvRutas.CurrentRow.Cells["hora_estimada"].Value.ToString();
            }
        }
    }
}


