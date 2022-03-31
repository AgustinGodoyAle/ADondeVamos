using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADondeVamos
{
    
    public partial class Logueo : Form
    {
        //List<Usuario> Usuarios = new List<Usuario>();
        //List<EventoFiesta> Fiestas = new List<EventoFiesta>();
        //List<EventoDeportivoTorneo> Torneos = new List<EventoDeportivoTorneo>();
        //List<EventoDeportivoCarrera> Carreras = new List<EventoDeportivoCarrera>();
        //List<EventoMunicipal> Municipales = new List<EventoMunicipal>();
        //List<EventoConcierto> Conciertos = new List<EventoConcierto>();
        //List<EventoCharla> Artes = new List<EventoCharla>();
        //Ranking RFiesta = new Ranking();
        //Ranking RDeportivo = new Ranking();
        //Ranking RMunicipal = new Ranking();
        //Ranking RConcierto = new Ranking();
        //Ranking RArte = new Ranking();
        Sistema sistema;
        List<Usuario> Usuarios = new List<Usuario>();
        public Logueo(Sistema aux)
        {
            sistema = aux;
            InitializeComponent();
        }

        public Usuario ComprobarUsuario(string userr, string contraa)
        {
            Usuarios = sistema.Usuarios;
            Usuario user = new Usuario("","","","");
            foreach(Usuario item in Usuarios)
            {
                if ((userr == item.User || userr == item.Correo) && contraa == item.Contra)
                    user = item;
            }
            return user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Usuario agustin = new Usuario("Agustin","Godoy","admin","admin");
            Usuario user = this.ComprobarUsuario(usuariotxt.Text, contratxt.Text);
            if (user.Correo != null)
            {
                Inicio f = new Inicio(user, sistema);
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Lo sentimos...\nEl usuario y/o la contraseña son incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
            //Se cargan datos
            //using (var stream = File.Open("c:\\temp\\sistema.dat", FileMode.Open, FileAccess.Write, FileShare.ReadWrite)) { }
            //Se cargan los datos

            //var file = new FileStream("c:\\temp\\sistema.dat", FileMode.Open);
            //var formatter = new BinaryFormatter();
            //sistema = formatter.Deserialize(file) as Sistema;
            //file.Close();
            //Usuarios = sistema.Usuarios;
            //Fiestas = sistema.Fiestas;
            //Torneos = sistema.Torneos;
            //Carreras = sistema.Carreras;
            //Municipales = sistema.Municipales;
            //Conciertos = sistema.Conciertos;
            //Artes = sistema.Artes;
            //RFiesta = sistema.RankingFiesta;
            //RDeportivo = sistema.RankingDeportivo;
            //RMunicipal = sistema.RankingMunicipal;
            //RConcierto = sistema.RankingConcierto;
            //RArte = sistema.RankingArte;
    }
}
