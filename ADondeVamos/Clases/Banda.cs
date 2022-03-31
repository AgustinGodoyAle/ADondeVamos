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
        private string _nombre;
        private List<Artista> _miembros;
        private string _genero;
        private string _fechainicio;
        private string _fechafin;
        private string _contacto;
        public string Nombre
        {
            get=>_nombre;
            set=>_nombre=value;
        }
        public List<Artista> Miembros
        {
            get => _miembros;
            set => _miembros = value;
        }
        public string Genero
        {
            get => _genero;
            set => _genero=value;
        }
        public string FechaInicio
        {
            get => _fechainicio;
            set => _fechainicio = value;
        }
        public string FechaFin
        {
            get => _fechafin;
            set => _fechafin = value;
        }
        public string Contacto
        {
            get => _contacto;
            set => _contacto = value;
        }
        public Banda(string nombre, string genero)
        {
            _nombre = nombre;
            _genero = genero;
        }

        public void AsociarArtistas(List<Artista> artista)
        {
            Miembros = artista;
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
