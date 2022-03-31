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
        private string _tema;
        private DateTime _hora;
        private DateTime _horafin;
        private string _profesion;
        public string Tema { get=>_tema; set=>_tema=value; }
        public DateTime Hora { get=>_hora; set=>_hora=value; }
        public DateTime HoraFin { get=>_horafin; set=>_horafin=value; }
        public string Profesion { get => _profesion; set => _profesion = value; }

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
