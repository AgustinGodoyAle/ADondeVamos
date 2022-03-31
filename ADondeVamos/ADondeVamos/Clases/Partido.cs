using ADondeVamos.Clases;
using System;

namespace ADondeVamos
{
    [Serializable]
    public class Partido
    {
        public Equipo equipo1 { get; set; }
        public Equipo equipo2 { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public Partido(string equip1, string equip2, DateTime inicio, DateTime final)
        {
            equipo1 = new Equipo(equip1);
            equipo2 = new Equipo(equip2);
            FechaInicio = inicio.ToShortDateString()+"-"+inicio.ToShortTimeString();
            FechaInicio = final.ToShortDateString() + "-" + final.ToShortTimeString();
        }
    }
}
