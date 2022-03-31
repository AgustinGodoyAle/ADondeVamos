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

namespace ADondeVamos.Ventanas
{
    public partial class VentanaCharla : Form
    {
        Sistema sistema;
        Usuario usuario;
        EventoCharla evento;
        public VentanaCharla(EventoCharla evento1, Sistema aux)
        {
            evento = evento1;
            sistema = aux;
            usuario = evento.Creador;
            InitializeComponent();

            int anno = DateTime.Now.Year; int dia = DateTime.Now.Day; int mes = DateTime.Now.Month;
            int hora = DateTime.Now.Hour; int minu = DateTime.Now.Minute;
            horarioDateTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
            horariofinDateTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
        }

        private void VentanaCharla_Load(object sender, EventArgs e)
        {
            ////dt = new DataTable();
            ////dt.Columns.Add(new DataColumn("Tema", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Horario Inicio", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Horario Fin", typeof(string)));

            //////Insertando datos al dt para mostrar en la lista
            ////dataGridView1.DataSource = dt;
        }

        public bool ValidarDatos(string nombre, DateTime inicio, DateTime final)
        {
            bool bande = false;
            string mensaje = "";
            if (nombre != "")
            {
                if (DateTime.Compare(inicio, final) < 0)
                {
                    if (DateTime.Compare(inicio, evento.FechaFin) < 0 && DateTime.Compare(inicio, evento.Fecha) >= 0)
                    {
                        if (DateTime.Compare(evento.Fecha, final) < 0 && DateTime.Compare(final, evento.FechaFin) <= 0)
                        {
                            bande = true;
                        }
                    }
                }
            }
            else
            {
                mensaje += "Debe ingresar un tema\n";
            }
            if (DateTime.Compare(inicio, final) >= 0)
            {
                mensaje += "La fecha de inicio de la Charla debe ser menor a la fecha final\n";
            }
            if (DateTime.Compare(inicio, evento.FechaFin) >= 0 || DateTime.Compare(inicio, evento.Fecha) < 0)
            {
                mensaje += "La fecha de inicio de la Charla debe ser menor a la fecha final del Evento Charla\n";
                mensaje += "Y la fecha de inicio de la Charla debe ser mayor o igual a la fecha de inicio del Evento Charla\n";
            }
            if (DateTime.Compare(evento.Fecha, final) >= 0 || DateTime.Compare(final, evento.FechaFin) > 0)
            {
                mensaje += "La fecha final de la Charla debe ser mayor a la fecha de inicio del Evento Charla\n";
                mensaje += "La fecha final de la Charla debe ser menor o igual a la fecha final del Evento Charla\n";
            }
            if (bande == false)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            DateTime inicio = horarioDateTime.Value;
            DateTime final = horariofinDateTime.Value;
            if (ValidarDatos(tematxt.Text, inicio, final))
            {
                Charla charla = new Charla(tematxt.Text, inicio, final);
                //evento.AgregarCharla(charla);
                //dt.Rows.Add(charla.TemadeCharla, charla.Horario, charla.HorarioFin);
                dataGridView1.Rows.Add(charla.TemadeCharla, charla.Horario, charla.HorarioFin);
                VentanaOrador f = new VentanaOrador(charla, evento);
                f.Show();
            }
            
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (evento.Charlas.Any() == true)
            {
                evento.MostrarDatos();
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (item == evento.Creador)
                    {
                        item.AgregarEvento(evento);
                    }
                }
                sistema.Charlas.Add(evento);
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
                Inicio f = new Inicio(evento.Creador, sistema);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe agregar al menos una charla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCrear f = new VentanaCrear(usuario, sistema);
            f.Show();
            this.Hide();

        }
    }
}
