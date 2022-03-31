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
        private List<Carrera> _carreras = new List<Carrera>();
        public List<Carrera> Carreras { get => _carreras; set => _carreras = value; }

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
            MessageBox.Show($"Nombre: {this.Nombre}\nFecha Inicio: {this.Fecha}\nFecha Final: {this.FechaFin}\nPrecio: ${this.Precio}\nDescripción: {this.Descripcion}\nUsuario creador del evento: {Creador.User} - {Creador.Nombre} {Creador.Apellido}\n");
            MostrarCarrera();
            if (ubicacion != null)
            {
                MapaDelEvento f = new MapaDelEvento(ubicacion);
                f.Show();
            }
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
        public bool ValidarDatos(string distancia, DateTime inicio)
        {
            bool bande = false;
            string mensaje = "";
            try
            {
                if (Convert.ToDouble(distancia) > 0)
                {
                    if (DateTime.Compare(inicio, this.FechaFin) < 0 && DateTime.Compare(inicio, this.Fecha) >= 0)
                    {
                        bande = true;
                    }
                }
                else
                {
                    mensaje += "Debe ingresar una distancia en números reales positivos mayores a 0\n";
                }
            }
            catch
            {
                mensaje += "Debe ingresar una distancia en números reales positivos mayores a 0\n";
            }
            if (DateTime.Compare(inicio, this.FechaFin) >= 0 || DateTime.Compare(inicio, this.Fecha) < 0)
            {
                mensaje += "La fecha de inicio de la Carrera debe ser menor a la fecha final del Evento de Carreras\n";
                mensaje += "Y la fecha de inicio de la Carrera debe ser mayor o igual a la fecha de inicio del Evento de Carreras\n";
            }
            if (bande == false)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;
        }

    }

    
    
}
