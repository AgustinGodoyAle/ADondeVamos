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
    //DateTable dt;
    public partial class VentanaOrador : Form
    {
        Charla charla;
        EventoCharla evento;
        List<Orador> Oradores = new List<Orador>();
        public VentanaOrador(Charla evento1, EventoCharla evento2)
        {
            charla = evento1;
            evento = evento2;
            InitializeComponent();

            int anno = DateTime.Now.Year; int dia = DateTime.Now.Day; int mes = DateTime.Now.Month;
            int hora = DateTime.Now.Hour; int minu = DateTime.Now.Minute;
            horarioDateTime.Value = new DateTime(anno,mes, dia, hora, minu, 0, 0);
            horariofinDateTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            charla.AsociarOradores(Oradores);
            evento.AgregarCharla(charla);
            this.Hide();
        }

        

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            DateTime inicio = horarioDateTime.Value;
            DateTime final = horariofinDateTime.Value;
            if (charla.ValidarDatos(textBox1.Text, textBox2.Text, tematxt.Text, inicio, final) == true)
            {
                Orador orador = new Orador(textBox1.Text, textBox2.Text, tematxt.Text, inicio, final);
                orador.Correo = textBox3.Text;
                orador.Profesion = textBox4.Text;
                Oradores.Add(orador);

                dataGridView1.Rows.Add(orador.Nombre, orador.Apellido, orador.Correo, orador.Tema, orador.Hora, orador.HoraFin);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                tematxt.Text = "";
            }
        }
    }
}
