using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos
{
    [Serializable]
    public class Organizador:Persona
    {
        public string Descripcion { get; set; }

        public Organizador(string nombre,string apellido, string correo,string descripcion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Descripcion = descripcion;
        }
    }
}
