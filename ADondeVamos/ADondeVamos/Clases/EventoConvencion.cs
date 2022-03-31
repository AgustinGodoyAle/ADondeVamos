using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class EventoConvencion : Evento
    {
        public Convencion convencion { get; set; }

        public EventoConvencion(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }


        public void AgregarConvencion(Convencion convension1)
        {
            convencion = convension1;
        }

    }
}
