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
        public List<Partido> Partidos = new List<Partido>();  //COMPOSICION
        public string Deporte { get; set; }
        public string Categoria { get; set; }

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
                lista = lista + "\n" + item.equipo1.Nombre + "  VS  " + item.equipo2.Nombre + " - Horario: " + item.FechaInicio;
                if(item.equipo1.Jugadores != null)
                {
                    lista = lista + $"\nLista de Jugadores de {item.equipo1.Nombre}:" + "\n";
                    foreach (Jugador item2 in item.equipo1.Jugadores)
                    {
                        lista = lista + item2.Nombre + " " + item2.Apellido + " - Posición: " + item2.Posicion + " - Contacto: " + item2.Correo + "\n";
                    }
                }
                if (item.equipo2.Jugadores != null)
                {
                    lista = lista + $"Lista de Jugadores de {item.equipo2.Nombre}:" + "\n";
                    foreach (Jugador item2 in item.equipo2.Jugadores)
                    {
                        lista = lista + item2.Nombre + " " + item2.Apellido + " - Posición: " + item2.Posicion + " - Contacto: " + item2.Correo + "\n";
                    }
                }
            }
            MessageBox.Show($"Torneo de {Deporte}\nCategoría {Categoria}\nPartidos: {lista}");
        }

    }

    
}
