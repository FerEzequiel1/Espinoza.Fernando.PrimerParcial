using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_ingresos
{
    public class Gaseosa:Producto
    {
        private float mll;
        private string sabor;


        public Gaseosa(string nombre, string tipo, string marca, int cantidad, float precio,float mll, string sabor) : base(nombre, tipo, marca, cantidad, precio)
        {
            this.mll = mll;
            this.sabor = sabor;
        }
        public Gaseosa(string nombre, string tipo, string marca, int cantidad, float precio, float mll) : this(nombre, tipo, marca, cantidad, precio, mll, "Tónica")
        {

        }
        public Gaseosa(string nombre, string tipo, string marca, int cantidad, float precio) : this(nombre, tipo, marca, cantidad, precio, 2.5f)
        {

        }

        public Gaseosa()
        {

        }
        public float Mll { get => mll; set => mll = value; }
        public string Sabor { get => sabor; set => sabor = value; }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"--- Mililitros: {Mll} --- Sabor: {Sabor}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public override void CalcularTotal()
        {
            Console.WriteLine("asd");
        }


    }
}
