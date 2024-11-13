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

namespace SystemAirline___PROYECTO
{
    public partial class PantallaInicioEmpleado : Form
    {
        public PantallaInicioEmpleado()
        {
            InitializeComponent();
        }

        private void btnAerolineas_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            Aerolineas aerolineas = new Aerolineas();

            // Muestra el formulario como una ventana separada
            aerolineas.Show();
        }

        private void btnAsientos_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            Asientos asientos = new Asientos();

            // Muestra el formulario como una ventana separada
            asientos.Show();
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            Avion avion = new Avion();

            // Muestra el formulario como una ventana separada
            avion.Show();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            Horarios horarios = new Horarios();

            // Muestra el formulario como una ventana separada
            horarios.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            PersonalTripulacion personal = new PersonalTripulacion();

            // Muestra el formulario como una ventana separada
            personal.Show();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            Rutas rutas = new Rutas();

            // Muestra el formulario como una ventana separada
            rutas.Show();
        }

        private void btnRutasTarifas_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            RutaTarifa rutatarifa = new RutaTarifa();

            // Muestra el formulario como una ventana separada
            rutatarifa.Show();
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            Tarifaform tarifa = new Tarifaform();

            // Muestra el formulario como una ventana separada
            tarifa.Show();
        }

        private void btnTripulacion_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            Tripulacion tripulacion = new Tripulacion();

            // Muestra el formulario como una ventana separada
            tripulacion.Show();
        }

        private void btnVuelo_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario AerolineasForm
            Vuelo vuelo = new Vuelo();

            // Muestra el formulario como una ventana separada
            vuelo.Show();
        }
    }
}
