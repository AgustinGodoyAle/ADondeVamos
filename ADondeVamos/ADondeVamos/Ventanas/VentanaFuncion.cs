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
    public partial class VentanaFuncion : Form
    {
        EventoFuncion funcion;
        Sistema sistema;
        public VentanaFuncion(EventoFuncion aux, Sistema aux2)
        {
            funcion = aux;
            sistema = aux2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcion.Tipo = comboBox1.Text;
            VentanaFuncionAgregar f = new VentanaFuncionAgregar(funcion, sistema);
            f.Show();
            this.Hide();
        }
    }
}
