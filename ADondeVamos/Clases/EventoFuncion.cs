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
    public class EventoFuncion : Evento
    {
        private List<Funcion> _funciones = new List<Funcion>();
        private string _tipo;
        public List<Funcion> Funciones
        { get => _funciones; set => _funciones = value; }
        public string Tipo { get=>_tipo; set=>_tipo=value; } //Teatro o Cine
        

        public EventoFuncion(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }

        public new void MostrarDatos()
        {
            MessageBox.Show($"Nombre: {this.Nombre}\nCategoria: {this.Tipo}\nFecha: {this.Fecha}\nFecha Fin: {this.FechaFin}\nPrecio: ${this.Precio}\nDescripción: {this.Descripcion}\nUsuario creador del evento: {Creador.User} - {Creador.Nombre} {Creador.Apellido}");
            foreach (Funcion item in Funciones)
            {
                item.MostrarDatos(); 
            }
            if (ubicacion != null)
            {
                MapaDelEvento f = new MapaDelEvento(ubicacion);
                f.Show();
            }
        }

        //public void MostrarDatosFuncion()
        //{
        //    string lista = "";
        //    foreach (Funcion item in Funciones)
        //    {
        //        lista = lista + ($"Funcion de {item.Tipo}\nNombre: {item.Nombre}\nGénero: {item.Genero}\nClasificación: {item.Clasificacion}\nInicio: {item.FechaInicio}\nFinaliza:{item.FechaFinal}");
        //    }
        //    MessageBox.Show($"Funciones: \n{lista}");
        //}

        public void AgregarFuncion(Funcion funcion)
        {
            Funciones.Add(funcion);
        }

        
    }
}
