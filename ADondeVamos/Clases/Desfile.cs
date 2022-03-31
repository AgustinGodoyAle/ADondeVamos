using ADondeVamos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos.Clases
{
    [Serializable]
    public class Desfile
    {
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public List<GrupoMarchante> GruposMarchantes = new List<GrupoMarchante>();
        public Desfile(string nombre)
        {
            Nombre = nombre;
        }
    }

}
