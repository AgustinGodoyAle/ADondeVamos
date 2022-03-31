using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos.Clases
{
    [Serializable]
    public class Inauguracion
    {
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public List<Charla> Charlas { get; set; }
        public Inauguracion(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarCharla(Charla charla)
        {
            Charlas.Add(charla);
        }


    }
}
