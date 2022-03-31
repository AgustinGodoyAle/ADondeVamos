using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADondeVamos
{
    [Serializable]
    public class Convencion
    {
        public string Tema { get; set; }
        public string Descripcion { get; set; }
        public List<Organizador> Organizadores { get; set; }

        public Convencion(string tema, string descripcion, Organizador organizador1)
        {
            Tema = tema;
            Descripcion = descripcion;
        }

        public void AgregarOrganizador(Organizador organizador)
        {
            Organizadores.Add(organizador);
        }

    }
}
