using ADondeVamos.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    public partial class VentanaPartido : Form
    {
        DataTable dt;
        EventoDeportivoTorneo evento;
        Sistema sistema;
        Usuario usuario;
        public VentanaPartido(EventoDeportivoTorneo aux, Sistema aux3)
        {
            sistema = aux3;
            evento = aux;
            usuario = evento.Creador;
            InitializeComponent();
        }

        private void VentanaPartido_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Equipo 1", typeof(string)));
            dt.Columns.Add(new DataColumn("Equipo 2", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Final", typeof(string)));
            //Insertando datos al dt para mostrar en la lista
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fechainicio = inicioTime.Value;
            DateTime fechafin = finTime.Value;
            Partido partido = new Partido(equipo1.Text, equipo2.Text, fechainicio, fechafin);
            //evento.torneo.AgregarPartido(partido);
            dt.Rows.Add(partido.equipo1.Nombre, partido.equipo2.Nombre, partido.FechaInicio, partido.FechaFinal);
            VentanaEquipoJugadores f = new VentanaEquipoJugadores(evento, partido, sistema);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaTorneo f = new VentanaTorneo(evento, sistema);
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            evento.MostrarDatos();
            foreach (Usuario item in sistema.Usuarios)
            {
                if (item == usuario)
                {
                    item.AgregarEvento(evento);
                }
            }
            //Serialización
            sistema.Torneos.Add(evento);
            var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
            var formatter = new BinaryFormatter();
            formatter.Serialize(file, sistema);
            file.Close();

            Inicio f = new Inicio(usuario, sistema);
            f.Show();
            this.Hide();
        }
    }
}
