using ADondeVamos.Clases;
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
    public partial class VentanaBanda : Form
    {
        DataTable dt;
        EventoFiesta fiesta;
        EventoConcierto concierto;
        Sistema sistema;
        public VentanaBanda(EventoConcierto aux, Sistema aux2)
        {
            sistema = aux2;
            concierto = aux;
            InitializeComponent();
        }
        public VentanaBanda(EventoFiesta aux, Sistema aux2)
        {
            sistema = aux2;
            fiesta = aux;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inicio = inicioo.Value;
            DateTime fin = finn.Value;
            Banda banda = new Banda(nombre.Text, genero.SelectedItem.ToString());
            banda.FechaInicio = inicio.ToShortDateString() + "-" + inicio.ToShortTimeString();
            banda.FechaFin = fin.ToShortDateString() + "-" + fin.ToShortTimeString();
            banda.Contacto = contacto.Text;
            nombre.Text = "";
            genero.SelectedIndex = -1;
            contacto.Text = "";
            dt.Rows.Add(banda.Nombre, banda.Genero, banda.FechaInicio, banda.FechaFin, banda.Contacto);
            if (fiesta != null)
            {
                VentanaArtista f = new VentanaArtista(fiesta, banda);
                f.Show();
            }
            else
            {
                VentanaArtista f = new VentanaArtista(concierto, banda);
                f.Show();
            }
        }

        private void VentanaBanda_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Género", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Final", typeof(string)));
            dt.Columns.Add(new DataColumn("Contacto", typeof(string)));
            //Insertando datos al dt para mostrar en la lista
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fiesta != null)
            {
                fiesta.MostrarDatos();
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (item == fiesta.Creador)
                    {
                        item.AgregarEvento(fiesta);
                    }
                }
                sistema.Fiestas.Add(fiesta);
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();

                Inicio f = new Inicio(fiesta.Creador, sistema);
                f.Show();
                this.Hide();
            }
            else
            {
                concierto.MostrarDatos();
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (item == concierto.Creador)
                    {
                        item.AgregarEvento(concierto);
                    }
                }
                sistema.Conciertos.Add(concierto);
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();

                Inicio f = new Inicio(concierto.Creador, sistema);
                f.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fiesta != null)
            {
                VentanaFiesta f = new VentanaFiesta(fiesta, sistema);
                f.Show();
                this.Hide();
            }
            else
            {
                VentanaCrear f = new VentanaCrear(concierto.Creador, sistema);
                f.Show();
                this.Hide();
            }
        }
    }
}
