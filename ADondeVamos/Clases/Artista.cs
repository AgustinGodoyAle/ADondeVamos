using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class Artista :Persona 
    {
        private string _categoria;
        public string Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }

        public Artista(string nombre,string apellido, string categoria)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Categoria = categoria;
            
        }

        public bool ValidarDatos(string nombre, string apellido)
        {
            string mensaje = "";
            bool bande = true;
            if (nombre == "")
            {
                mensaje += "Debe ingresar un nombre\n";
                bande = false;
            }
            if (apellido == "")
            {
                mensaje += "Debe ingresar un apellido\n";
                bande = false;
            }
            if (bande == false)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;
        }
    }
}
