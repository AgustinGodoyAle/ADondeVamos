using ADondeVamos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos.Ventanas
{
    public partial class EventosVerActuales : Form
    {
        Sistema sistema;
        Usuario usuario;
        List<Evento> EventoActual;
        public EventosVerActuales(Sistema aux, Usuario aux2)
        {
            sistema = aux;
            usuario = aux2;
            EventoActual = sistema.EventosOrderByDate();
            InitializeComponent();
        }

        
        private void Creados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Creados.Columns[e.ColumnIndex].Name == "VerEvento")
            {
                int valor = (int)Creados.CurrentRow.Cells["VerEvento"].Value;
                int bande = 0;
                while (bande == 0)
                {
                    foreach(Evento item in EventoActual)
                    {
                        if(item.GetType()==typeof(EventoFiesta))
                        {
                            if(item.Number == valor)
                            {
                                item.MostrarDatos(); bande = 1;
                            }
                        }
                    }
                    foreach (Evento item in EventoActual)
                    {
                        if (item.GetType() == typeof(EventoFuncion))
                        {
                            if (item.Number == valor)
                            {
                                item.MostrarDatos(); bande = 1;
                            }
                        }
                    }
                    foreach (Evento item in EventoActual)
                    {
                        if (item.GetType() == typeof(EventoCharla))
                        {
                            if (item.Number == valor)
                            {
                                item.MostrarDatos(); bande = 1;
                            }
                        }
                    }
                    foreach (Evento item in EventoActual)
                    {
                        if (item.GetType() == typeof(EventoConcierto))
                        {
                            if (item.Number == valor)
                            {
                                item.MostrarDatos(); bande = 1;
                            }
                        }
                    }
                    foreach (Evento item in EventoActual)
                    {
                        if (item.GetType() == typeof(EventoConvencion))
                        {
                            if (item.Number == valor)
                            {
                                item.MostrarDatos(); bande = 1;
                            }
                        }
                    }
                    foreach (Evento item in EventoActual)
                    {
                        if (item.GetType() == typeof(EventoDeportivoCarrera))
                        {
                            if (item.Number == valor)
                            {
                                item.MostrarDatos(); bande = 1;
                            }
                        }
                    }
                    foreach (Evento item in EventoActual)
                    {
                        if (item.GetType() == typeof(EventoDeportivoTorneo))
                        {
                            if (item.Number == valor)
                            {
                                item.MostrarDatos(); bande = 1;
                            }
                        }
                    }
                    foreach (Evento item in EventoActual)
                    {
                        if (item.GetType() == typeof(EventoMunicipal))
                        {
                            if (item.Number == valor)
                            {
                                item.MostrarDatos(); bande = 1;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio f = new Inicio(usuario, sistema);
            f.Show();
            this.Hide();
        }

        private void EventosVerActuales_Load(object sender, EventArgs e)
        {
            int i = 1;
            
            foreach (Evento item in EventoActual)
            {
                item.Number = i;
                Creados.Rows.Add(item.Nombre, item.CantidadAsistentes, item.Fecha, item.FechaFin, item.ubicacion.Descripcion, item.Number);
                i++;
            }
        }
    }
}
