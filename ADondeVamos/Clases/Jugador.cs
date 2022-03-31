using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos.Clases
{
    [Serializable]
    public class Jugador: Persona
    {
        private int _posicion;
        public int Posicion { get=>_posicion; set=>_posicion=value; }

        public Jugador(string nombre, string apellido, string contacto, int posi)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = contacto;
            Posicion = posi;
        }

    }
}
