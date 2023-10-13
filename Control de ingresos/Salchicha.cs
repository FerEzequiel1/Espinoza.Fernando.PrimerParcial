using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_ingresos
{
    public class Salchicha:Producto
    {
        private int unidades;
        private string tieneChancho;


        public Salchicha(string nombre, string tipo, EMarca marca, int cantidad, float precio, int unidades, string tieneChancho) : base(nombre, tipo, marca, cantidad, precio)
        {
            this.unidades = unidades;
            this.tieneChancho = tieneChancho;
            this.AjustarPrecio();
        }
        public Salchicha(string nombre, string tipo, EMarca marca, int cantidad, float precio, int unidades) : this(nombre, tipo, marca, cantidad, precio, unidades, "No")
        {

        }
        public Salchicha(string nombre, string tipo, EMarca marca, int cantidad, float precio) : this(nombre, tipo, marca, cantidad, precio, 6)
        {

        }

        public Salchicha()
        {

        }
        
        public int Unidades { get => unidades; set => unidades = value; }
        public string TieneChancho { get => tieneChancho; set => tieneChancho = value; }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"--- Unidades: {Unidades} --- Contiene chancho: {TieneChancho}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        internal override void AjustarPrecio()
        {
            if(TieneChancho == "No")
            {
                Precio = Precio * 0.9f;
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Salchicha))
            {
                return false;
            }

            return this == (Salchicha)obj;

        }

        public static bool operator ==(Salchicha a, Salchicha b)
        {
            return a.TieneChancho == b.TieneChancho && a.Unidades == b.Unidades && a.Tipo == b.Tipo;
        }
        public static bool operator !=(Salchicha a, Salchicha b)
        {
            return !(a == b);
        }

        public static Salchicha operator +(Salchicha a, Salchicha b)
        {

            return new Salchicha("Combo Salchica", "Mezcla", (EMarca)Enum.Parse(typeof(EMarca), "Trapal"), a.Cantidad + b.Cantidad, (a.Precio + b.Precio) * 0.7f, a.Unidades, "Si");

        }

    }
}
