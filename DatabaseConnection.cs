using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SystemAirline___PROYECTO
{
    class DatabaseConnection
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "grupo3";
            string usuario = "root";
            string password = "root";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);

                return conexionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);

                return null;
            }
        }
    }

}

