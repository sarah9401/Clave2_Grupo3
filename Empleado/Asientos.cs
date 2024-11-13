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

namespace SystemAirline___PROYECTO
{
    public partial class Asientos : Form
    {
        private int RegistroSeleccionadoId = -1; // ID del registro seleccionado
        MySqlConnection conexionDB = DatabaseConnection.conexion();
        public Asientos()
        {
            InitializeComponent();
        }

        private void ObtenerSiguienteIdDisponible()
        {
            try
            {
                if (conexionDB.State == ConnectionState.Closed)
                {
                    conexionDB.Open();
                }

                // Consulta para obtener el máximo id_asiento actual
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
