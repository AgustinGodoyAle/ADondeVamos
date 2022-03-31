using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ADondeVamos
{
    [Serializable]
    public class Ubicacion //Asociacion de evento
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }

        public Ubicacion(double lat, double lng, string des)
        {
            Latitud = lat;
            Longitud = lng;
            Descripcion = des;
        }

        public Ubicacion()
        {

        }

        public void AgregarMapa(double lat, double lng, string des)
        {
            Latitud = lat;
            Longitud = lng;
            Descripcion = des;
        }

        public void MostrarDatos()
        {
            MessageBox.Show($"Descripción: {Descripcion}\nLatitud: {Latitud.ToString()}\nLongitud{Longitud.ToString()} ");
        }



    }
}
