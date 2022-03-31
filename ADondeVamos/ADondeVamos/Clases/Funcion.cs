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
        public string Nombre { get; set; }
        public string Genero { get; set; } //comedia, drama, etc
        public string Clasificacion { get; set; } //atp, mayores de 13, mayores de 18, etc
        public string Tipo { get; set; } //Obra de teatro o pelicula
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public List<Artista> Actores = new List<Artista>();

        public Funcion(string nombre, string genero, string clasificacion, string tipo, DateTime inicio, DateTime final)
        {
            Nombre = nombre;
            Genero = genero;
            Clasificacion = clasificacion;
            Tipo = tipo;
            FechaInicio = inicio;
            FechaFinal = final;
        }
        public void AgregarActor(Artista artista)
        {
            Actores.Add(artista);
        }
        public void MostrarDatos()
        {
           string lista="";
           foreach(Artista item in Actores)
           {
                lista = lista + $"Actor: {item.Nombre} {item.Apellido}\nCategoría: {item.Categoria}\nContacto: {item.Correo}\n";
           }
           MessageBox.Show($"Nombre de Función: {this.Nombre}\nGénero: {this.Genero}\nClasificación: {this.Clasificacion}\nTipo: {this.Tipo}\nFecha Inicio: {this.FechaInicio}\nFecha Final: {this.FechaFinal}\nActores:\n{lista}");

        }
    }
}
