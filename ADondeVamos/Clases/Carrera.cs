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
        private double _distancia;
        private string _categoria;
        private DateTime _horario;
        public double Distancia
        { 
            get => _distancia; 
            set => _distancia = value; 
        }
        public string Categoria
        { get=>_categoria; 
            set=>_categoria=value; }
        public DateTime Horario 
        { get=>_horario; set=>_horario=value; }

        public Carrera(double distancia,string categoria,DateTime horario)
        {
            this.Distancia = distancia;
            this.Categoria = categoria;
            this.Horario = horario;
        }

    }
}
