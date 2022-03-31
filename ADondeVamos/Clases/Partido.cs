using ADondeVamos.Clases;
using System;

namespace ADondeVamos
{
    [Serializable]
    public class Partido
    {
        private Equipo _equipo1;
        private Equipo _equipo2;
        private string _inicio;
        private string _final;
        public Equipo Equipo1 { get=>_equipo1; set=>_equipo1=value; }
        public Equipo Equipo2 { get=>_equipo2; set=>_equipo2=value; }
        public string FechaInicio { get=>_inicio; set=>_inicio=value; }
        public string FechaFinal { get=>_final; set=>_final=value; }
        public Partido(string equip1, string equip2, DateTime inicio, DateTime final)
        {
            Equipo1 = new Equipo(equip1);
            Equipo2 = new Equipo(equip2);
            FechaInicio = inicio.ToShortDateString()+"-"+inicio.ToShortTimeString();
            FechaFinal = final.ToShortDateString() + "-" + final.ToShortTimeString();
        }
    }
}
