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
    public partial class VentanaBanda : Form
    {
        DataTable dt;
        EventoFiesta fiesta;
        EventoConcierto concierto;
        Sistema sistema;
        public VentanaBanda(EventoConcierto aux, Sistema aux2)
        {
            sistema = aux2;
            concierto = aux;
            InitializeComponent();
            genero.SelectedIndex = 0;

            int anno = DateTime.Now.Year; int dia = DateTime.Now.Day; int mes = DateTime.Now.Month;
            int hora = DateTime.Now.Hour; int minu = DateTime.Now.Minute;
            inicioo.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
            finn.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
        }
        public VentanaBanda(EventoFiesta aux, Sistema aux2)
        {
            sistema = aux2;
            fiesta = aux;
            InitializeComponent();
            genero.SelectedIndex = 0;

            int anno = DateTime.Now.Year; int dia = DateTime.Now.Day; int mes = DateTime.Now.Month;
            int hora = DateTime.Now.Hour; int minu = DateTime.Now.Minute;
            inicioo.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
            finn.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
        }

        public bool ValidarDatos(string nombre, DateTime inicio, DateTime fin)
        {
            bool bande = false;
            string mensaje = "";
            if (fiesta!=null)
            {
                if(DateTime.Compare(inicio, fin)<0)
                {
                    if(nombre!="")
                    {
                        if(DateTime.Compare(inicio,fiesta.FechaFin)<0 && DateTime.Compare(inicio,fiesta.Fecha)>=0)
                        {
                            if(DateTime.Compare(fiesta.Fecha, fin)<0 && DateTime.Compare(fin, fiesta.FechaFin)<=0)
                            {
                                bande = true;
                            }
                            else
                            {
                                bande = false;
                            }
                        }
                        else
                        {
                            bande = false;
                        }
                    }
                    else
                    {
                        bande = false;
                    }
                }
                else
                {
                    mensaje += "La fecha de inicio de la Banda debe ser menor a la fecha final\n";
                    bande = false;
                }
                if (nombre=="")
                {
                    mensaje += "Debe ingresar un nombre\n";
                }
                if (DateTime.Compare(inicio, fiesta.FechaFin) >= 0 || DateTime.Compare(inicio, fiesta.Fecha) < 0)
                {
                    mensaje += "La fecha de inicio de la Banda debe ser menor a la fecha final de la Fiesta\n";
                    mensaje += "Y la fecha de inicio de la Banda debe ser mayor o igual a la fecha de inicio de la Fiesta\n";
                }
                if (DateTime.Compare(fiesta.Fecha, fin) >= 0 || DateTime.Compare(fin, fiesta.FechaFin) > 0)
                {
                    mensaje += "La fecha final de la Banda debe ser mayor o igual a la fecha de inicio de la Fiesta\n";
                    mensaje += "Y la fecha final de la Banda debe ser menor a la fecha final de la Fiesta\n";
                }
            }
            else
            {
                if (DateTime.Compare(inicio, fin) < 0)
                {
                    if (nombre != "")
                    {
                        if (DateTime.Compare(inicio, concierto.FechaFin) < 0 && DateTime.Compare(inicio, concierto.Fecha) >= 0)
                        {
                            if (DateTime.Compare(concierto.Fecha, fin) < 0 && DateTime.Compare(fin, concierto.FechaFin) <= 0)
                            {
                                bande = true;
                            }
                            else
                            {
                                bande = false;
                            }
                        }
                        else
                        {
                            bande = false;
                        }
                    }
                    else
                    {
                        bande = false;
                    }
                }
                else
                {
                    mensaje += "La fecha de inicio de la Banda debe ser menor a la fecha final";
                    bande = false;
                }
                if (nombre=="")
                {
                    mensaje += "Debe ingresar un nombre\n";
                }
                if (DateTime.Compare(inicio, concierto.FechaFin) >= 0 || DateTime.Compare(inicio, concierto.Fecha) < 0)
                {
                    mensaje += "La fecha de inicio de la Banda debe ser menor a la fecha final del Concierto\n";
                    mensaje += "Y la fecha de inicio de la Banda debe ser mayor o igual a la fecha de inicio del Concierto\n";
                }
                if (DateTime.Compare(concierto.Fecha, fin) >= 0 || DateTime.Compare(fin, concierto.FechaFin) > 0)
                {
                    mensaje += "La fecha final de la Banda debe ser mayor o igual a la fecha de inicio del Concierto\n";
                    mensaje += "Y la fecha final de la Banda debe ser menor a la fecha final del Concierto\n";
                }
            }
            if(bande==false)
            {
                MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inicio = inicioo.Value;
            DateTime fin = finn.Value;
            
            if(ValidarDatos(nombre.Text, inicio, fin)==true)
            {
                Banda banda = new Banda(nombre.Text, genero.SelectedItem.ToString());
                banda.FechaInicio = inicio.ToShortDateString() + "-" + inicio.ToShortTimeString();
                banda.FechaFin = fin.ToShortDateString() + "-" + fin.ToShortTimeString();
                banda.Contacto = contacto.Text;

                nombre.Text = "";
                genero.SelectedIndex = 0;
                contacto.Text = "";

                dt.Rows.Add(banda.Nombre, banda.Genero, banda.FechaInicio, banda.FechaFin, banda.Contacto);
                if (fiesta != null)
                {
                    VentanaArtista f = new VentanaArtista(fiesta, banda);
                    f.Show();
                }
                else
                {
                    VentanaArtista f = new VentanaArtista(concierto, banda);
                    f.Show();
                }
            }
            else
            {
                nombre.Text = "";
                genero.SelectedIndex = 0;
                contacto.Text = "";
            }
            
        }

        private void VentanaBanda_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Género", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Final", typeof(string)));
            dt.Columns.Add(new DataColumn("Contacto", typeof(string)));
            //Insertando datos al dt para mostrar en la lista
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fiesta != null)
            {
                if (fiesta.Bandas.Any() == true)
                {
                    fiesta.MostrarDatos();
                    foreach (Usuario item in sistema.Usuarios)
                    {
                        if (item == fiesta.Creador)
                        {
                            item.AgregarEvento(fiesta);
                        }
                    }
                    sistema.Fiestas.Add(fiesta);
                    var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(file, sistema);
                    file.Close();

                    Inicio f = new Inicio(fiesta.Creador, sistema);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Debe agregar al menos una banda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (concierto.Bandas.Any() == true)
                {
                    concierto.MostrarDatos();
                    foreach (Usuario item in sistema.Usuarios)
                    {
                        if (item == concierto.Creador)
                        {
                            item.AgregarEvento(concierto);
                        }
                    }
                    sistema.Conciertos.Add(concierto);
                    var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(file, sistema);
                    file.Close();

                    Inicio f = new Inicio(concierto.Creador, sistema);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Debe agregar al menos una banda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fiesta != null)
            {
                VentanaFiesta f = new VentanaFiesta(fiesta, sistema);
                f.Show();
                this.Hide();
            }
            else
            {
                VentanaCrear f = new VentanaCrear(concierto.Creador, sistema);
                f.Show();
                this.Hide();
            }
        }
    }
}
