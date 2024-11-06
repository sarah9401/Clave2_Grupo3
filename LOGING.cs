using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;


namespace SystemAirline___PROYECTO
{
    public partial class LOGING : Form
    {
        MySqlConnection conexionDB = DatabaseConnection.conexion();

        public LOGING()
        {
            InitializeComponent();
        }

        // Método para encriptar la contraseña con bcrypt
        public string EncriptarContraseñaBcrypt(string contrasena)
        {
            return BCrypt.Net.BCrypt.HashPassword(contrasena);
        }

        public bool VerificarContraseña(string contraseñaIngresada, string contraseñaEncriptada)
        {
            // Verificar si la contraseña ingresada coincide con la encriptada
            return BCrypt.Net.BCrypt.Verify(contraseñaIngresada, contraseñaEncriptada);
        }

        private void btnInicioRegistro_Click(object sender, EventArgs e)
        {
            string correoRegistro = txtCorreoRegistro.Text.Trim();
            string contraRegistro = txtContraRegistro.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            DateTime fechaNacimiento;

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(correoRegistro) || string.IsNullOrEmpty(contraRegistro) ||
                string.IsNullOrEmpty(nombre) || !DateTime.TryParse(dtNacimiento.Text, out fechaNacimiento))
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.");
                return;
            }

            try
            {
                // Abrir la conexión a la base de datos
                conexionDB.Open();

                // Encriptar la contraseña con bcrypt
                string contraEncriptada = EncriptarContraseñaBcrypt(contraRegistro);

                // Crear la consulta SQL para insertar un nuevo usuario
                string query = "INSERT INTO usuario (nombre, fecha_nacimiento, correo, activo, contrasena, id_tipo_usuario) " +
                               "VALUES (@nombre, @fecha_nacimiento, @correo, @activo, @contrasena, @id_tipo_usuario)";

                // Crear el comando SQL
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);

                // Agregar los parámetros para evitar inyecciones SQL
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento.ToString("yyyy-MM-dd")); // Formato DATE
                cmd.Parameters.AddWithValue("@correo", correoRegistro);
                cmd.Parameters.AddWithValue("@activo", 1);  // Suponiendo que "activo" es 1 al registrarse
                cmd.Parameters.AddWithValue("@contrasena", contraEncriptada);  // Usar la contraseña encriptada
                cmd.Parameters.AddWithValue("@id_tipo_usuario", 1);  // id_tipo_usuario = 1

                // Ejecutar el comando para insertar el registro
                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Registro exitoso.");
                }
                else
                {
                    MessageBox.Show("Hubo un error al registrar el usuario.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexionDB.Close();
            }
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {   
            string correoInicioSesion = txtCorreoInicio.Text.Trim();
            string contraInicioSesion = txtContraInicio.Text.Trim();
            if (string.IsNullOrEmpty(correoInicioSesion) || string.IsNullOrEmpty(contraInicioSesion))
            {
                MessageBox.Show("Por favor ingresa tu correo y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Abrir la conexión a la base de datos
                conexionDB.Open();

                // Consulta para obtener el correo y la contraseña encriptada de la base de datos
                string query = "SELECT contrasena, id_tipo_usuario FROM usuario WHERE correo = @correo";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@correo", correoInicioSesion);

                // Ejecutar la consulta y leer el resultado
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string contraseñaEncriptada = reader["contrasena"].ToString();
                    int idTipoUsuario = Convert.ToInt32(reader["id_tipo_usuario"]);

                    // Verificar si la contraseña ingresada coincide con la encriptada
                    if (VerificarContraseña(contraInicioSesion, contraseñaEncriptada))
                    {
                        // Si la contraseña es correcta, redirigir a la pantalla correspondiente según el tipo de usuario
                        if (idTipoUsuario == 1) 
                        {
                            // Abrir la pantalla para el usuario
                            MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PantallaInicioUsuario pantallaInicio = new PantallaInicioUsuario();
                            pantallaInicio.Show();

                            this.Hide();
                        }
                        else
                        {
                            // Redirigir o hacer algo para otros tipos de usuarios
                            MessageBox.Show("Tipo de usuario no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Si la contraseña no es correcta, mostrar un mensaje de error
                        MessageBox.Show("La contraseña es incorrecta.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Si no se encuentra el correo en la base de datos
                    MessageBox.Show("Correo electrónico no registrado.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show("Error al conectarse con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                conexionDB.Close();
            }

    }
    }
}
