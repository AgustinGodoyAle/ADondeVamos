using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class EventoDeportivoTorneo : Evento
    {
        private Torneo _torneo;
        public Torneo torneo { get=>_torneo; set=>_torneo=value; }

        public EventoDeportivoTorneo(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }

        public new void MostrarDatos()
        {
            MessageBox.Show($"Nombre: {this.Nombre}\nFecha Inicio: {this.Fecha}\nFecha Fin: {FechaFin}\nPrecio: ${this.Precio}\nDescripción: {this.Descripcion}\nUsuario creador del evento: {Creador.User} - {Creador.Nombre} {Creador.Apellido}\n");
            torneo.MostrarDatos();
            if (ubicacion != null)
            {
                MapaDelEvento f = new MapaDelEvento(ubicacion);
                f.Show();
            }
        }
        public void AgregarTorneo(Torneo torneo1)
        {
            this.torneo = torneo1;

        }
    }
}
