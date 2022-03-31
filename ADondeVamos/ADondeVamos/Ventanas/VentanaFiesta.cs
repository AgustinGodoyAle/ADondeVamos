using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic;
using ADondeVamos.Ventanas;
using ADondeVamos.Clases;

namespace ADondeVamos
{
    public partial class VentanaFiesta : Form
    {
        EventoFiesta fiesta;
        List<EventoFiesta> Fiestas = new List<EventoFiesta>();
        Sistema sistema;
        
        public VentanaFiesta(EventoFiesta fiesta1, Sistema aux2)
        {
            sistema = aux2;
            fiesta = fiesta1;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //Aceptar
        {
            
            string entradabebida = comboBoxEntradaBebida.SelectedItem.ToString();
            string tipodefiesta = comboBoxTipoFiesta.SelectedItem.ToString();
            double precioconser;
            fiesta.Categoria = tipodefiesta;
            fiesta.Vestimenta = vestimentatxt.Text;
            fiesta.EntradaConBebida=entradabebida;
            precioconser = fiesta.PrecioConser();
            if (precioconser != -10)
            {
                fiesta.PrecioConservadora = precioconser;

                //Serialización
                if (BandasSiNo.SelectedItem.ToString() == "No")
                {
                    //muestra en messagebox
                    fiesta.MostrarDatos();
                    foreach(Usuario item in sistema.Usuarios)
                    {
                        if(item==fiesta.Creador)
                        {
                            item.AgregarEvento(fiesta);
                        }
                    }
                    sistema.Fiestas.Add(fiesta);
                    var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(file, sistema);
                    file.Close();
                    
                    Inicio f = new Inicio(fiesta.Creador, sistema);
                    f.Show();
                    this.Hide();
                }//Se abre la ventana para usar bandas
                else
                {
                    VentanaBanda f = new VentanaBanda(fiesta, sistema);
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //Volver, volvemos a la ventana anterior
        {
            VentanaCrear f = new VentanaCrear(fiesta.Creador, sistema);
            f.Show();
            this.Hide();
        }
    }
}
