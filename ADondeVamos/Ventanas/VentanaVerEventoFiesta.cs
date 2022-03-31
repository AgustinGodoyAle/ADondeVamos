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
    public partial class VentanaVerEventoFiesta : Form
    {
        Sistema sistema;
        Usuario usuario;
        string tipo;

        public VentanaVerEventoFiesta(Usuario aux, Sistema aux2, string aux3)
        {
            tipo = aux3;
            usuario = aux;
            sistema = aux2;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Inicio f = new Inicio(usuario, sistema);
            f.Show();
            this.Hide();
        }

        public List<EventoFiesta> EventosOrdenados(List<EventoFiesta> Fiestas)
        {
            List<EventoFiesta> EventosOrdenados = Fiestas;
            EventosOrdenados = EventosOrdenados.OrderBy(evento1 => evento1.CantidadAsistentes).ToList();
            EventosOrdenados.Reverse();
            return EventosOrdenados;
        }
        public List<EventoConcierto> EventosOrdenados(List<EventoConcierto> Eventos)
        {
            List<EventoConcierto> EventosOrdenados = Eventos;
            EventosOrdenados = EventosOrdenados.OrderBy(evento1 => evento1.CantidadAsistentes).ToList();
            EventosOrdenados.Reverse();
            return EventosOrdenados;
        }
        public List<EventoDeportivoTorneo> EventosOrdenados(List<EventoDeportivoTorneo> Eventos)
        {
            List<EventoDeportivoTorneo> EventosOrdenados = Eventos;
            EventosOrdenados = EventosOrdenados.OrderBy(evento1 => evento1.CantidadAsistentes).ToList();
            EventosOrdenados.Reverse();
            return EventosOrdenados;
        }
        public List<EventoDeportivoCarrera> EventosOrdenados(List<EventoDeportivoCarrera> Eventos)
        {
            List<EventoDeportivoCarrera> EventosOrdenados = Eventos;
            EventosOrdenados = EventosOrdenados.OrderBy(evento1 => evento1.CantidadAsistentes).ToList();
            EventosOrdenados.Reverse();
            return EventosOrdenados;
        }
        public List<EventoFuncion> EventosOrdenados(List<EventoFuncion> Eventos)
        {
            List<EventoFuncion> EventosOrdenados = Eventos;
            EventosOrdenados = EventosOrdenados.OrderBy(evento1 => evento1.CantidadAsistentes).ToList();
            EventosOrdenados.Reverse();
            return EventosOrdenados;
        }
        public List<EventoCharla> EventosOrdenados(List<EventoCharla> Eventos)
        {
            List<EventoCharla> EventosOrdenados = Eventos;
            EventosOrdenados = EventosOrdenados.OrderBy(evento1 => evento1.CantidadAsistentes).ToList();
            EventosOrdenados.Reverse();
            return EventosOrdenados;
        }
        private void VentanaVerEventos_Load(object sender, EventArgs e)
        {
            if (tipo == "Fiesta")
            {
                label4.Text = "Fiestas";
                List<EventoFiesta> Fiestas = sistema.Fiestas;
                Fiestas = this.EventosOrdenados(Fiestas);
                int i = 0;
                foreach (EventoFiesta item in Fiestas)
                {
                    i++;
                    foreach (EventoFiesta item2 in usuario.Fiestas)
                    {
                        if (item2 == item)
                        {
                            Creados.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item2.Number = i;
                        }
                    }
                    foreach (EventoFiesta item3 in usuario.EAsistidosFies)
                    {
                        if (item3 == item)
                        {
                            Asistir.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item3.Number = i;
                        }
                    }
                    if (usuario.Amigos != null)
                    {
                        foreach (Usuario item4 in usuario.Amigos)
                        {
                            foreach (EventoFiesta item5 in item4.EAsistidosFies)
                            {
                                if (item5 == item)
                                {
                                    Amigos.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                                    item5.Number = i;
                                }
                            }
                        }
                    }
                    item.Number = i;
                    dRanking.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                }
            }
            if (tipo == "Concierto")
            {
                label4.Text = "Conciertos";
                List<EventoConcierto> Conciertos = sistema.Conciertos;
                Conciertos = this.EventosOrdenados(Conciertos);
                int i = 0;
                foreach (EventoConcierto item in Conciertos)
                {
                    i++;
                    foreach (EventoConcierto item2 in usuario.Conciertos)
                    {
                        if (item2 == item)
                        {
                            Creados.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item2.Number = i;
                        }
                    }
                    foreach (EventoConcierto item3 in usuario.EAsistidosConc)
                    {
                        if (item3 == item)
                        {
                            Asistir.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item3.Number = i;
                        }
                    }
                    if (usuario.Amigos != null)
                    {
                        foreach (Usuario item4 in usuario.Amigos)
                        {
                            foreach(EventoConcierto item5 in item4.EAsistidosConc)
                            {
                                if (item5 == item)
                                {
                                    Amigos.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                                    item5.Number = i;
                                }
                            }
                        }
                    }
                    item.Number = i;
                    dRanking.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                }
            }
            if(tipo=="Torneo")
            {
                label4.Text = "Torneos";
                List<EventoDeportivoTorneo> Torneos = sistema.Torneos;
                Torneos = this.EventosOrdenados(Torneos);
                int i = 0;
                foreach (EventoDeportivoTorneo item in Torneos)
                {
                    i++;
                    foreach (EventoDeportivoTorneo item2 in usuario.Torneos)
                    {
                        if (item2 == item)
                        {
                            Creados.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item2.Number = i;
                        }
                    }
                    foreach (EventoDeportivoTorneo item3 in usuario.EAsistidosTorn)
                    {
                        if (item3 == item)
                        {
                            Asistir.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item3.Number = i;
                        }
                    }
                    if (usuario.Amigos != null)
                    {
                        foreach (Usuario item4 in usuario.Amigos)
                        {
                            foreach (EventoDeportivoTorneo item5 in item4.EAsistidosTorn)
                            {
                                if (item5 == item)
                                {
                                    Amigos.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                                    item5.Number = i;
                                }
                            }
                        }
                    }
                    item.Number = i;
                    dRanking.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                }
            }
            if(tipo=="Carrera")
            {
                label4.Text = "Carreras";
                List<EventoDeportivoCarrera> Carreras = sistema.Carreras;
                Carreras = this.EventosOrdenados(Carreras);
                int i = 0;
                foreach (EventoDeportivoCarrera item in Carreras)
                {
                    i++;
                    foreach (EventoDeportivoCarrera item2 in usuario.Carreras)
                    {
                        if (item2 == item)
                        {
                            Creados.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item2.Number = i;
                        }
                    }
                    foreach (EventoDeportivoCarrera item3 in usuario.EAsistidosCarr)
                    {
                        if (item3 == item)
                        {
                            Asistir.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item3.Number = i;
                        }
                    }
                    if (usuario.Amigos != null)
                    {
                        foreach (Usuario item4 in usuario.Amigos)
                        {
                            foreach (EventoDeportivoCarrera item5 in item4.EAsistidosCarr)
                            {
                                if (item5 == item)
                                {
                                    Amigos.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                                    item5.Number = i;
                                }
                            }
                        }
                    }
                    item.Number = i;
                    dRanking.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                }
            }
            if(tipo=="Funcion")
            {
                label4.Text = "Funciones";
                List<EventoFuncion> Funciones = sistema.Funciones;
                Funciones = this.EventosOrdenados(Funciones);
                int i = 0;
                foreach (EventoFuncion item in Funciones)
                {
                    i++;
                    foreach (EventoFuncion item2 in usuario.Funciones)
                    {
                        if (item2 == item)
                        {
                            Creados.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item2.Number = i;
                        }
                    }
                    foreach (EventoFuncion item3 in usuario.EAsistidosFunc)
                    {
                        if (item3 == item)
                        {
                            Asistir.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item3.Number = i;
                        }
                    }
                    if (usuario.Amigos != null)
                    {
                        foreach (Usuario item4 in usuario.Amigos)
                        {
                            foreach (EventoFuncion item5 in item4.EAsistidosFunc)
                            {
                                if (item5 == item)
                                {
                                    Amigos.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                                    item5.Number = i;
                                }
                            }
                        }
                    }
                    item.Number = i;
                    dRanking.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                }
            }
            if(tipo=="Charla")
            {
                label4.Text = "Charla";
                List<EventoCharla> Charlas = sistema.Charlas;
                Charlas = this.EventosOrdenados(Charlas);
                int i = 0;
                foreach (EventoCharla item in Charlas)
                {
                    i++;
                    foreach (EventoCharla item2 in usuario.Charlas)
                    {
                        if (item2 == item)
                        {
                            Creados.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item2.Number = i;
                        }
                    }
                    foreach (EventoCharla item3 in usuario.EAsistidosChar)
                    {
                        if (item3 == item)
                        {
                            Asistir.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                            item3.Number = i;
                        }
                    }
                    if (usuario.Amigos != null)
                    {
                        foreach (Usuario item4 in usuario.Amigos)
                        {
                            foreach (EventoCharla item5 in item4.EAsistidosChar)
                            {
                                if (item5 == item)
                                {
                                    Amigos.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                                    item5.Number = i;
                                }
                            }
                        }
                    }
                    item.Number = i;
                    dRanking.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, i);
                }
            }

        }




        private void dRanking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipo == "Fiesta")
            {
                if (dRanking.Columns[e.ColumnIndex].Name == "VerEvento")
                {
                    int valor = (int)dRanking.CurrentRow.Cells["VerEvento"].Value;
                    foreach (EventoFiesta item in this.EventosOrdenados(sistema.Fiestas))
                    {
                        if (item.Number == valor)
                        {
                            VentanaFiestaEspecifico f = new VentanaFiestaEspecifico(item, sistema, usuario);
                            f.Show();
                            this.Close();
                        }
                    }
                }
            }
            if (tipo == "Concierto")
            {
                if (dRanking.Columns[e.ColumnIndex].Name == "VerEvento")
                {
                    int valor = (int)dRanking.CurrentRow.Cells["VerEvento"].Value;
                    foreach (EventoConcierto item in this.EventosOrdenados(sistema.Conciertos))
                    {
                        if (item.Number == valor)
                        {
                            VentanaFiestaEspecifico f = new VentanaFiestaEspecifico(item, sistema, usuario);
                            f.Show();
                            this.Close();
                        }
                    }
                }
            }
            if(tipo=="Torneo")
            {
                if (dRanking.Columns[e.ColumnIndex].Name == "VerEvento")
                {
                    int valor = (int)dRanking.CurrentRow.Cells["VerEvento"].Value;
                    foreach (EventoDeportivoTorneo item in this.EventosOrdenados(sistema.Torneos))
                    {
                        if (item.Number == valor)
                        {
                            VentanaFiestaEspecifico f = new VentanaFiestaEspecifico(item, sistema, usuario);
                            f.Show();
                            this.Close();
                        }
                    }
                }
            }
            if(tipo=="Carrera")
            {
                if (dRanking.Columns[e.ColumnIndex].Name == "VerEvento")
                {
                    int valor = (int)dRanking.CurrentRow.Cells["VerEvento"].Value;
                    foreach (EventoDeportivoCarrera item in this.EventosOrdenados(sistema.Carreras))
                    {
                        if (item.Number == valor)
                        {
                            VentanaFiestaEspecifico f = new VentanaFiestaEspecifico(item, sistema, usuario);
                            f.Show();
                            this.Close();
                        }
                    }
                }
            }
            if (tipo == "Funcion")
            {
                if (dRanking.Columns[e.ColumnIndex].Name == "VerEvento")
                {
                    int valor = (int)dRanking.CurrentRow.Cells["VerEvento"].Value;
                    foreach (EventoFuncion item in this.EventosOrdenados(sistema.Funciones))
                    {
                        if (item.Number == valor)
                        {
                            VentanaFiestaEspecifico f = new VentanaFiestaEspecifico(item, sistema, usuario);
                            f.Show();
                            this.Close();
                        }
                    }
                }
            }
            if (tipo == "Charla")
            {
                if (dRanking.Columns[e.ColumnIndex].Name == "VerEvento")
                {
                    int valor = (int)dRanking.CurrentRow.Cells["VerEvento"].Value;
                    foreach (EventoCharla item in this.EventosOrdenados(sistema.Charlas))
                    {
                        if (item.Number == valor)
                        {
                            VentanaFiestaEspecifico f = new VentanaFiestaEspecifico(item, sistema, usuario);
                            f.Show();
                            this.Close();
                        }
                    }
                }
            }

        }

        private void Creados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipo == "Fiesta")
            {
                //Uso un evento como auxiliar
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoFiesta evento = new EventoFiesta("", a, a, 0, "", aux);
                if (Creados.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int valor = (int)Creados.CurrentRow.Cells["Eliminar"].Value;
                    int bande = 0;
                    foreach (EventoFiesta item in usuario.Fiestas)
                    {
                        if (item.Number == valor)
                        {
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    //item2.EliminarEvento(item);
                                    usuario = item2;
                                    bande = 1;
                                    foreach (EventoFiesta item3 in item2.EAsistidosFies)
                                    {
                                        if (item == item3)
                                        {
                                            //item2.NoAsistirEvento(item3);
                                            usuario = item2;
                                        }
                                    }
                                }
                            }
                            evento = item;
                            //sistema.EliminarEvento(item);
                        }
                    }
                    if (bande == 1)
                    {
                        //var indice = 1;
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                //usuario.NoAsistirEvento(evento);
                                //usuario.EliminarEvento(evento);
                                item.NoAsistirEvento(evento);
                                item.EliminarEvento(evento);//AQUIDEBOBORRAR
                                                            //indice = sistema.Usuarios.IndexOf(item);
                            }
                        }
                        //sistema.Usuarios.RemoveAt(indice);
                        //sistema.Usuarios.Insert(indice, usuario);
                        sistema.EliminarEvento(evento);
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Fiesta");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if (tipo == "Concierto")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoConcierto evento = new EventoConcierto("", a, a, 0, "", aux);
                if (Creados.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int valor = (int)Creados.CurrentRow.Cells["Eliminar"].Value;
                    int bande = 0;
                    foreach (EventoConcierto item in usuario.Conciertos)
                    {
                        if (item.Number == valor)
                        {
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                    bande = 1;
                                    foreach (EventoConcierto item3 in item2.EAsistidosConc)
                                    {
                                        if (item == item3)
                                        {
                                            usuario = item2;
                                        }
                                    }
                                }
                                evento = item;
                            }
                        }
                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                                item.EliminarEvento(evento);
                            }
                        }
                        sistema.EliminarEvento(evento);
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Concierto");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if(tipo=="Torneo")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoDeportivoTorneo evento = new EventoDeportivoTorneo("", a, a, 0, "", aux);
                if (Creados.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int valor = (int)Creados.CurrentRow.Cells["Eliminar"].Value;
                    int bande = 0;
                    foreach (EventoDeportivoTorneo item in usuario.Torneos)
                    {
                        if (item.Number == valor)
                        {
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                    bande = 1;
                                    foreach (EventoDeportivoTorneo item3 in item2.EAsistidosTorn)
                                    {
                                        if (item == item3)
                                        {
                                            usuario = item2;
                                        }
                                    }
                                }
                                evento = item;
                            }
                        }
                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                                item.EliminarEvento(evento);
                            }
                        }
                        sistema.EliminarEvento(evento);
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Torneo");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if(tipo=="Carrera")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoDeportivoCarrera evento = new EventoDeportivoCarrera("", a, a, 0, "", aux);
                if (Creados.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int valor = (int)Creados.CurrentRow.Cells["Eliminar"].Value;
                    int bande = 0;
                    foreach (EventoDeportivoCarrera item in usuario.Carreras)
                    {
                        if (item.Number == valor)
                        {
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                    bande = 1;
                                    foreach (EventoDeportivoCarrera item3 in item2.EAsistidosCarr)
                                    {
                                        if (item == item3)
                                        {
                                            usuario = item2;
                                        }
                                    }
                                }
                                evento = item;
                            }
                        }
                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                                item.EliminarEvento(evento);
                            }
                        }
                        sistema.EliminarEvento(evento);
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Carrera");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if(tipo=="Funcion")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoFuncion evento = new EventoFuncion("", a, a, 0, "", aux);
                if (Creados.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int valor = (int)Creados.CurrentRow.Cells["Eliminar"].Value;
                    int bande = 0;
                    foreach (EventoFuncion item in usuario.Funciones)
                    {
                        if (item.Number == valor)
                        {
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                    bande = 1;
                                    foreach (EventoFuncion item3 in item2.EAsistidosFunc)
                                    {
                                        if (item == item3)
                                        {
                                            usuario = item2;
                                        }
                                    }
                                }
                                evento = item;
                            }
                        }
                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                                item.EliminarEvento(evento);
                            }
                        }
                        sistema.EliminarEvento(evento);
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Funcion");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if (tipo == "Charla")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoCharla evento = new EventoCharla("", a, a, 0, "", aux);
                if (Creados.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int valor = (int)Creados.CurrentRow.Cells["Eliminar"].Value;
                    int bande = 0;
                    foreach (EventoCharla item in usuario.Charlas)
                    {
                        if (item.Number == valor)
                        {
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                    bande = 1;
                                    foreach (EventoCharla item3 in item2.EAsistidosChar)
                                    {
                                        if (item == item3)
                                        {
                                            usuario = item2;
                                        }
                                    }
                                }
                                evento = item;
                            }
                        }
                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                                item.EliminarEvento(evento);
                            }
                        }
                        sistema.EliminarEvento(evento);
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Charla");
                        f.Show();
                        this.Close();
                    }
                }
            }
        }

        private void Asistir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipo == "Fiesta")
            {
                //Uso un evento como auxiliar
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoFiesta evento = new EventoFiesta("", a, a, 0, "", aux);
                if (Asistir.Columns[e.ColumnIndex].Name == "NoAsistir")
                {
                    int valor = (int)Asistir.CurrentRow.Cells["NoAsistir"].Value;
                    int bande = 0;
                    foreach (EventoFiesta item in usuario.Fiestas)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    //item2.NoAsistirEvento(item);
                                    usuario = item2;
                                }
                            }
                            //item.EliminarAsistidor(usuario);
                            evento = item;
                        }

                    }
                    foreach (EventoFiesta item in usuario.EAsistidosFies)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    //item2.NoAsistirEvento(item);
                                    usuario = item2;
                                }
                            }
                            //item.EliminarAsistidor(usuario);
                            evento = item;
                        }

                    }
                    if (bande == 1)
                    {
                        //var indice1=1; var indice2=1;
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                //usuario.NoAsistirEvento(evento);
                                //indice1 = sistema.Usuarios.IndexOf(item);
                                item.NoAsistirEvento(evento);
                            }
                        }
                        foreach (EventoFiesta item in sistema.Fiestas)
                        {
                            if (item == evento)
                            {
                                //evento.EliminarAsistidor(usuario);
                                //indice2 = sistema.Fiestas.IndexOf(item);
                                item.EliminarAsistidor(usuario);
                            }
                        }
                        //sistema.Usuarios.RemoveAt(indice1);
                        //sistema.Usuarios.Insert(indice1, usuario);
                        //sistema.Fiestas.RemoveAt(indice2);
                        //sistema.Fiestas.Insert(indice2, evento);
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Fiesta");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if(tipo=="Concierto")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoConcierto evento = new EventoConcierto("", a, a, 0, "", aux);
                if (Asistir.Columns[e.ColumnIndex].Name == "NoAsistir")
                {
                    int valor = (int)Asistir.CurrentRow.Cells["NoAsistir"].Value;
                    int bande = 0;
                    foreach (EventoConcierto item in usuario.Conciertos)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    foreach (EventoConcierto item in usuario.EAsistidosConc)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                            }
                        }
                        foreach (EventoConcierto item in sistema.Conciertos)
                        {
                            if (item == evento)
                            {
                                item.EliminarAsistidor(usuario);
                            }
                        }
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Concierto");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if(tipo=="Torneo")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoDeportivoTorneo evento = new EventoDeportivoTorneo("", a, a, 0, "", aux);
                if (Asistir.Columns[e.ColumnIndex].Name == "NoAsistir")
                {
                    int valor = (int)Asistir.CurrentRow.Cells["NoAsistir"].Value;
                    int bande = 0;
                    foreach (EventoDeportivoTorneo item in usuario.Torneos)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    foreach (EventoDeportivoTorneo item in usuario.EAsistidosTorn)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                            }
                        }
                        foreach (EventoDeportivoTorneo item in sistema.Torneos)
                        {
                            if (item == evento)
                            {
                                item.EliminarAsistidor(usuario);
                            }
                        }
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Torneo");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if(tipo=="Carrera")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoDeportivoCarrera evento = new EventoDeportivoCarrera("", a, a, 0, "", aux);
                if (Asistir.Columns[e.ColumnIndex].Name == "NoAsistir")
                {
                    int valor = (int)Asistir.CurrentRow.Cells["NoAsistir"].Value;
                    int bande = 0;
                    foreach (EventoDeportivoCarrera item in usuario.Carreras)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    foreach (EventoDeportivoCarrera item in usuario.EAsistidosCarr)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                            }
                        }
                        foreach (EventoDeportivoCarrera item in sistema.Carreras)
                        {
                            if (item == evento)
                            {
                                item.EliminarAsistidor(usuario);
                            }
                        }
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Carrera");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if (tipo == "Funcion")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoFuncion evento = new EventoFuncion("", a, a, 0, "", aux);
                if (Asistir.Columns[e.ColumnIndex].Name == "NoAsistir")
                {
                    int valor = (int)Asistir.CurrentRow.Cells["NoAsistir"].Value;
                    int bande = 0;
                    foreach (EventoFuncion item in usuario.Funciones)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    foreach (EventoFuncion item in usuario.EAsistidosFunc)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                            }
                        }
                        foreach (EventoFuncion item in sistema.Funciones)
                        {
                            if (item == evento)
                            {
                                item.EliminarAsistidor(usuario);
                            }
                        }
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Funcion");
                        f.Show();
                        this.Close();
                    }
                }
            }
            if (tipo == "Charla")
            {
                DateTime a = new DateTime(); Usuario aux = new Usuario("", "", "", "");
                EventoCharla evento = new EventoCharla("", a, a, 0, "", aux);
                if (Asistir.Columns[e.ColumnIndex].Name == "NoAsistir")
                {
                    int valor = (int)Asistir.CurrentRow.Cells["NoAsistir"].Value;
                    int bande = 0;
                    foreach (EventoCharla item in usuario.Charlas)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    foreach (EventoCharla item in usuario.EAsistidosChar)
                    {
                        if (item.Number == valor)
                        {
                            bande = 1;
                            foreach (Usuario item2 in sistema.Usuarios)
                            {
                                if (usuario == item2)
                                {
                                    usuario = item2;
                                }
                            }
                            evento = item;
                        }

                    }
                    if (bande == 1)
                    {
                        foreach (Usuario item in sistema.Usuarios)
                        {
                            if (item.Correo == usuario.Correo)
                            {
                                item.NoAsistirEvento(evento);
                            }
                        }
                        foreach (EventoCharla item in sistema.Charlas)
                        {
                            if (item == evento)
                            {
                                item.EliminarAsistidor(usuario);
                            }
                        }
                        var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(file, sistema);
                        file.Close();

                        VentanaVerEventoFiesta f = new VentanaVerEventoFiesta(usuario, sistema, "Charla");
                        f.Show();
                        this.Dispose();
                        this.Hide();
                    }
                }
            }
        }

        private void Amigos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipo == "Fiesta")
            {
                if (Amigos.Columns[e.ColumnIndex].Name == "VerAmigos")
                {
                    int valor = (int)Amigos.CurrentRow.Cells["VerAmigos"].Value;
                    foreach (EventoFiesta item in this.EventosOrdenados(sistema.Fiestas))
                    {
                        if (item.Number == valor)
                        {
                            item.MostrarAmigosAsistentes(usuario);
                        }
                    }
                }
            }
            if (tipo == "Concierto")
            {
                if (Amigos.Columns[e.ColumnIndex].Name == "VerAmigos")
                {
                    int valor = (int)Amigos.CurrentRow.Cells["VerAmigos"].Value;
                    foreach (EventoConcierto item in this.EventosOrdenados(sistema.Conciertos))
                    {
                        if (item.Number == valor)
                        {
                            item.MostrarAmigosAsistentes(usuario);
                        }
                    }
                }
            }
            if (tipo == "Charla")
            {
                if (Amigos.Columns[e.ColumnIndex].Name == "VerAmigos")
                {
                    int valor = (int)Amigos.CurrentRow.Cells["VerAmigos"].Value;
                    foreach (EventoCharla item in this.EventosOrdenados(sistema.Charlas))
                    {
                        if (item.Number == valor)
                        {
                            item.MostrarAmigosAsistentes(usuario);
                        }
                    }
                }
            }
            if (tipo == "Torneo")
            {
                if (Amigos.Columns[e.ColumnIndex].Name == "VerAmigos")
                {
                    int valor = (int)Amigos.CurrentRow.Cells["VerAmigos"].Value;
                    foreach (EventoDeportivoTorneo item in this.EventosOrdenados(sistema.Torneos))
                    {
                        if (item.Number == valor)
                        {
                            item.MostrarAmigosAsistentes(usuario);
                        }
                    }
                }
            }
            if (tipo == "Carrera")
            {
                if (Amigos.Columns[e.ColumnIndex].Name == "VerAmigos")
                {
                    int valor = (int)Amigos.CurrentRow.Cells["VerAmigos"].Value;
                    foreach (EventoDeportivoCarrera item in this.EventosOrdenados(sistema.Carreras))
                    {
                        if (item.Number == valor)
                        {
                            item.MostrarAmigosAsistentes(usuario);
                        }
                    }
                }
            }
            if (tipo == "Funcion")
            {
                if (Amigos.Columns[e.ColumnIndex].Name == "VerAmigos")
                {
                    int valor = (int)Amigos.CurrentRow.Cells["VerAmigos"].Value;
                    foreach (EventoFuncion item in this.EventosOrdenados(sistema.Funciones))
                    {
                        if (item.Number == valor)
                        {
                            item.MostrarAmigosAsistentes(usuario);
                        }
                    }
                }
            }
        }
    }
}
