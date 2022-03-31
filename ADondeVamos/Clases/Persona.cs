using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos
{
    [Serializable]
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _correo;
        public string Nombre { get=>_nombre; set=>_nombre=value; }
        public string Apellido { get=>_apellido; set=>_apellido=value; }
        public string Correo { get=>_correo; set=>_correo=value; }//O contacto

        
    }
}
