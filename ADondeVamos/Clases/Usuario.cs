using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using ADondeVamos.Clases;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace ADondeVamos
{
    [Serializable]
    public class Usuario : Persona
    {
        private string _user;
        private string _contra;
        private string _numeroamigo;
        private List<Usuario> _amigos;
        public string User { get => _user; set => _user = value; }
        public string Contra { get => _contra; set => _contra = value; }
        public string NumAmigo
        {
            get => _numeroamigo;
            set => _numeroamigo = value;
        }
        public List<Usuario> Amigos { get => _amigos; set => _amigos = value; }
        //Eventos creados por usuario
        private List<EventoFiesta> _fiestas = new List<EventoFiesta>();
        private List<EventoCharla> _charlas = new List<EventoCharla>();
        private List<EventoConcierto> _conciertos = new List<EventoConcierto>();
        private List<EventoConvencion> _convenciones = new List<EventoConvencion>();
        private List<EventoDeportivoCarrera> _carreras = new List<EventoDeportivoCarrera>();
        private List<EventoDeportivoTorneo> _torneos = new List<EventoDeportivoTorneo>();
        private List<EventoFuncion> _funciones = new List<EventoFuncion>();
        private List<EventoMunicipal> _municipales = new List<EventoMunicipal>();
        public List<EventoFiesta> Fiestas { get => _fiestas; set => _fiestas = value; }
        public List<EventoCharla> Charlas { get => _charlas; set => _charlas = value; }
        public List<EventoConcierto> Conciertos { get => _conciertos; set => _conciertos = value; }
        public List<EventoConvencion> Convenciones { get => _convenciones; set => _convenciones = value; }
        public List<EventoDeportivoCarrera> Carreras { get => _carreras; set => _carreras = value; }
        public List<EventoDeportivoTorneo> Torneos { get => _torneos; set => _torneos = value; }
        public List<EventoFuncion> Funciones { get => _funciones; set => _funciones = value; }
        public List<EventoMunicipal> Actos { get => _municipales; set => _municipales = value; }

        //Eventos asistidos
        private List<EventoFiesta> _afiestas = new List<EventoFiesta>();
        private List<EventoCharla> _acharlas = new List<EventoCharla>();
        private List<EventoConcierto> _aconciertos = new List<EventoConcierto>();
        private List<EventoConvencion> _aconvenciones = new List<EventoConvencion>();
        private List<EventoDeportivoCarrera> _acarreras = new List<EventoDeportivoCarrera>();
        private List<EventoDeportivoTorneo> _atorneos = new List<EventoDeportivoTorneo>();
        private List<EventoFuncion> _afunciones = new List<EventoFuncion>();
        private List<EventoMunicipal> _amunicipales = new List<EventoMunicipal>();
        public List<EventoFiesta> EAsistidosFies { get => _afiestas; set => _afiestas = value; }
        public List<EventoCharla> EAsistidosChar { get => _acharlas; set => _acharlas = value; }
        public List<EventoConcierto> EAsistidosConc { get => _aconciertos; set => _aconciertos = value; }
        public List<EventoConvencion> EAsistidosConv { get => _aconvenciones; set => _aconvenciones = value; }
        public List<EventoDeportivoCarrera> EAsistidosCarr { get => _acarreras; set => _acarreras = value; }
        public List<EventoDeportivoTorneo> EAsistidosTorn { get => _atorneos; set => _atorneos = value; }
        public List<EventoFuncion> EAsistidosFunc { get => _afunciones; set => _afunciones = value; }
        public List<EventoMunicipal> EAsistidosMuni { get => _amunicipales; set => _amunicipales = value; }

        public Usuario(string nombre, string apellido, string user, string contra)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.User = user;
            this.Contra = contra;
        }

        public void ObtenerMiNumAmigo(Sistema sistema)
        {
            int bande = 1;
            sistema.Usuarios.Remove(this);
            while (bande != 0)
            {
                Random rnd = new Random();
                string number = Convert.ToString(rnd.Next(10000, 99999));
                bande = 0;
                foreach (Usuario item in sistema.Usuarios)
                {
                    if (number == item.NumAmigo)
                    {
                        bande = 1;
                    }
                }
                if (bande == 0)
                {
                    this.NumAmigo = number;
                    sistema.Usuarios.Add(this);
                    var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(file, sistema);
                    file.Close();
                    MessageBox.Show($"Su nuevo número amigo es: {number}", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        public void MostrarNumAmigo()
        {
            MessageBox.Show($"Su código amigo es: {NumAmigo}", "CÓDIGO AMIGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //public void MostrarFiesta()
        //{
        //    foreach(EventoFiesta item in Fiestas)
        //    {
        //        item.MostrarDatos();
        //    }
        //}
        //public void MostrarConcierto()
        //{
        //    foreach(EventoConcierto item in Conciertos)
        //    {
        //        item.MostrarDatos();
        //    }
        //}
        public void AsistirEvento(EventoFiesta evento)
        {
            int bande = 1;
            foreach (Evento item in EAsistidosFies)
            {
                if (item == evento)
                {
                    bande = 0;
                }
            }
            if (bande == 1)
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
        public void AnadirAmigo(Sistema sistema, string number, string nombreamigo)
        {
            int bande = 0; bool bande2 = true;
            foreach (Usuario item in sistema.Usuarios)
            {
                if (Amigos == null)
                    Amigos = new List<Usuario>();

                foreach(Usuario item2 in Amigos)
                {
                    if (item.User == item2.User)
                        bande2 = false;
                }

                if (item.NumAmigo == number && item.User == nombreamigo && item.User != this.User && bande2==true)
                {
                    if (item.Amigos == null)
                        item.Amigos = new List<Usuario>();

                    item.Amigos.Add(this);
                    Amigos.Add(item);
                    bande = 1;
                }
            }
            if (bande != 1)
            {
                MessageBox.Show("Lo sentimos...\nEl número amigo y/o nombre de usuario no coinciden con ningún usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
            }
            else
            {
                MessageBox.Show($"¡FELICIDADES!\nTú y {nombreamigo} ya son amigos en ¿A DÓNDE VAMOS?\nPodrás ver si {nombreamigo} asiste a algún evento y viceversa", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public int EliminarAmigo(string examigo, Sistema sistema)
        {
            List<Usuario> amigues = Amigos;
            int bande = 0;
            Usuario usuario2; Usuario usuario1;
            usuario1 = this;
            foreach(Usuario item in amigues)
            {
                if(examigo==item.User)
                {
                    usuario2 = item;
                    sistema.Usuarios.Remove(usuario1);
                    sistema.Usuarios.Remove(usuario2);
                    usuario1.Amigos.Remove(usuario2);
                    usuario2.Amigos.Remove(usuario1);
                    sistema.Usuarios.Add(usuario2);
                    sistema.Usuarios.Add(usuario1);
                    bande = 1;
                    return bande;
                }
            }
            return bande;
            
        }
    }
}
