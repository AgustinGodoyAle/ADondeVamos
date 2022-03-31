using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos.Clases
{
    public class GrupoMarchante
    {
        public string Tipo { get; set; }
        public int CantidadMarchantes { get; set; }
        public string Tema { get; set; }
        public GrupoMarchante(string tipo, int canti, string tema)
        {
            Tipo = tipo;
            CantidadMarchantes = canti;
            Tema = tema;
        }
    }
}
