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
    public partial class VentanaFuncionAgregar : Form
    {
        EventoFuncion eventofuncion;
        EventoFuncion auxi;
        Sistema sistema;
        public VentanaFuncionAgregar(EventoFuncion aux, Sistema aux2)
        {
            eventofuncion = aux;
            auxi = aux;
            sistema = aux2;
            InitializeComponent();
            if (eventofuncion.Tipo == "Cine")
                label5.Text = "Cine";

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            int anno = DateTime.Now.Year; int dia = DateTime.Now.Day; int mes = DateTime.Now.Month;
            int hora = DateTime.Now.Hour; int minu = DateTime.Now.Minute;
            diaDateTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
            diafinDateTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
        }

        public bool ValidarDatos(string nombre, DateTime inicio, DateTime final)
        {
            bool bande = false;
            string mensaje = "";
            if(nombre!="")
            {
                if(DateTime.Compare(inicio, final)<0)
                {
                    if (DateTime.Compare(inicio, eventofuncion.FechaFin) < 0 && DateTime.Compare(inicio, eventofuncion.Fecha) >= 0)
                    {
                        if (DateTime.Compare(eventofuncion.Fecha, final) < 0 && DateTime.Compare(final, eventofuncion.FechaFin) <= 0)
                        {
                            bande = true;
                        }
                    }
                }
            }
            else
            {
                mensaje += "Debe ingresar un nombre\n";
            }
            if (DateTime.Compare(inicio, final) >= 0)
            {
                mensaje += "La fecha de inicio de la Función debe ser menor a la fecha final\n";
            }
            if (DateTime.Compare(inicio, eventofuncion.FechaFin) >= 0 || DateTime.Compare(inicio, eventofuncion.Fecha) < 0)
            {
                mensaje += "La fecha de inicio de la Función debe ser menor a la fecha final del Evento Función\n";
                mensaje += "Y la fecha de inicio de la Función debe ser mayor o igual a la fecha de inicio del Evento Función\n";
            }
            if (DateTime.Compare(eventofuncion.Fecha, final) >= 0 || DateTime.Compare(final, eventofuncion.FechaFin) > 0)
            {
                mensaje += "La fecha final de la Función debe ser mayor a la fecha de inicio del Evento Función";
                mensaje += "La fecha final de la Función debe ser menor o igual a la fecha final del Evento Función";
            }
            if(bande==false)
            {
                MessageBox.Show(mensaje,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return bande;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inicio = diaDateTime.Value; DateTime final = diafinDateTime.Value;
            if (ValidarDatos(textBox1.Text, inicio, final))
            {
                dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, inicio, final);
                Funcion funcion = new Funcion(textBox1.Text, comboBox2.Text, comboBox3.Text, comboBox1.Text, inicio, final);
                VentanaArtista f = new VentanaArtista(eventofuncion, funcion);
                f.Show();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaFuncion f = new VentanaFuncion(auxi, sistema);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (eventofuncion.Funciones.Any() == true)
            {
                eventofuncion.MostrarDatos();
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (item == eventofuncion.Creador)
                    {
                        item.AgregarEvento(eventofuncion);
                    }
                }
                sistema.Funciones.Add(eventofuncion);
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();

                Inicio f = new Inicio(eventofuncion.Creador, sistema);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe agregar al menos una función","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
