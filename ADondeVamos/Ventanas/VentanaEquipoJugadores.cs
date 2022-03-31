using ADondeVamos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos.Ventanas
{
    public partial class VentanaEquipoJugadores : Form
    {
        Partido partido;
        Sistema sistema;
        List<Jugador> jugadores1=new List<Jugador>();
        List<Jugador> jugadores2 = new List<Jugador>();
        EventoDeportivoTorneo evento;
        public VentanaEquipoJugadores(EventoDeportivoTorneo aux3, Partido aux, Sistema aux2)
        {
            evento = aux3;
            partido = aux;
            sistema = aux2;
            InitializeComponent();
            label1.Text = partido.Equipo1.Nombre;
            label2.Text = partido.Equipo2.Nombre;
        }

        public bool ValidarDatos(string nombre, string apellido, string posi)
        {
            bool bande = false;
            string mensaje = "";
            try
            {
                if(Convert.ToInt16(posi)>0)
                {
                    if(nombre!="")
                    {
                        if(apellido!="")
                        {
                            bande = true;
                        }
                    }
                }
                else
                {
                    mensaje += "Debe ingresar un número entero positivo para la posición del jugador\n";
                }
            }
            catch
            {
                mensaje += "Debe ingresar un número entero positivo para la posición del jugador\n";
            }
            if (nombre == "")
            {
                mensaje += "Debe ingresar un nombre\n";
            }
            if(apellido=="")
            {
                mensaje += "Debe ingresar un apellido\n";
            }
            if(bande==false)
            {
                MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(textBox1.Text,textBox2.Text,textBox3.Text) == true)
            {
                Jugador jugador1 = new Jugador(textBox1.Text, textBox2.Text, textBox4.Text, Convert.ToInt16(textBox3.Text));
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                jugadores1.Add(jugador1);
                partido.Equipo1.AsociarJugadores(jugadores1);
                textBox1.Text = "";textBox2.Text = "";textBox4.Text = "";textBox3.Text="";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(textBox8.Text, textBox7.Text, textBox6.Text) == true)
            {
                Jugador jugador2 = new Jugador(textBox8.Text, textBox7.Text, textBox5.Text, Convert.ToInt32(textBox6.Text));
                dataGridView2.Rows.Add(textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
                jugadores2.Add(jugador2);
                partido.Equipo2.AsociarJugadores(jugadores2);
                textBox8.Text = ""; textBox7.Text = ""; textBox5.Text = ""; textBox6.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            evento.torneo.AgregarPartido(partido);
            this.Hide();
        }
    }
}
