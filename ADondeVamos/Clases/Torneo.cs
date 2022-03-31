using ADondeVamos.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class Torneo
    {
        private List<Partido> _partidos;
        private string _deporte;
        private string _categoria;
        public List<Partido> Partidos { get => _partidos; set => _partidos = value; }  //asociacion
        public string Deporte { get=>_deporte; set=>_deporte=value; }
        public string Categoria { get=>_categoria; set=>_categoria=value; }

        public Torneo(string deporte, string categoria)
        {
            this.Deporte = deporte;
            this.Categoria = categoria;
        }

        public void AgregarPartido(Partido partido1)
        {
            this.Partidos.Add(partido1);
        }

        public void MostrarDatos()
        {
            //string lista = String.Join("\n", Partidos);
            //var listapartidos = string.Join(Environment.NewLine, Partidos);
            string lista="";
            foreach(Partido item in Partidos)
            {
                lista = lista + "\n" + item.Equipo1.Nombre + "  VS  " + item.Equipo2.Nombre + " - Horario: " + item.FechaInicio + "-Horario fin: " + item.FechaFinal;
                if(item.Equipo1.Jugadores != null)
                {
                    lista = lista + $"\nLista de Jugadores de {item.Equipo1.Nombre}:" + "\n";
                    foreach (Jugador item2 in item.Equipo1.Jugadores)
                    {
                        lista = lista + item2.Nombre + " " + item2.Apellido + " - Posición: " + item2.Posicion + " - Contacto: " + item2.Correo + "\n";
                    }
                }
                if (item.Equipo2.Jugadores != null)
                {
                    lista = lista + $"\nLista de Jugadores de {item.Equipo2.Nombre}:" + "\n";
                    foreach (Jugador item2 in item.Equipo2.Jugadores)
                    {
                        lista = lista + item2.Nombre + " " + item2.Apellido + " - Posición: " + item2.Posicion + " - Contacto: " + item2.Correo + "\n";
                    }
                }
            }
            MessageBox.Show($"Torneo de {Deporte}\nCategoría {Categoria}\nPartidos: {lista}");
        }

    }

    
}
