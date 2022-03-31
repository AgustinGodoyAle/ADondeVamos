using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class Charla
    {
        public string TemadeCharla { get; set; }
        public List<Orador> Oradores = new List<Orador>(); //objeto Orador, Lista de oradores
        public DateTime Horario { get; set; }
        public DateTime HorarioFin { get; set; }

        public Charla(string tema, DateTime horario,DateTime horariofin)
        {
            TemadeCharla = tema;
            Horario = horario;
            HorarioFin = horario;
        }

        public void AgregarOrador(Orador orador)
        {
            Oradores.Add(orador);
        }

        public void MostrarDatos()
        {

        }
    }
}
