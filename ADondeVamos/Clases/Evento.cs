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
        private string _nombre;
        private DateTime _fecha;
        private DateTime _fechafin;
        private Ubicacion _ubicacion;
        private double _precio;
        private string _descripcion;
        private Usuario _creador;
        private int _cantidad;
        private List<Usuario> _asistentes;
        private int _number;
        public string Nombre { get=>_nombre; set=>_nombre=value; }
        public DateTime Fecha { get=>_fecha; set=>_fecha=value; }
        public DateTime FechaFin { get=>_fechafin; set=>_fechafin=value; }
        public Ubicacion ubicacion { get=>_ubicacion; set=>_ubicacion=value; }
        public double Precio { get=>_precio; set=>_precio=value; }
        public string Descripcion { get=>_descripcion; set=>_descripcion=value; }
        public Usuario Creador { get=>_creador; set=>_creador=value; }
        public int CantidadAsistentes { get=>_cantidad; set=>_cantidad=value; }
        public List<Usuario> Asistentes { get=>_asistentes; set=>_asistentes=value; }

        public int Number { get=>_number;set=>_number=value; }

        public void MostrarDatos()
        {
            if (ubicacion != null)
            {
                MessageBox.Show($"Nombre del Evento: {Nombre}\nCantidad de Asistentes: {CantidadAsistentes}\nFecha Inicio: {Fecha}\nFecha Fin: {FechaFin}\nPrecio: ${Precio}\nDescripción: {Descripcion}");
                MapaDelEvento f = new MapaDelEvento(ubicacion);
                f.Show();
            }
        }

        public void MostrarAmigosAsistentes(Usuario usuario)
        {
            string mensaje="";
            foreach (Usuario item in Asistentes)
            {
                foreach(Usuario item2 in usuario.Amigos)
                {
                    if (item2 == item)
                    {
                        mensaje = mensaje + $"{item.User} - {item.Nombre} {item.Apellido}\n";
                    }
                }
            }
            MessageBox.Show($"Amigos que irán a {this.Nombre}:\n{mensaje}","ASISTENTES",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AgregarUbicacion(Ubicacion ubicacion1)
        {
            ubicacion = ubicacion1;
        }

        public void AgregarAsistidor(Usuario usuario)
        {
            if (Asistentes == null)
                Asistentes = new List<Usuario>();

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

