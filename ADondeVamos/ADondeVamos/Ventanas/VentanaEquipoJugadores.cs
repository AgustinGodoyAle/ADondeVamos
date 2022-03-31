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
        EventoDeportivoTorneo evento;
        public VentanaEquipoJugadores(EventoDeportivoTorneo aux3, Partido aux, Sistema aux2)
        {
            evento = aux3;
            partido = aux;
            sistema = aux2;
            InitializeComponent();
            label1.Text = partido.equipo1.Nombre;
            label2.Text = partido.equipo2.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jugador jugador1 = new Jugador(textBox1.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox3.Text));
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            partido.equipo1.AgregarJugador(jugador1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jugador jugador2 = new Jugador(textBox8.Text, textBox7.Text, textBox5.Text, Convert.ToInt32(textBox6.Text));
            dataGridView2.Rows.Add(textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
            partido.equipo2.AgregarJugador(jugador2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            evento.torneo.AgregarPartido(partido);
            this.Hide();
        }
    }
}
