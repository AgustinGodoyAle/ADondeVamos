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
        List<Banda> bandas = new List<Banda>();
        List<Artista> artistas = new List<Artista>();
        Banda banda;

        public VentanaArtista(EventoFiesta aux, Banda aux2) 
        {
            fiesta = aux;
            banda = aux2;
            if (fiesta.Bandas == null)
                fiesta.Bandas = new List<Banda>();
            bandas = fiesta.Bandas;
            InitializeComponent();
            titulo.Text = $"INTEGRANTES DE\n{banda.Nombre.ToUpper()}";
            comboBox1.SelectedIndex = 6;
        }
        public VentanaArtista(EventoConcierto aux, Banda aux2)
        {
            concierto = aux;
            banda = aux2;
            if (concierto.Bandas == null)
                concierto.Bandas = new List<Banda>();
            bandas = concierto.Bandas;
            InitializeComponent();
            titulo.Text = $"INTEGRANTES DE\n{banda.Nombre.ToUpper()}";
            comboBox1.SelectedIndex = 6;
        }
        public VentanaArtista(EventoFuncion aux3,Funcion aux)
        {
            evento = aux3;
            funcion = aux;
            artistas = funcion.Actores;
            InitializeComponent();
            titulo.Text = $"ACTORES DE\n{funcion.Nombre.ToUpper()}";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Protagonista");
            comboBox1.Items.Add("Secundario");
            comboBox1.Items.Add("De reparto");
            comboBox1.Items.Add("De pequeñas partes");
            comboBox1.SelectedIndex = 0;
        }

        public bool ValidarDatos(string nombre, string apellido)
        {
            string mensaje="";
            bool bande = true;
            if(nombre=="")
            {
                mensaje += "Debe ingresar un nombre\n";
                bande = false;
            }
            if(apellido=="")
            {
                mensaje += "Debe ingresar un apellido\n";
                bande = false;
            }
            if(bande==false)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fiesta!=null)
            {
                banda.AsociarArtistas(artistas);
                bandas.Add(banda);
                fiesta.AsociarBandas(bandas);
                this.Hide();
            }
            else
            {
                if (concierto != null)
                {
                    banda.AsociarArtistas(artistas);
                    bandas.Add(banda);
                    concierto.AsociarBandas(bandas);
                    this.Hide();
                }
                else
                {
                    funcion.AsociarActores(artistas);
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
            dt.Columns.Add(new DataColumn("Contacto", typeof(string)));
            //Insertando datos al dt para mostrar en la lista
            dataGridView1.DataSource = dt;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(nombretxtbox.Text, apellidotxtbox.Text) == true)
            {
                Artista artista = new Artista(nombretxtbox.Text, apellidotxtbox.Text, comboBox1.Text);
                artista.Correo = correoo.Text;

                if (artistas == null) 
                {
                    artistas = new List<Artista>();
                }

                artistas.Add(artista);

                dt.Rows.Add(artista.Nombre + " " + artista.Apellido, artista.Categoria, artista.Correo);
                nombretxtbox.Text = "";
                apellidotxtbox.Text = "";
                comboBox1.SelectedIndex = 0;
                correoo.Text = "";
            }
            else
            {
                correoo.Text = "";
            }
        }
    }
}
