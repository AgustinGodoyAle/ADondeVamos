using ADondeVamos.Clases;
using ADondeVamos.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    public partial class VentanaArtista : Form
    {
        DataTable dt;
        EventoFiesta fiesta;
        EventoConcierto concierto;
        EventoFuncion evento;
        Funcion funcion;
        List<Artista> Actores;
        Banda banda;

        public VentanaArtista(EventoFiesta aux, Banda aux2) 
        {
            fiesta = aux;
            banda = aux2;
            InitializeComponent();
            titulo.Text = $"INTEGRANTES DE {banda.Nombre}";
        }
        public VentanaArtista(EventoConcierto aux, Banda aux2)
        {
            concierto = aux;
            banda = aux2;
            InitializeComponent();
            titulo.Text = $"INTEGRANTES DE {banda.Nombre}";
        }
        public VentanaArtista(EventoFuncion aux3,Funcion aux)
        {
            evento = aux3;
            funcion = aux;
            Actores = funcion.Actores;
            InitializeComponent();
            titulo.Text = $"ACTORES DE {funcion.Nombre}";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Protagonista");
            comboBox1.Items.Add("Secundario");
            comboBox1.Items.Add("De reparto");
            comboBox1.Items.Add("De pequeñas partes");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fiesta!=null)
            {
                fiesta.AgregarBanda(banda);
                this.Hide();
            }
            else
            {
                if (concierto != null)
                {
                    concierto.AgregarBanda(banda);
                    this.Hide();
                }
                else
                {
                    evento.AgregarFuncion(funcion);
                    this.Hide();
                }
            }
        }

        private void VentanaArtista_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Categoría", typeof(string)));
            dt.Columns.Add(new DataColumn("Correo", typeof(string)));
            //Insertando datos al dt para mostrar en la lista
            dataGridView1.DataSource = dt;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Artista artista = new Artista(nombretxtbox.Text, apellidotxtbox.Text, comboBox1.Text);
            artista.Correo = correoo.Text;

            if (fiesta != null || concierto != null)
                banda.AgregarArtista(artista);
            else
                funcion.AgregarActor(artista);

            dt.Rows.Add(artista.Nombre+" "+artista.Apellido, artista.Categoria, artista.Correo);
            nombretxtbox.Text = "";
            apellidotxtbox.Text = "";
            comboBox1.SelectedIndex = -1;
            correoo.Text = "";
        }
    }
}
