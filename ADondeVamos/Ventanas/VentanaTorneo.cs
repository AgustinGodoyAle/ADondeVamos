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
    public partial class VentanaTorneo : Form
    {
        EventoDeportivoTorneo evento;
        Usuario usuario;
        Sistema sistema;
        public VentanaTorneo(EventoDeportivoTorneo aux, Sistema aux2)
        {
            sistema = aux2;
            evento = aux;
            usuario = evento.Creador;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Torneo torneo = new Torneo(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            torneo.Partidos = new List<Partido>();
            evento.AgregarTorneo(torneo);
            VentanaPartido f = new VentanaPartido(evento, sistema);
            f.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VentanaCrear f = new VentanaCrear(usuario,sistema);
            f.Show();
            this.Hide();
        }
    }
}
