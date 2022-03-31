using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using ADondeVamos.Clases;

namespace ADondeVamos
{
    [Serializable]
    public class Usuario : Persona
    {
        public string User { get; set; }
        public string Contra { get; set; }
        //Eventos creados por usuario
        public List<EventoFiesta> Fiestas = new List<EventoFiesta>();
        public List<EventoCharla> Charlas = new List<EventoCharla>();
        public List<EventoConcierto> Conciertos = new List<EventoConcierto>();
        public List<EventoConvencion> Convenciones = new List<EventoConvencion>();
        public List<EventoDeportivoCarrera> Carreras = new List<EventoDeportivoCarrera>();
        public List<EventoDeportivoTorneo> Torneos = new List<EventoDeportivoTorneo>();
        public List<EventoFuncion> Funciones = new List<EventoFuncion>();
        public List<EventoMunicipal> Actos = new List<EventoMunicipal>();
        public List<Usuario> Amigos = new List<Usuario>();
        //Eventos asistidos
        public List<EventoFiesta> EAsistidosFies = new List<EventoFiesta>();
        public List<EventoCharla> EAsistidosChar = new List<EventoCharla>();
        public List<EventoConcierto> EAsistidosConc = new List<EventoConcierto>();
        public List<EventoConvencion> EAsistidosConv = new List<EventoConvencion>();
        public List<EventoDeportivoCarrera> EAsistidosCarr = new List<EventoDeportivoCarrera>();
        public List<EventoDeportivoTorneo> EAsistidosTorn = new List<EventoDeportivoTorneo>();
        public List<EventoFuncion> EAsistidosFunc = new List<EventoFuncion>();
        public List<EventoMunicipal> EAsistidosMuni = new List<EventoMunicipal>();

        public Usuario(string nombre, string apellido, string user, string contra)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.User = user;
            this.Contra = contra;
        }

        public void MostrarFiesta()
        {
            foreach(EventoFiesta item in Fiestas)
            {
                item.MostrarDatos();
            }
        }
        public void MostrarConcierto()
        {
            foreach(EventoConcierto item in Conciertos)
            {
                item.MostrarDatos();
            }
        }
        public void AsistirEvento(EventoFiesta evento)
        {
            int bande = 1;
            foreach(Evento item in EAsistidosFies)
            {
                if(item==evento)
                {
                    bande = 0;
                }
            }
            if(bande==1)
                EAsistidosFies.Add(evento);
        }
        public void AsistirEvento(EventoFuncion evento)
        {
            int bande = 1;
            foreach (Evento item in EAsistidosFunc)
            {
                if (item == evento)
                {
                    bande = 0;
                }
            }
            if (bande == 1)
                EAsistidosFunc.Add(evento);
        }
        public void AsistirEvento(EventoConcierto evento)
        {
            int bande = 1;
            foreach (Evento item in EAsistidosConc)
            {
                if (item == evento)
                {
                    bande = 0;
                }
            }
            if (bande == 1)
                EAsistidosConc.Add(evento);
        }
        public void AsistirEvento(EventoCharla evento)
        {
            int bande = 1;
            foreach (Evento item in EAsistidosChar)
            {
                if (item == evento)
                {
                    bande = 0;
                }
            }
            if (bande == 1)
                EAsistidosChar.Add(evento);
        }
        public void AsistirEvento(EventoConvencion evento)
        {
            int bande = 1;
            foreach (Evento item in EAsistidosConv)
            {
                if (item == evento)
                {
                    bande = 0;
                }
            }
            if (bande == 1)
                EAsistidosConv.Add(evento);
        }
        public void AsistirEvento(EventoDeportivoCarrera evento)
        {
            int bande = 1;
            foreach (Evento item in EAsistidosCarr)
            {
                if (item == evento)
                {
                    bande = 0;
                }
            }
            if (bande == 1)
                EAsistidosCarr.Add(evento);
        }
        public void AsistirEvento(EventoDeportivoTorneo evento)
        {
            int bande = 1;
            foreach (Evento item in EAsistidosTorn)
            {
                if (item == evento)
                {
                    bande = 0;
                }
            }
            if (bande == 1)
                EAsistidosTorn.Add(evento);
        }
        public void AsistirEvento(EventoMunicipal evento)
        {
            int bande = 1;
            foreach (Evento item in EAsistidosMuni)
            {
                if (item == evento)
                {
                    bande = 0;
                }
            }
            if (bande == 1)
                EAsistidosMuni.Add(evento);
        }
        public void NoAsistirEvento(EventoFiesta evento)
        {
            int bande = 0;
            foreach (Evento item in EAsistidosFies)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                EAsistidosFies.Remove(evento);
            }
        }
        public void NoAsistirEvento(EventoFuncion evento)
        {
            int bande = 0;
            foreach (Evento item in EAsistidosFunc)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                EAsistidosFunc.Remove(evento);
            }
        }
        public void NoAsistirEvento(EventoCharla evento)
        {
            int bande = 0;
            foreach (Evento item in EAsistidosChar)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                EAsistidosChar.Remove(evento);
            }
        }
        public void NoAsistirEvento(EventoConcierto evento)
        {
            int bande = 0;
            foreach (Evento item in EAsistidosConc)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                EAsistidosConc.Remove(evento);
            }
        }
        public void NoAsistirEvento(EventoConvencion evento)
        {
            int bande = 0;
            foreach (Evento item in EAsistidosConv)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                EAsistidosConv.Remove(evento);
            }
        }
        public void NoAsistirEvento(EventoDeportivoCarrera evento)
        {
            int bande = 0;
            foreach (Evento item in EAsistidosCarr)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                EAsistidosCarr.Remove(evento);
            }
        }
        public void NoAsistirEvento(EventoDeportivoTorneo evento)
        {
            int bande = 0;
            foreach (Evento item in EAsistidosTorn)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                EAsistidosTorn.Remove(evento);
            }
        }
        public void NoAsistirEvento(EventoMunicipal evento)
        {
            int bande = 0;
            foreach (Evento item in EAsistidosMuni)
            {
                if (item == evento)
                {
                    bande = 1;
                }
            }
            if (bande == 1)
            {
                EAsistidosMuni.Remove(evento);
            }
        }
        public void EliminarEvento(EventoFiesta evento)
        {
            int bande = 0;
            foreach(Evento item in Fiestas)
            {
                if(item==evento)
                {
                    bande = 1;
                }
            }
            if(bande==1)
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

        public void AgregarEvento(EventoFiesta fiesta)
        {
            Fiestas.Add(fiesta);
        }
        public void AgregarEvento(EventoCharla charla)
        {
            Charlas.Add(charla);
        }
        public void AgregarEvento(EventoConcierto concierto)
        {
            Conciertos.Add(concierto);
        }
        public void AgregarEvento(EventoConvencion convencion)
        {
            Convenciones.Add(convencion);
        }
        public void AgregarEvento(EventoDeportivoCarrera carrera)
        {
            Carreras.Add(carrera);
        }
        public void AgregarEvento(EventoDeportivoTorneo torneo)
        {
            Torneos.Add(torneo);
        }
        public void AgregarEvento(EventoFuncion funcion)
        {
            Funciones.Add(funcion);
        }
        public void AgregarEvento(EventoMunicipal acto)
        {
            Actos.Add(acto);
        }
        public void AgregarAmigo(Usuario amigo)
        {
            Amigos.Add(amigo);
            
        }
    }
}
