using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    public partial class MapaDelEvento : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInicial;
        double LngInicial;
        string Descripcion;

        public MapaDelEvento(Ubicacion a)
        {
            InitializeComponent();

            LatInicial = a.Latitud;
            LngInicial = a.Longitud;
            Descripcion = a.Descripcion;
        }

        private void MapaDelEvento_Load(object sender, EventArgs e)
        {
            //Cargando mapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //marcador 
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            //agregamos un Tooltip de texto a los marcadores //muestra un mensaje
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("{0}:\n Latitud:{1} \n Longitud: {2}", Descripcion, LatInicial, LngInicial);

            //agregamos el mapa y el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
        }
    }
}
