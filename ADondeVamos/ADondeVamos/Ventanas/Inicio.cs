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
    public partial class Inicio : Form
    {
        Sistema sistema;
        Usuario usuario;
        public Inicio(Usuario aux, Sistema auxsis)
        {
            usuario = aux;
            sistema = auxsis;
            InitializeComponent();

            label1.Text = ($"{usuario.Nombre} {usuario.Apellido}");
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCrear f = new VentanaCrear(usuario, sistema);
            f.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Principal f = new Principal(sistema);
            f.Show();
            this.Hide();
        }

        private void fiestas_Click(object sender, EventArgs e)
        {
            VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Fiesta");
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Torneo");
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Concierto");
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Carrera");
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Funcion");
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Charla");
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventosVerActuales f = new EventosVerActuales(sistema, usuario);
            f.Show();
            this.Hide();
        }
    }
}
