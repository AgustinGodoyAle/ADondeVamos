using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public abstract class Evento
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaFin { get; set; }
        public Ubicacion ubicacion { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public Usuario Creador { get; set; }
        public int CantidadAsistentes { get; set; }
        public List<Usuario> Asistentes = new List<Usuario>();

        public int Number { get;set; }

        public void MostrarDatos()
        {
            MessageBox.Show($"Nombre del Evento: {Nombre}\nCantidad de Asistentes: {CantidadAsistentes}\nFecha Inicio: {Fecha}\nFecha Fin: {FechaFin}\nPrecio: ${Precio}\nDescripción: {Descripcion}");
            MapaDelEvento f = new MapaDelEvento(ubicacion);
            f.Show();
        }

        public void AgregarUbicacion(Ubicacion ubicacion1)
        {
            ubicacion = ubicacion1;
        }

        public void AgregarAsistidor(Usuario usuario)
        {
            int bande = 1;
            foreach(Usuario item in Asistentes)
            {
                if (item == usuario)
                    bande = 0;
            }
            if(bande==1)
            {
                Asistentes.Add(usuario);
                CantidadAsistentes++;
            }
        }
        public void EliminarAsistidor(Usuario usuario)
        {
            int bande = 1;
            foreach (Usuario item in Asistentes)
            {
                if (item == usuario)
                    bande = 0;
            }
            if (bande == 0)
            {
                Asistentes.Remove(usuario);
                CantidadAsistentes--;
            }
        }
    }
}

