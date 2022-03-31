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
    public partial class Registrarse : Form
    {
        Sistema sistema;
        public Registrarse(Sistema aux)
        {
            sistema = aux;
            InitializeComponent();
        }
        List<Usuario> Usuarios = new List<Usuario>();
        

        public bool ControlarContra(string contraa, string contraaa)
        {
            if (contraa == contraaa)
                return true;
            else
                return false;
        }
        public bool ControlarUsuarioCorreo(string user, string correoo)
        {
            Usuarios = sistema.Usuarios;
            bool bande = true;
            foreach (Usuario item in Usuarios)
            {
                if (item.User == user || item.Correo == correoo)
                    bande = false;
            }
            return bande;
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            bool Contrasena = this.ControlarContra(contra.Text, contra2.Text);
            bool NombreUsuario = this.ControlarUsuarioCorreo(nombreuser.Text, correo.Text);
            if (Contrasena==true && NombreUsuario==true)
            {
                Usuario usuario = new Usuario(nombre.Text, apellido.Text, nombreuser.Text, contra.Text);
                usuario.Correo = correo.Text;
                //Serializar
                sistema.Usuarios.Add(usuario);
                var file = new FileStream("c:\\temp\\sistema.dat", FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(file, sistema);
                file.Close();
                MessageBox.Show("¡FELICIDADES!\n¡Ha sido registrado! Ya puede iniciar sesión", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Principal f = new Principal(sistema);
                f.Show();
                this.Hide();
            }
            else
            {
                if(NombreUsuario==false)
                    MessageBox.Show("Lo sentimos...\nEl correo y/o nombre de usuario ya ha sido utilizado\nPor favor, ingrese nuevos datos", "FRACASO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Lo sentimos...\nLas contraseñas no coinciden\nPor favor, ingrese de nuevo los datos", "FRACASO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nombre.Text = "";nombreuser.Text = "";contra.Text = ""; contra2.Text = ""; correo.Text = "";apellido.Text = "";
            }
            
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Principal f = new Principal(sistema);
            f.Show();
            this.Hide();
        }
    }
}
