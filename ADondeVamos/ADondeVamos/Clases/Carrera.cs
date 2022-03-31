using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class Carrera
    {
        public double Distancia { get; set; }
        public string Categoria { get; set; }
        public DateTime Horario { get; set; }

        public Carrera(double distancia,string categoria,DateTime horario)
        {
            this.Distancia = distancia;
            this.Categoria = categoria;
            this.Horario = horario;
        }
    }
}
