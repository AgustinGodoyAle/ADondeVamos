using ADondeVamos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos
{
    [Serializable]
    public class Sistema
    {
        public List<Usuario> Usuarios;
        public List<EventoFiesta> Fiestas;
        public List<EventoDeportivoTorneo> Torneos;
        public List<EventoDeportivoCarrera> Carreras;
        public List<EventoMunicipal> Actos;
        public List<EventoConcierto> Conciertos;
        public List<EventoCharla> Charlas;
        public List<EventoConvencion> Convenciones;
        public List<EventoFuncion> Funciones;
        //List<List<Artista>> ListasArtistas;
        //List<Torneo> Torneos;
        //List<Partido> Partidos;
        //List<Carrera> Carreras;
        //public Ranking RankingFiesta;
        //public Ranking RankingDeportivo;
        //public Ranking RankingMunicipal;
        //public Ranking RankingConcierto;
        //public Ranking RankingArte;

        public Sistema()
        {
            Usuarios = new List<Usuario>();
            Fiestas = new List<EventoFiesta>();
            Torneos = new List<EventoDeportivoTorneo>();
            Carreras = new List<EventoDeportivoCarrera>();
            Actos = new List<EventoMunicipal>();
            Conciertos = new List<EventoConcierto>();
            Charlas = new List<EventoCharla>();
            Convenciones = new List<EventoConvencion>();
            Funciones = new List<EventoFuncion>();
            //RankingFiesta = new Ranking();
            //RankingDeportivo = new Ranking();
            //RankingMunicipal = new Ranking();
            //RankingConcierto = new Ranking();
            //RankingArte = new Ranking();
        }

        public List<Evento> EventosOrderByDate()
        {
            List<Evento> Eventos = new List<Evento>();
            foreach(EventoFiesta item in Fiestas)
            {
                Eventos.Add(item);
            }
            foreach (EventoFuncion item in Funciones)
            {
                Eventos.Add(item);
            }
            foreach (EventoDeportivoTorneo item in Torneos)
            {
                Eventos.Add(item);
            }
            foreach (EventoDeportivoCarrera item in Carreras)
            {
                Eventos.Add(item);
            }
            foreach (EventoConcierto item in Conciertos)
            {
                Eventos.Add(item);
            }
            foreach (EventoCharla item in Charlas)
            {
                Eventos.Add(item);
            }
            foreach (EventoConvencion item in Convenciones)
            {
                Eventos.Add(item);
            }
            foreach (EventoMunicipal item in Actos)
            {
                Eventos.Add(item);
            }

            Eventos = Eventos.OrderBy(evento1 => evento1.Fecha).ToList();
            return Eventos;
        }
        //public void EliminarEventosDeUsuarios(int index, string tipo)
        //{
        //    foreach(Usuario usuario in Usuarios)
        //    {
        //        if(tipo=="Fiesta")
        //        {
        //            foreach(EventoFiesta fiesta in usuario.Fiestas)
        //            {
        //                if(usuario.Fiestas.IndexOf(fiesta)==index)
        //                {
        //                    usuario.Fiestas.RemoveAt(index);
        //                }
        //            }
        //        }
        //        if(tipo=="Funcion")
        //        {
        //            foreach (EventoFuncion fiesta in usuario.Funciones)
        //            {
        //                if (usuario.Funciones.IndexOf(fiesta) == index)
        //                {
        //                    usuario.Funciones.RemoveAt(index);
        //                }
        //            }
        //        }
        //        if(tipo=="Charla")
        //        {
        //            foreach (EventoCharla fiesta in usuario.Charlas)
        //            {
        //                if (usuario.Charlas.IndexOf(fiesta) == index)
        //                {
        //                    usuario.Charlas.RemoveAt(index);
        //                }
        //            }
        //        }
        //        if(tipo=="Concierto")
        //        {
        //            foreach (EventoConcierto fiesta in usuario.Conciertos)
        //            {
        //                if (usuario.Conciertos.IndexOf(fiesta) == index)
        //                {
        //                    usuario.Conciertos.RemoveAt(index);
        //                }
        //            }
        //        }
        //        if(tipo=="Carrera")
        //        {
        //            foreach (EventoDeportivoCarrera fiesta in usuario.Carreras)
        //            {
        //                if (usuario.Carreras.IndexOf(fiesta) == index)
        //                {
        //                    usuario.Carreras.RemoveAt(index);
        //                }
        //            }
        //        }
        //        if(tipo=="Torneo")
        //        {
        //            foreach (EventoDeportivoTorneo fiesta in usuario.Torneos)
        //            {
        //                if (usuario.Torneos.IndexOf(fiesta) == index)
        //                {
        //                    usuario.Torneos.RemoveAt(index);
        //                }
        //            }
        //        }
        //        if(tipo=="Acto")
        //        {
        //            foreach (EventoMunicipal fiesta in usuario.Actos)
        //            {
        //                if (usuario.Actos.IndexOf(fiesta) == index)
        //                {
        //                    usuario.Actos.RemoveAt(index);
        //                }
        //            }
        //        }
        //        if(tipo=="Convencion")
        //        {
        //            foreach (EventoConvencion fiesta in usuario.Convenciones)
        //            {
        //                if (usuario.Convenciones.IndexOf(fiesta) == index)
        //                {
        //                    usuario.Convenciones.RemoveAt(index);
        //                }
        //            }
        //        }
        //    }
        //}
        public void EliminarEvento(EventoFiesta evento)
        {
            int bande = 0;
            foreach (Evento item in Fiestas)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                Fiestas.Remove(evento);
            }
        }
        public void EliminarEvento(EventoCharla evento)
        {
            int bande = 0;
            foreach (Evento item in Charlas)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                Charlas.Remove(evento);
            }
        }
        public void EliminarEvento(EventoConcierto evento)
        {
            int bande = 0;
            foreach (Evento item in Conciertos)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                Conciertos.Remove(evento);
            }
        }
        public void EliminarEvento(EventoConvencion evento)
        {
            int bande = 0;
            foreach (Evento item in Convenciones)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                Convenciones.Remove(evento);
            }
        }
        public void EliminarEvento(EventoDeportivoCarrera evento)
        {
            int bande = 0;
            foreach (Evento item in Carreras)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                Carreras.Remove(evento);
            }
        }
        public void EliminarEvento(EventoDeportivoTorneo evento)
        {
            int bande = 0;
            foreach (Evento item in Torneos)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                Torneos.Remove(evento);
            }
        }
        public void EliminarEvento(EventoFuncion evento)
        {
            int bande = 0;
            foreach (Evento item in Funciones)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                Funciones.Remove(evento);
            }
        }
        public void EliminarEvento(EventoMunicipal evento)
        {
            int bande = 0;
            foreach (Evento item in Actos)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                Actos.Remove(evento);
            }
        }

        //Guardar
        //{
        //    Sistema sistema = new Sistema();

        //    sistema.Usuarios = Usuarios;
        //    sistema.Fiestas = Fiestas;
        //    sistema.Deportivos = Deportivos;
        //    sistema.Municipales = Municipales;
        //    sistema.Conciertos = Conciertos;
        //    sistema.Artes = Artes;
        //    sistema.RankingFiesta = RankingFiesta;
        //    sistema.RankingDeportivo = RankingDeportivo;
        //    sistema.RankingMunicipal = RankingMunicipal;
        //    sistema.RankingConcierto = RankingConcierto;
        //    sistema.RankingArte = RankingArte;

        //    var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
        //    formatter.Serialize(file, sistema);
        //    file.Close();
        //}

        //Abrir
        //{
        //    var file = new FileStream("c:\\temp\\sistema.dat", FileMode.Open);
        //    var formatter = new BinaryFormatter();
        //    Sistema sistema = formatter.Deserialize(file) as Sistema;
        //
        //Es al revés lo de abajo
        //    sistema.Usuarios = Usuarios;
        //    sistema.Fiestas = Fiestas;
        //    sistema.Deportivos = Deportivos;
        //    sistema.Municipales = Municipales;
        //    sistema.Conciertos = Conciertos;
        //    sistema.Artes = Artes;
        //    sistema.RankingFiesta = RankingFiesta;
        //    sistema.RankingDeportivo = RankingDeportivo;
        //    sistema.RankingMunicipal = RankingMunicipal;
        //    sistema.RankingConcierto = RankingConcierto;
        //    sistema.RankingArte = RankingArte;
        //}

        //arriba de las clases
        //[Serializable]
        //using System.IO;
        //using System.Runtime.Seriazalition
    }
}
