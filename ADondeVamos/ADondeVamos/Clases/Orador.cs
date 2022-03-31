using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class Orador:Persona
    {
        public string Tema { get; set; }
        public DateTime Hora { get; set; }
        public DateTime HoraFin { get; set; }

        public Orador(string nombre, string apellido, string tema, DateTime hora, DateTime horafin)
        {
            Nombre = nombre;
            Apellido = apellido;
            Tema = tema;
            Hora = hora;
            HoraFin= horafin;
        }
    }
}
