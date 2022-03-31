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
        public int Posicion { get; set; }

        public Jugador(string nombre, string apellido, string contacto, int posi)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = contacto;
            Posicion = posi;
        }

    }
}
