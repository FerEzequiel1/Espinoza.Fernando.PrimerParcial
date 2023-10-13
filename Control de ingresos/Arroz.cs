using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_ingresos
{
    public class Arroz:Producto
    {
        private string origen;
        private string porveedor;

       
        public Arroz(string nombre, string tipo, EMarca marca, int cantidad, float precio,string origen,string proveedor) : base(nombre,tipo, marca, cantidad,precio)
        {
            this.origen = origen;
            this.porveedor = proveedor;
            this.AjustarPrecio();
        }
        public Arroz(string nombre, string tipo, EMarca marca, int cantidad, float precio, string origen) : this(nombre, tipo, marca, cantidad, precio, origen,"Desconocido")
        {
          
        }
        public Arroz(string nombre, string tipo, EMarca marca, int cantidad, float precio) : this(nombre, tipo, marca, cantidad, precio, "Desconocido")
        {

        }

        public Arroz()
        {
            
        }


        public string Origen { get => origen; set => origen = value; }
        public string Porveedor { get => porveedor; set => porveedor = value; }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"--- Origen: {Origen} --- Proveedor: {Porveedor}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        internal override void AjustarPrecio() {
            if (Marca == (EMarca)Enum.Parse(typeof(EMarca), "Gallo"))
            {
                Precio = Precio * 1.3f;
            }
        }



        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Arroz))
            {
                return false;
            }

            return this == (Arroz)obj;

        }

        public static bool operator ==(Arroz a, Arroz b)
        {
            return a.Marca == b.Marca && a.Origen == b.Origen && a.Tipo == b.Tipo;
        }
        public static bool operator !=(Arroz a, Arroz b)
        {
            return !(a == b);
        }

        public static Arroz operator +(Arroz a, Arroz b)
        {
            return new Arroz("Combo Bolsa de Arroz", "Mezcla", (EMarca)Enum.Parse(typeof(EMarca), "Trapal"), a.Cantidad + b.Cantidad, (a.Precio + b.Precio) * 0.7f, "Argentina", "Trapal");
        }

       
    }
}
