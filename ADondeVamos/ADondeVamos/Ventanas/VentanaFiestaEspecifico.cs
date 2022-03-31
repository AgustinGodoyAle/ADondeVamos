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
    public partial class VentanaFiestaEspecifico : Form
    {
        EventoFiesta fiesta;
        EventoConcierto concierto;
        EventoDeportivoTorneo torneo;
        EventoDeportivoCarrera carrera;
        EventoFuncion eventofuncion;
        EventoCharla eventocharla;
        string tipo;
        Sistema sistema;
        Usuario usuario;
        public VentanaFiestaEspecifico(EventoFiesta aux, Sistema aux2, Usuario aux3)
        {
            fiesta = aux;
            tipo = "Fiesta";
            sistema = aux2;
            usuario = aux3;
            InitializeComponent();
        }
        public VentanaFiestaEspecifico(EventoConcierto aux, Sistema aux2, Usuario aux3)
        {
            concierto = aux;
            tipo = "Concierto";
            sistema = aux2;
            usuario = aux3;
            InitializeComponent();
        }
        public VentanaFiestaEspecifico(EventoDeportivoTorneo aux, Sistema aux2, Usuario aux3)
        {
            torneo = aux;
            tipo = "Torneo";
            sistema = aux2;
            usuario = aux3;
            InitializeComponent();
        }
        public VentanaFiestaEspecifico(EventoDeportivoCarrera aux, Sistema aux2, Usuario aux3)
        {
            carrera = aux;
            tipo = "Carrera";
            sistema = aux2;
            usuario = aux3;
            InitializeComponent();
        }
        public VentanaFiestaEspecifico(EventoFuncion aux, Sistema aux2, Usuario aux3)
        {
            eventofuncion = aux;
            tipo = "Funcion";
            sistema = aux2;
            usuario = aux3;
            InitializeComponent();
        }
        public VentanaFiestaEspecifico(EventoCharla aux, Sistema aux2, Usuario aux3)
        {
            eventocharla = aux;
            tipo = "Charla";
            sistema = aux2;
            usuario = aux3;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tipo == "Fiesta")
            {
                foreach (EventoFiesta item in sistema.Fiestas)
                {
                    if (fiesta == item)
                    {
                        item.AgregarAsistidor(usuario);
                    }
                }
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (usuario == item)
                    {
                        item.AsistirEvento(fiesta);
                        usuario = item;
                    }
                }
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Fiesta");
                f.Show();
                this.Hide();
            }
            if (tipo == "Concierto")
            {
                foreach (EventoConcierto item in sistema.Conciertos)
                {
                    if (concierto == item)
                    {
                        item.AgregarAsistidor(usuario);
                    }
                }
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (usuario == item)
                    {
                        item.AsistirEvento(concierto);
                        usuario = item;
                    }
                }
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Concierto");
                f.Show();
                this.Hide();
            }
            if(tipo=="Torneo")
            {
                foreach (EventoDeportivoTorneo item in sistema.Torneos)
                {
                    if (torneo == item)
                    {
                        item.AgregarAsistidor(usuario);
                    }
                }
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (usuario == item)
                    {
                        item.AsistirEvento(torneo);
                        usuario = item;
                    }
                }
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Torneo");
                f.Show();
                this.Hide();
            }
            if(tipo=="Carrera")
            {
                foreach (EventoDeportivoCarrera item in sistema.Carreras)
                {
                    if (carrera == item)
                    {
                        item.AgregarAsistidor(usuario);
                    }
                }
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (usuario == item)
                    {
                        item.AsistirEvento(carrera);
                        usuario = item;
                    }
                }
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Carrera");
                f.Show();
                this.Hide();
            }
            if(tipo=="Funcion")
            {
                foreach (EventoFuncion item in sistema.Funciones)
                {
                    if (eventofuncion == item)
                    {
                        item.AgregarAsistidor(usuario);
                    }
                }
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (usuario == item)
                    {
                        item.AsistirEvento(eventofuncion);
                        usuario = item;
                    }
                }
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Funcion");
                f.Show();
                this.Hide();
            }
            if (tipo == "Charla")
            {
                foreach (EventoCharla item in sistema.Charlas)
                {
                    if (eventocharla == item)
                    {
                        item.AgregarAsistidor(usuario);
                    }
                }
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (usuario == item)
                    {
                        item.AsistirEvento(eventocharla);
                        usuario = item;
                    }
                }
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Charla");
                f.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipo == "Fiesta")
            {
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Fiesta");
                f.Show();
                this.Hide();
            }
            if(tipo=="Concierto")
            {
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Concierto");
                f.Show();
                this.Hide();
            }
            if (tipo == "Torneo")
            {
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Torneo");
                f.Show();
                this.Hide();
            }
            if (tipo == "Carrera")
            {
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Carrera");
                f.Show();
                this.Hide();
            }
            if(tipo=="Funcion")
            {
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Funcion");
                f.Show();
                this.Hide();
            }
            if(tipo=="Charla")
            {
                VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Charla");
                f.Show();
                this.Hide();
            }
        }

        private void VentanaFiestaEspecifico_Load_1(object sender, EventArgs e)
        {
            if(tipo=="Fiesta")
                label1.Text = fiesta.Nombre;
            if (tipo == "Concierto")
                label1.Text = concierto.Nombre;
            if (tipo == "Torneo")
                label1.Text = torneo.Nombre;
            if (tipo == "Carrera")
                label1.Text = carrera.Nombre;
            if (tipo == "Funcion")
                label1.Text = eventofuncion.Nombre;
            if (tipo == "Charla")
                label1.Text = eventocharla.Nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tipo=="Fiesta")
                fiesta.MostrarDatos();
            if (tipo == "Concierto")
                concierto.MostrarDatos();
            if (tipo == "Torneo")
                torneo.MostrarDatos();
            if (tipo == "Carrera")
                carrera.MostrarDatos();
            if (tipo == "Funcion")
                eventofuncion.MostrarDatos();
            if (tipo == "Charla")
                eventocharla.MostrarDatos();
        }
    }
}
