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


        public Gaseosa(string nombre, string tipo, EMarca marca, int cantidad, float precio,float mll, string sabor) : base(nombre, tipo, marca, cantidad, precio)
        {
            this.mll = mll;
            this.sabor = sabor;
            this.AjustarPrecio();
        }
        public Gaseosa(string nombre, string tipo, EMarca marca, int cantidad, float precio, float mll) : this(nombre, tipo, marca, cantidad, precio, mll, "Tónica")
        {

        }
        public Gaseosa(string nombre, string tipo, EMarca marca, int cantidad, float precio) : this(nombre, tipo, marca, cantidad, precio, 2.5f)
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
        internal override void AjustarPrecio()
        {
            if(sabor == "Tónica")
            {
                Precio = Precio * 0.8f;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Gaseosa))
            {
                return false;
            }

            return this == (Gaseosa)obj;

        }

        public static bool operator ==(Gaseosa a, Gaseosa b)
        {
            return a.Sabor == b.Sabor && a.Mll == b.Mll && a.Tipo == b.Tipo;
        }
        public static bool operator !=(Gaseosa a, Gaseosa b)
        {
            return !(a == b);
        }

        public static Gaseosa operator +(Gaseosa a, Gaseosa b)
        {


            return new Gaseosa("Pack de gaseosas", "Mezcla", (EMarca)Enum.Parse(typeof(EMarca), "Trapal"), a.Cantidad + b.Cantidad, (a.Precio + b.Precio) * 0.7f, 3f, "Fantasia");

        }

       
    }
}
