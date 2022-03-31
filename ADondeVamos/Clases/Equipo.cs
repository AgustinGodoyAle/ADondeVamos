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
        private string _nombre;
        private List<Jugador> _jugadores;
        public string Nombre { get=>_nombre; set=>_nombre=value; }
        public List<Jugador> Jugadores { get=>_jugadores; set=>_jugadores=value; }
        public Equipo(string nombre)
        {
            Nombre = nombre;
        }
        public void AsociarJugadores(List<Jugador> jugador)
        {
            Jugadores = jugador;
        }
    }
}
