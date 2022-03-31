using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADondeVamos
{
    [Serializable]
    public class Charla
    {
        private string _temadecharla;
        private List<Orador> _oradores;
        private DateTime _horario;
        private DateTime _horariofin;
        public string TemadeCharla { get=>_temadecharla; set=>_temadecharla=value; }
        public List<Orador> Oradores { get => _oradores; set => _oradores = value; } //objeto Orador, Lista de oradores
        public DateTime Horario { get=>_horario; set=>_horario=value; }
        public DateTime HorarioFin { get=>_horariofin; set=>_horariofin=value; }

        public Charla(string tema, DateTime horario,DateTime horariofin)
        {
            TemadeCharla = tema;
            Horario = horario;
            HorarioFin = horariofin;
        }

        public void AsociarOradores(List<Orador> a)
        {
            Oradores = a;
        }

        public bool ValidarDatos(string nombre, string apellido, string tema, DateTime inicio, DateTime final)
        {
            bool bande = false;
            string mensaje = "";
            if (nombre != "")
            {
                if (apellido != "")
                {
                    if (tema != "")
                    {
                        if (DateTime.Compare(inicio, final) < 0)
                        {
                            if (DateTime.Compare(inicio, this.HorarioFin) < 0 && DateTime.Compare(inicio, this.Horario) >= 0)
                            {
                                if (DateTime.Compare(this.Horario, final) < 0 && DateTime.Compare(final, this.HorarioFin) <= 0)
                                {
                                    bande = true;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                mensaje += "Debe ingresar un nombre\n";
            }
            if (apellido == "")
            {
                mensaje += "Debe ingresar un apellido\n";
            }
            if (tema == "")
            {
                mensaje += "Debe ingresar un tema\n";
            }
            if (DateTime.Compare(inicio, final) >= 0)
            {
                mensaje += "La fecha de inicio de la intracharla del Orador debe ser menor a la fecha final\n";
            }
            if (DateTime.Compare(inicio, this.HorarioFin) >= 0 || DateTime.Compare(inicio, this.Horario) < 0)
            {
                mensaje += "La fecha de inicio de la intracharla del Orador debe ser menor a la fecha final de la Charla\n";
                mensaje += "Y la fecha de inicio de la intracharla del Orador debe ser mayor o igual a la fecha de inicio de la Charla\n";
            }
            if (DateTime.Compare(this.Horario, final) >= 0 || DateTime.Compare(final, this.HorarioFin) > 0)
            {
                mensaje += "La fecha final de la intracharla debe ser mayor a la fecha de inicio de la Charla\n";
                mensaje += "La fecha final de la intracharla debe ser menor o igual a la fecha final de la Charla\n";
            }
            if (bande == false)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bande;
        }
        //public void MostrarDatos()
        //{

        //}
    }
}
