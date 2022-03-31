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

namespace ADondeVamos
{
    public partial class VentanaCarrera : Form
    {
        EventoDeportivoCarrera evento;

        DataTable dt;

        Sistema sistema;
        Usuario usuario;
        public VentanaCarrera(EventoDeportivoCarrera a, Sistema aux)
        {
            sistema = aux;
            evento = a;
            usuario = evento.Creador;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            int anno = DateTime.Now.Year; int dia = DateTime.Now.Day; int mes = DateTime.Now.Month;
            int hora = DateTime.Now.Hour; int minu = DateTime.Now.Minute;
            horario.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (evento.Carreras.Any() == true)
            {
                evento.MostrarDatos();
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (item == evento.Creador)
                    {
                        item.AgregarEvento(evento);
                    }
                }
                sistema.Carreras.Add(evento);
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();

                Inicio f = new Inicio(evento.Creador, sistema);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe agregar al menos una carrera", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaCrear f = new VentanaCrear(usuario,sistema);
            f.Show();
            this.Hide();
        }

        private void VentanaCarrera_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Categoria", typeof(string)));
            dt.Columns.Add(new DataColumn("Distancia", typeof(string)));
            dt.Columns.Add(new DataColumn("Horario", typeof(string)));

            //Insertando datos al dt para mostrar en la lista
            dataGridView1.DataSource = dt;
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            DateTime Horario = horario.Value;
            if (evento.ValidarDatos(textBox1.Text, Horario)==true)
            {
                Carrera carrera = new Carrera(Convert.ToDouble(textBox1.Text), comboBox1.Text, Horario);
                evento.AgregarCarrera(carrera);
                dt.Rows.Add(carrera.Categoria, carrera.Distancia, carrera.Horario);
            }
        }
    }
}
