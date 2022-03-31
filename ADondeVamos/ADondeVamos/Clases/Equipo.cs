using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos.Clases
{
    [Serializable]
    public class Equipo
    {
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public Equipo(string nombre)
        {
            Nombre = nombre;
            Jugadores = new List<Jugador>();
        }
        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }
    }
}
