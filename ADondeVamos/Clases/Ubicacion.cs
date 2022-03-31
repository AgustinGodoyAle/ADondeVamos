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
        private double _latitud;
        private double _longitud;
        private string _descripcion;
        private string _direccion;
        public double Latitud { get=>_latitud; set=>_latitud=value; }
        public double Longitud { get=>_longitud; set=>_longitud=value; }
        public string Descripcion { get=>_descripcion; set=>_descripcion=value; }
        public string Direccion { get=>_direccion; set=>_direccion=value; }

        public Ubicacion(double lat, double lng, string des)
        {
            Latitud = lat;
            Longitud = lng;
            Descripcion = des;
        }

        //public void AgregarMapa(double lat, double lng, string des)
        //{
        //    Latitud = lat;
        //    Longitud = lng;
        //    Descripcion = des;
        //}

        public void MostrarDatos()
        {
            MessageBox.Show($"Descripción: {Descripcion}\nLatitud: {Latitud.ToString()}\nLongitud: {Longitud.ToString()} ");
        }



    }
}
