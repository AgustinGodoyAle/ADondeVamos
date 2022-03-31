using ADondeVamos.Clases;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos.Clases
{
    [Serializable]
    public class EventoFiesta : Evento
    {
        public string Vestimenta { get; set; }
        public string Categoria { get; set; } //boliche cumpleaños fiestacolegio fiestatematica  matine
        public string EntradaConBebida { get; set; }

        public double PrecioConservadora { get; set; }

        public List<Banda> Bandas = new List<Banda>();

        public EventoFiesta(string nombre, DateTime dia, DateTime diafin, double precio, string descripcion, Usuario usuario)
        {
            Nombre = nombre;
            Fecha = dia;
            FechaFin = diafin;
            Precio = precio;
            Creador = usuario;
            Descripcion = descripcion;
        }
        public EventoFiesta(string entradaBebida, string categoria, string vestimenta)
        {
            EntradaConBebida = entradaBebida;
            Categoria = categoria;
            Vestimenta = vestimenta;
        }
        public void AgregarBanda(Banda banda)
        {
            Bandas.Add(banda);
        }
        public double PrecioConser()
        {
            string precio="bande";
            double precioconser=-1;
            int bande = 0;
            if (EntradaConBebida == "Conservadora")
            {
                while (bande != 1 && precio!="")
                {
                        precio = Interaction.InputBox("Ingrese precio por conservadora:", "Conservadora");
                        try
                        {
                            precioconser = Convert.ToDouble(precio);
                            if (precioconser > -1)
                            {
                                bande = 1;
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar valores númericos positivos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {   if(precio!="")
                                MessageBox.Show("Debe ingresar valores númericos positivos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                if (precio == "")
                    return precioconser = -10;
                else
                    return precioconser;
            }
            else
            {
                return precioconser;
            }

        }
        public void MostrarBandas()
        {
            foreach (Banda item in Bandas)
            {
                item.MostrarBanda();
            }
        }
        public new void MostrarDatos()
        {
            if (EntradaConBebida=="Conservadora")
            {
                MessageBox.Show($"Nombre: {this.Nombre}\nCategoria: {this.Categoria}\nFecha Inicio: {this.Fecha}\nFecha Fin: {this.FechaFin}\nPrecio: ${this.Precio}\nBebidas: {this.EntradaConBebida} ${PrecioConservadora}\nVestimenta: {this.Vestimenta}\nDescripción: {this.Descripcion}");
            }
            else
            {
                MessageBox.Show($"Nombre: {this.Nombre}\nCategoria: {this.Categoria}\nFecha Inicio: {this.Fecha}\nFecha Fin: {this.FechaFin}\nPrecio: ${this.Precio}\nBebidas: {this.EntradaConBebida}\nVestimenta: {this.Vestimenta}\nDescripción: {this.Descripcion}");
            }
            if(Bandas!=null)
            {
                this.MostrarBandas();
            }
            MapaDelEvento f = new MapaDelEvento(ubicacion);
            f.Show();
        }
        public string Datos()
        {
            string datos;
            if (EntradaConBebida == "Conservadora")
            {
                return datos= $"Nombre: {this.Nombre}\nCategoria: {this.Categoria}\nFecha Inicio: {this.Fecha}\nFecha Fin: {this.FechaFin}\nPrecio: ${this.Precio}\nBebidas: {this.EntradaConBebida} ${PrecioConservadora}\nVestimenta: {this.Vestimenta}\nDescripción: {this.Descripcion}";
            }
            else
            {
                return datos = $"Nombre: {this.Nombre}\nCategoria: {this.Categoria}\nFecha Inicio: {this.Fecha}\nFecha Fin: {this.FechaFin}\nPrecio: ${this.Precio}\nBebidas: {this.EntradaConBebida}\nVestimenta: {this.Vestimenta}\nDescripción: {this.Descripcion}";
            }
        }

        public void AgregarPrecioConservadora(double precioconser)
        {
            PrecioConservadora = precioconser; 
        }
    }
}
