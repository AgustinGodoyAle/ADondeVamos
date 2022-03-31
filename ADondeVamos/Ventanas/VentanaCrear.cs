using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADondeVamos.Clases;
using ADondeVamos.Ventanas;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ADondeVamos
{
    public partial class VentanaCrear : Form
    {
        //diaDateTime.CustomFormat="MM/dd/yyyy h: mm:ss tt";
        Usuario usuario;
        Sistema sistema = new Sistema();
        
        public VentanaCrear(Usuario aux, Sistema auxsis)
        {
            usuario = aux;
            sistema = auxsis;
            InitializeComponent();

            int anno = DateTime.Now.Year; int dia = DateTime.Now.Day; int mes = DateTime.Now.Month;
            int hora = DateTime.Now.Hour; int minu = DateTime.Now.Minute;
            diaDateTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
            diafinDateTime.Value = new DateTime(anno, mes, dia, hora, minu, 0, 0);
        }

        public bool ValidarDatos(string nombre, DateTime fechainicio, DateTime fechafinal, string precio, string descri)
        {
            string mensaje="";
            bool bande;
            if(nombre!="")
            {
                if (DateTime.Compare(fechainicio, DateTime.Now) >= 0)//Si inicio es mayor o igual a fecha actual
                {
                    if (DateTime.Compare(fechainicio, fechafinal) < 0)//Si inicio es menor a final
                    {
                        if(descri!="")
                        {
                            try
                            {
                                if (Convert.ToDouble(precio) >= 0)
                                {
                                    bande = true;
                                }
                                else
                                {
                                    mensaje += "Debe ingresar un número real positivo para el precio o 0 si es gratis\n";
                                    bande = false;
                                }
                            }
                            catch
                            {
                                bande= false;
                            }
                        }
                        else
                        {
                            bande= false;
                        }
                    }
                    else
                    {
                        bande= false;
                    }
                }
                else
                {
                    bande= false;
                }
            }
            else
            {
                mensaje += "Debe ingresar un nombre para el evento\n";
                bande= false;
            }
            if (DateTime.Compare(fechainicio, DateTime.Now) < 0)//Si inicio es menor a fecha actual
            {
                mensaje += "La fecha de inicio ya finalizó\n";
            }
            if (DateTime.Compare(fechainicio, fechafinal) > 0)//Si inicio es mayor a final
            {
                mensaje += "La fecha de inicio no puede ser mayor o igual a la fecha final\n";
            }
            if (descri == "")
            {
                mensaje += "Debe ingresar una descripción para el evento\n";
            }
            try
            {
                Convert.ToDouble(precio);
            }
            catch
            {
                mensaje += "Debe ingresar un número real positivo para el precio o 0 si es gratis\n";
            }
            if(bande==false)
            {
                MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre = nombretxt.Text;
            DateTime fechainicio = new DateTime();
            DateTime fechafinal = new DateTime();
            fechainicio = diaDateTime.Value;
            fechafinal = diafinDateTime.Value;
            string descripcion = descripciontxt.Text;
            if (this.ValidarDatos(nombre, fechainicio, fechafinal, preciotxt.Text, descripcion) == true)
            {
                if (ubicacion != null)
                {
                    double precio = Convert.ToDouble(preciotxt.Text);

                    if (comboBox1.SelectedIndex == 0) //Selecciona Fiesta
                    {
                        EventoFiesta fiesta = new EventoFiesta(nombre, fechainicio, fechafinal, precio, descripcion, usuario);
                        fiesta.AgregarUbicacion(ubicacion);

                        VentanaFiesta f = new VentanaFiesta(fiesta, sistema);
                        f.Show();
                        this.Hide();


                    }//if (comboBox1.SelectedItem is EventoFiesta)
                    if (comboBox1.SelectedIndex == 1) //Selecciona Acto Municipal
                    {
                        nombretxt.Text = "";
                        preciotxt.Text = "";
                        descripciontxt.Text = "";
                        txtDescripcion.Text = "";
                        MessageBox.Show("Error: este tipo de evento aún no puede ser creado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //EventoMunicipal acto = new EventoMunicipal(nombre, fechainicio, fechafinal,  precio, descripcion, usuario);
                        //acto.AgregarUbicacion(ubicacion);

                        //VentanaMunicipal f = new VentanaMunicipal(acto);
                        //f.Show();
                        //this.Hide();

                    }
                    if (comboBox1.SelectedIndex == 2)//Selecciona Charlas
                    {
                        EventoCharla evento = new EventoCharla(nombre, fechainicio, fechafinal, precio, descripcion, usuario);
                        evento.AgregarUbicacion(ubicacion);

                        VentanaCharla f = new VentanaCharla(evento, sistema);
                        f.Show();
                        this.Hide();

                    }
                    if (comboBox1.SelectedIndex == 3)//selecciona Torneo
                    {
                        EventoDeportivoTorneo evento = new EventoDeportivoTorneo(nombre, fechainicio, fechafinal, precio, descripcion, usuario);
                        evento.AgregarUbicacion(ubicacion);

                        VentanaTorneo f = new VentanaTorneo(evento, sistema);
                        f.Show();
                        this.Hide();

                    }
                    if (comboBox1.SelectedIndex == 4)//selecciona Carreras
                    {
                        EventoDeportivoCarrera evento = new EventoDeportivoCarrera(nombre, fechainicio, fechafinal, precio, descripcion, usuario);
                        evento.AgregarUbicacion(ubicacion);

                        VentanaCarrera f = new VentanaCarrera(evento, sistema);
                        f.Show();
                        this.Hide();

                    }
                    if (comboBox1.SelectedIndex == 5)//selecciona concierto
                    {
                        EventoConcierto concierto = new EventoConcierto(nombre, fechainicio, fechafinal, precio, descripcion, usuario);
                        concierto.AgregarUbicacion(ubicacion);

                        VentanaBanda f = new VentanaBanda(concierto, sistema);
                        f.Show();
                        this.Hide();

                    }
                    if (comboBox1.SelectedIndex == 6)//selecciona Funciones
                    {
                        EventoFuncion evento = new EventoFuncion(nombre, fechainicio, fechafinal, precio, descripcion, usuario);
                        evento.AgregarUbicacion(ubicacion);

                        VentanaFuncion f = new VentanaFuncion(evento, sistema);
                        f.Show();
                        this.Hide();

                    }
                    if (comboBox1.SelectedIndex == 7)//selecciona Funciones
                    {
                        nombretxt.Text = "";
                        preciotxt.Text = "";
                        descripciontxt.Text = "";
                        txtDescripcion.Text = "";
                        MessageBox.Show("Error: este tipo de evento aún no puede ser creado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //EventoConvencion evento = new EventoConvencion(nombre, fechainicio, fechafinal, precio, descripcion, usuario);
                        //evento.AgregarUbicacion(ubicacion);

                        ////VentanaConvension f = new VentanaConvension(evento);
                        ////f.Show();
                        //this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Debe agregar una ubicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                descripciontxt.Text="";
                nombretxt.Text = "";
                preciotxt.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e) //Volver
        {
            Inicio f = new Inicio(usuario, sistema);
            f.Show();
            this.Hide();

        }

    
        //MAPA DE UBICACION
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInicial = -26.791085;
        double LngInicial = -60.441856;
        private void VentanaCrear_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
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

        Ubicacion ubicacion;
        private void btnAgregarUbicacion_Click(object sender, EventArgs e)
        {
            //se crea una ubicacion
            Ubicacion ubicacion1 = new Ubicacion(lat, lng, txtDescripcion.Text);
            ubicacion = ubicacion1;
            ubicacion.MostrarDatos();

        }
    }
}
