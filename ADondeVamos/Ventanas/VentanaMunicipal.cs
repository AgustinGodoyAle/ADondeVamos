using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ADondeVamos.Clases;

namespace ADondeVamos
{
    public partial class VentanaMunicipal : Form
    {
        DataTable dt;

        EventoMunicipal evento;
        Usuario usuario;
        Sistema sistema;
        public VentanaMunicipal(EventoMunicipal a)
        {
            evento = a;
            sistema = new Sistema();
            usuario = evento.Creador;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            evento.AgregarDesfile(listaDesfiles);
            evento.AgregarInauguracion(listaInaguracion);
            evento.MostrarDatos();

            //Serialización
            List<EventoMunicipal> Municipales = new List<EventoMunicipal>();
            Municipales.Add(evento);
            sistema.Actos = Municipales;
            var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
            var formatter = new BinaryFormatter();
            formatter.Serialize(file, sistema);
            file.Close();

            Inicio f = new Inicio(usuario, sistema);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaCrear f = new VentanaCrear(usuario, sistema);
            f.Show();
            this.Hide();
        }

        private void VentanaMunicipal_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Tipo", typeof(string)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));

            //Insertando datos al dt para mostrar en la lista
            dataGridView1.DataSource = dt;
        }

        List<Inauguracion> listaInaguracion= new List<Inauguracion>();
        private void botonInauguracion_Click(object sender, EventArgs e)
        {
            Inauguracion inauguracion = new Inauguracion(textBox1.Text);
            listaInaguracion.Add(inauguracion);
            dt.Rows.Add("Inauguracion: ",inauguracion.Nombre);
        }

        List<Desfile> listaDesfiles=new List<Desfile>();
        private void botonDesfile_Click(object sender, EventArgs e)
        {
            Desfile desfile = new Desfile(textBox2.Text);
            listaDesfiles.Add(desfile);
            dt.Rows.Add("Desfile: ", desfile.Nombre);
        }
    }
}
