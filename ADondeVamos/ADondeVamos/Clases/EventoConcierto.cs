using ADondeVamos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class EventoConcierto : Evento
    {
        public List<Banda> Bandas = new List<Banda>();


        public EventoConcierto(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }

        public void AgregarBanda(Banda a)
        {
            this.Bandas.Add(a);
        }
        public new void MostrarDatos()
        {
            MessageBox.Show($"Nombre: {this.Nombre}\nFecha Inicio: {Fecha}\nFecha Fin: {FechaFin}\nPrecio: ${Precio}\nDescripción: {Descripcion}");
            MostrarBandas();
            MapaDelEvento f = new MapaDelEvento(ubicacion);
            f.Show();
        }

        public void MostrarBandas()
        {
            foreach(Banda item in Bandas)
            {
                item.MostrarBanda();
            }
        }
    }
}
