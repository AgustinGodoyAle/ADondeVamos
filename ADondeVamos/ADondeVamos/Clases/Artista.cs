using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class Artista :Persona 
    {
        public string Categoria { get; set; }
        
        public Artista(string nombre,string apellido, string categoria)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Categoria = categoria;
            
        }
    }
}
