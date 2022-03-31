using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class EventoCharla : Evento
    {
        public List<Charla> Charlas = new List<Charla>();

        public EventoCharla(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }

        public void AgregarCharla(Charla charla)
        {
            Charlas.Add(charla);
        }

        public new void MostrarDatos()
        {
            string lista="";
            foreach(Charla item in Charlas)
            {
                lista = lista + $"Tema de Charla: {item.TemadeCharla}\nHorario Inicio: {item.Horario}\nHorario Final: {item.HorarioFin}\nOradores:\n";
                foreach(Orador item2 in item.Oradores)
                {
                    lista = lista + $"Nombre: {item2.Nombre} {item2.Apellido} - Tema: {item2.Tema}\nHorario Inicio:{item2.Hora} - Horario Final: {item2.HoraFin}\nContacto: {item2.Correo}\n";
                }
            }
            MessageBox.Show($"Nombre: {Nombre}\nFecha Inicio: {Fecha}\nFecha Final: {FechaFin}\nPrecio: {Precio}\nDescripción: {Descripcion}\nCharlas:\n{lista}");
            MapaDelEvento f = new MapaDelEvento(ubicacion);
            f.Show();
        }

    }
}
