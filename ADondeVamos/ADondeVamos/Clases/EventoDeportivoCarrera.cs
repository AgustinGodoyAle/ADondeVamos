using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{  
    [Serializable]
    public class EventoDeportivoCarrera : Evento
    {
        
        public List<Carrera> Carreras = new List<Carrera>();

        public EventoDeportivoCarrera(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }

        public void AgregarCarrera(Carrera carrera)
        {
            Carreras.Add(carrera);

        }

        public new void MostrarDatos()
        {
            MessageBox.Show($"Nombre: {this.Nombre}\nFecha Inicio: {this.Fecha}\nFecha Final: {this.FechaFin}\nPrecio: ${this.Precio}\nDescripción: {this.Descripcion}");
            MostrarCarrera();
            MapaDelEvento f = new MapaDelEvento(ubicacion);
            f.Show();
        }
        public void MostrarCarrera()
        {
            string lista = "";
            foreach (Carrera item in Carreras)
            {
                lista = lista + "\n" + "Categoría: " + item.Categoria + " - Distancia: " + item.Distancia+" km"+"\nFecha Arranque: "+item.Horario;
            }
            MessageBox.Show($"Carreras: {lista}");
        }

    }

    
    
}
