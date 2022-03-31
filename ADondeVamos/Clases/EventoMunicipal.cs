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
    public class EventoMunicipal : Evento
    {
        public List<Desfile> Desfiles;
        public List<Inauguracion> Inauguraciones ;

        public EventoMunicipal(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }
        

        public void AgregarInauguracion(List<Inauguracion> inauguracion)
        {
           this.Inauguraciones=inauguracion;
        }
        public void AgregarDesfile(List<Desfile> desfile)
        {
            this.Desfiles=desfile;
        }

        public new void MostrarDatos()
        {
            MessageBox.Show($"Nombre: {this.Nombre}\nFecha: {this.Fecha}\nPrecio: ${this.Precio}\nDescripción: {this.Descripcion}");
            MostrarDesfiles();
            MostrarInauguraciones();
            MapaDelEvento f = new MapaDelEvento(ubicacion);
            f.Show();
        }
        public void MostrarDesfiles()
        {
            string lista = "";
            foreach (Desfile item in Desfiles)
            {
                lista = lista + "\n" + "Desfile de " + item.Nombre;
            }
            MessageBox.Show($"DESFILES EN EL ACTO: {lista}");
        }
        public void MostrarInauguraciones()
        {
            string lista = "";
            foreach (Inauguracion item in Inauguraciones)
            {
                lista = lista + "\n" + "Inauguracion de " + item.Nombre;
            }
            MessageBox.Show($"INAUGURACIONES EN EL ACTO: {lista}");
        }

    }
}
