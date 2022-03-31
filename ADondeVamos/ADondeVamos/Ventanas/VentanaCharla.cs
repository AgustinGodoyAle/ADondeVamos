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
        DataTable dt;
        Sistema sistema;
        Usuario usuario;
        EventoCharla evento;
        public VentanaCharla(EventoCharla evento1, Sistema aux)
        {
            evento = evento1;
            sistema = aux;
            usuario = evento.Creador;
            InitializeComponent();
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

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            DateTime inicio = horarioDateTime.Value;
            DateTime final = horariofinDateTime.Value;
            Charla charla = new Charla(tematxt.Text, inicio, final);
            //evento.AgregarCharla(charla);
            //dt.Rows.Add(charla.TemadeCharla, charla.Horario, charla.HorarioFin);
            dataGridView1.Rows.Add(charla.TemadeCharla, charla.Horario, charla.HorarioFin);
            VentanaOrador f = new VentanaOrador(charla, evento);
            f.Show();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
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
    }
}
