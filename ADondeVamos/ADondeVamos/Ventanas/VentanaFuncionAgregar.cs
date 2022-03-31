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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inicio = diaDateTime.Value; DateTime final = diafinDateTime.Value;
            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, inicio, final);
            Funcion funcion = new Funcion(textBox1.Text, comboBox2.Text, comboBox3.Text, comboBox1.Text, inicio, final);
            VentanaArtista f = new VentanaArtista(eventofuncion, funcion);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaFuncion f = new VentanaFuncion(auxi, sistema);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
