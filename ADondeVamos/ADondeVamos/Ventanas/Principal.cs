using ADondeVamos.Clases;
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

namespace ADondeVamos.Ventanas
{
    public partial class Principal : Form
    {
        Sistema sistema;
        public Principal(Sistema aux)
        {
            sistema = aux;
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            Registrarse f = new Registrarse(sistema);
            f.Show();
            this.Hide();
        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            Logueo f = new Logueo(sistema);
            f.Show();
            this.Hide();
        }

        private void cargardatos_Click(object sender, EventArgs e)
        {
            //Se cargan los datos
            var file = new FileStream("c:\\temp\\sistema.dat", FileMode.Open);
            var formatter = new BinaryFormatter();
            sistema = formatter.Deserialize(file) as Sistema;
            //int bande = 0; //var index = 0; var index2 = 0; var index3 = 0; var indice = 0;
            //foreach (EventoFiesta item in sistema.Fiestas)
            //{
            //    if (item.FechaFin < DateTime.Now.Date)
            //    {
            //        foreach (Usuario usuario in sistema.Usuarios)
            //        {
            //            foreach (EventoFiesta fiesta1 in usuario.Fiestas)
            //            {
            //                if (item == fiesta1)
            //                {
            //                    //index2 = usuario.Fiestas.IndexOf(item);
            //                    usuario.EliminarEvento(item);
            //                }
            //            }
            //            foreach (EventoFiesta fiesta2 in usuario.EAsistidosFies)
            //            {
            //                if (item == fiesta2)
            //                {
            //                    //index3 = usuario.EAsistidosFies.IndexOf(item);
            //                    usuario.NoAsistirEvento(item);
            //                }
            //            }
            //        }
            //        bande = 1;
            //        //index = sistema.Fiestas.IndexOf(item);
            //        sistema.EliminarEvento(item);
            //    }
            //}
            //if (bande == 1)
            //{
            //    sistema.Fiestas.RemoveAt(index);
            //    ////sistema.EliminarEventosDeUsuarios(index2, "Fiesta");
            //}
            file.Close();
        }
    }
}
