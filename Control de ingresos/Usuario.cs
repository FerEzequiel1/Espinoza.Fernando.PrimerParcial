using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_ingresos
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave {set => clave = value; }
        public string Perfil { get => perfil; set => perfil = value; }


        public override string ToString()
        {
            return $"Usuario:{Nombre} {Apellido}";
        }
    }
}
