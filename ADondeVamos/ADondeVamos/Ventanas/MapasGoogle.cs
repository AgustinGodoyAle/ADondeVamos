using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class MapasGoogle : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        int filaSeleccionada = 0;
        double LatInicial = -26.791085;
        double LngInicial = -60.441856;
        public MapasGoogle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CargarMapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador 
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            //agregamos un Tooltip de texto a los marcadores //muestra un mensaje
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion:\n Latitud:{0} \n Longitud: {1}", LatInicial, LngInicial);

            //agregamos el mapa y el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
        }

        double lat;
        double lng;
        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Se obtiene los datos de lat y lng del mapa donde el usuario presiono
            lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //Creamos el marcador para moverlo al lugar indicado, lo movemos

            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud{0} \n Longitud{1}", lat, lng);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //se crea una ubicacion
            Ubicacion ubicacion = new Ubicacion(lat, lng, txtDescripcion.Text);
            ubicacion.MostrarDatos();

            MapaDelEvento f = new MapaDelEvento(ubicacion);
            f.Show();
            this.Hide();

        }

    }
}
