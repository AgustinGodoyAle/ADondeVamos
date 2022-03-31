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
    public partial class VentanaAmigos : Form
    {
        Sistema sistema;
        Usuario usuario;
        public VentanaAmigos(Sistema aux, Usuario aux2)
        {
            sistema = aux;
            usuario = aux2;
            InitializeComponent();
        }

        private void Anadir_Click(object sender, EventArgs e)
        {
            usuario.AnadirAmigo(sistema, codetxt.Text, nametxt.Text);
            richTextBox1.Clear();
            if (usuario.Amigos != null)
            {
                foreach (Usuario item in usuario.Amigos)
                {
                    richTextBox1.Text = richTextBox1.Text + item.User + "\n";
                }
            }
            codetxt.Text = ""; nametxt.Text = "";
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Inicio f = new Inicio(usuario, sistema);
            f.Show();
            this.Hide();
        }

        private void VerCodigo_Click(object sender, EventArgs e)
        {
            usuario.MostrarNumAmigo();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            usuario.ObtenerMiNumAmigo(sistema);
        }


        private void VentanaAmigos_Load(object sender, EventArgs e)
        {
            if (usuario.Amigos != null)
            {
                foreach (Usuario item in usuario.Amigos)
                {
                    richTextBox1.Text = richTextBox1.Text + item.User + "\n";
                }
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (usuario.EliminarAmigo(nombre.Text, sistema) != 0)
            {
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                foreach(Usuario item in sistema.Usuarios)
                {
                    if (usuario.User == item.User)
                        usuario = item;
                }
                file.Close();
                MessageBox.Show($"Se ha logrado eliminar a {nombre.Text} de tu lista de amigos", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se ha encontrado a ningún usuario '{nombre.Text}' en tu lista de amigos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (usuario.Amigos != null)
            {
                richTextBox1.Clear();
                foreach (Usuario item in usuario.Amigos)
                {
                    richTextBox1.Text = richTextBox1.Text + "\n" + item.User;
                }
            }
            else
            {
                richTextBox1.Clear();
            }
            nombre.Text = "";
        }
    }
}
