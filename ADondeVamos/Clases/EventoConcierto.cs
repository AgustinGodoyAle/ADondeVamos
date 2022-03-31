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
        public List<Banda> Bandas;


        public EventoConcierto(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }

        public void AsociarBandas(List<Banda> a)
        {
            this.Bandas=a;
        }
        public new void MostrarDatos()
        {
            MessageBox.Show($"Nombre: {this.Nombre}\nFecha Inicio: {Fecha}\nFecha Fin: {FechaFin}\nPrecio: ${Precio}\nDescripción: {Descripcion}\nUsuario creador del evento: {Creador.User} - {Creador.Nombre} {Creador.Apellido}\n");
            MostrarBandas();
            if (ubicacion != null)
            {
                MapaDelEvento f = new MapaDelEvento(ubicacion);
                f.Show();
            }
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
