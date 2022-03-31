using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos.Clases
{
    [Serializable]
    public class Funcion
    {
        private string _nombre;
        private string _genero;
        private string _clasificacion;
        private string _tipo;
        private DateTime _inicio;
        private DateTime _final;
        private List<Artista> _actores;
        public string Nombre { get=>_nombre; set=>_nombre=value; }
        public string Genero { get=>_genero; set=>_genero=value; } //comedia, drama, etc
        public string Clasificacion { get=>_clasificacion; set=>_clasificacion=value; } //atp, mayores de 13, mayores de 18, etc
        public string Tipo { get=>_tipo; set=>_tipo=value; } //Obra de teatro o pelicula
        public DateTime FechaInicio { get=>_inicio; set=>_inicio=value; }
        public DateTime FechaFinal { get=>_final; set=>_final=value; }
        public List<Artista> Actores { get => _actores; set => _actores = value; }

        public Funcion(string nombre, string genero, string clasificacion, string tipo, DateTime inicio, DateTime final)
        {
            Nombre = nombre;
            Genero = genero;
            Clasificacion = clasificacion;
            Tipo = tipo;
            FechaInicio = inicio;
            FechaFinal = final;
        }
        public void AsociarActores(List<Artista> actores)
        {
            Actores = actores;
        }
        public void MostrarDatos()
        {
           string lista="";
            if (Actores != null) 
            {
                foreach (Artista item in Actores)
                {
                    lista = lista + $"Actor: {item.Nombre} {item.Apellido}\nCategoría: {item.Categoria}\nContacto: {item.Correo}\n";
                }
               
            }
            MessageBox.Show($"Nombre de Función: {this.Nombre}\nGénero: {this.Genero}\nClasificación: {this.Clasificacion}\nTipo: {this.Tipo}\nFecha Inicio: {this.FechaInicio}\nFecha Final: {this.FechaFinal}\nActores:\n{lista}");


        }
    }
}
