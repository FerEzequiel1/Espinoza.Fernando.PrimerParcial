using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Control_de_ingresos
{
    public class GaseosaPorMayor:Gaseosa
    {
        private int unidades;
        private string artesanal;


        public GaseosaPorMayor(string nombre, string tipo, EMarca marca, int cantidad, float precio,float mililitros,string sabor, int unidades, string artesanal) : base(nombre, tipo, marca, cantidad, precio,mililitros,sabor)
        {
            this.unidades = unidades;
            this.artesanal = artesanal;
            this.AjustarPrecio();
        }
        public GaseosaPorMayor(string nombre, string tipo, EMarca marca, int cantidad, float precio, float mililitros, string sabor, int unidades) : this(nombre, tipo, marca, cantidad, precio, mililitros, sabor, unidades,"No")
        {

        }
        public GaseosaPorMayor(string nombre, string tipo, EMarca marca, int cantidad, float precio,float mililitros, string sabor) : this(nombre, tipo, marca, cantidad, precio, mililitros, sabor, 6)
        {

        }

        public GaseosaPorMayor()
        {

        }
        
        public int Unidades { get => unidades; set => unidades = value; }
        public string Artesanal { get => artesanal; set => artesanal = value; }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"--- Unidades: {Unidades} --- Es artesanal: {Artesanal} --- TOTAL: {this.PrecioTotal()}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        internal override void AjustarPrecio()
        {
            if(Artesanal == "No")
            {
                Precio = Precio * 0.9f;
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is GaseosaPorMayor))
            {
                return false;
            }

            return this == (GaseosaPorMayor)obj;

        }

        public static bool operator ==(GaseosaPorMayor a, GaseosaPorMayor b)
        {
            return a.Artesanal == b.Artesanal && a.Unidades == b.Unidades && a.Tipo == b.Tipo;
        }
        public static bool operator !=(GaseosaPorMayor a, GaseosaPorMayor b)
        {
            return !(a == b);
        }

        public static GaseosaPorMayor operator +(GaseosaPorMayor a, GaseosaPorMayor b)
        {

            return new GaseosaPorMayor("GaseosaX", "Mezcla", (EMarca)Enum.Parse(typeof(EMarca), "Trapal"), a.Cantidad + b.Cantidad, (a.Precio + b.Precio) * 0.7f,500f,"Uva",a.Unidades+b.Unidades,"No");

        }

    }
}
