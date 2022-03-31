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

            int anno = DateTime.Now.Year; int dia = DateTime.Now.Day; int mes = DateTime.Now.Month;
            int hora = DateTime.Now.Hour; int minu = DateTime.Now.Minute;
            inicioTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
            finTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
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

        public bool ValidarDatos(string equi1, string equi2, DateTime inicio, DateTime final)
        {
            bool bande = false;
            string mensaje = "";
            if(equi1!="")
            {
                if (equi2!="")
                {
                    if (DateTime.Compare(inicio, evento.FechaFin) < 0 && DateTime.Compare(inicio, evento.Fecha) >= 0)
                    {
                        if(DateTime.Compare(evento.Fecha, final)<0 && DateTime.Compare(final, evento.FechaFin)<=0)
                        {
                            bande = true;
                        }
                    }
                }
            }
            else
            {
                mensaje += "Debe ingresar un nombre para Equipo 1\n";
            }
            if(equi2=="")
            {
                mensaje += "Debe ingresar un nombre para Equipo 2\n";
            }
            if (DateTime.Compare(inicio, evento.FechaFin) >= 0 || DateTime.Compare(inicio, evento.Fecha) < 0)
            {
                mensaje += "La fecha de inicio del Partido debe ser menor a la fecha final del Torneo\n";
                mensaje += "Y la fecha de inicio del Partido debe ser mayor o igual a la fecha de inicio del Torneo\n";
            }
            if (DateTime.Compare(evento.Fecha, final) >= 0 || DateTime.Compare(final, evento.FechaFin) > 0)
            {
                mensaje += "La fecha final del Partido debe ser mayor a la fecha de inicio del Torneo\n";
                mensaje += "Y la fecha final del Partido debe ser menor o igual a la fecha final del Torneo\n";
            }
            if (bande == false)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fechainicio = inicioTime.Value;
            DateTime fechafin = finTime.Value;
            if (ValidarDatos(equipo1.Text, equipo2.Text, fechainicio, fechafin) == true)
            {
                Partido partido = new Partido(equipo1.Text, equipo2.Text, fechainicio, fechafin);
                //evento.torneo.AgregarPartido(partido);
                dt.Rows.Add(partido.Equipo1.Nombre, partido.Equipo2.Nombre, partido.FechaInicio, partido.FechaFinal);
                equipo1.Text = ""; equipo2.Text = "";
                VentanaEquipoJugadores f = new VentanaEquipoJugadores(evento, partido, sistema);
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaTorneo f = new VentanaTorneo(evento, sistema);
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (evento.torneo.Partidos.Any()==true)
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
            else
            {
                MessageBox.Show("Debe crear al menos un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
