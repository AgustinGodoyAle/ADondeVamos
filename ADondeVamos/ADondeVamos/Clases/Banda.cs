using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos.Clases
{
    [Serializable]
    public class Banda
    {
        public string Nombre { get; set; }
        public List<Artista> Miembros = new List<Artista>();
        public string Genero { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Contacto { get; set; }
        public Banda(string nombre, string genero)
        {
            Nombre = nombre;
            Genero = genero;
        }

        public void AgregarArtista(Artista artista)
        {
            Miembros.Add(artista);
        }

        public void MostrarBanda()
        {
            string lista = "";

            foreach (Artista item in Miembros)
            {
                lista = lista + "\n" + item.Nombre + " " + item.Apellido + "-" + item.Categoria + "-" + item.Correo;
            }
            MessageBox.Show($"Banda/Solista Participante: {Nombre}\nGénero: {Genero}\nFecha Inicio: {FechaInicio}\nFecha Final: {FechaFin}\nMiembros: {lista}");
        }
    }
}
