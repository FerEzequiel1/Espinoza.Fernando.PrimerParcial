using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_ingresos
{
    public class Arroz:Producto
    {
        private string origen;
        private string porveedor;

       
        public Arroz(string nombre, string tipo, string marca, int cantidad, float precio,string origen,string proveedor) : base(nombre,tipo, marca, cantidad,precio)
        {
            this.origen = origen;
            this.porveedor = proveedor;
        }
        public Arroz(string nombre, string tipo, string marca, int cantidad, float precio, string origen) : this(nombre, tipo, marca, cantidad, precio, origen,"Desconocido")
        {
          
        }
        public Arroz(string nombre, string tipo, string marca, int cantidad, float precio) : this(nombre, tipo, marca, cantidad, precio, "Desconocido")
        {

        }

        public Arroz()
        {
            
        }

        

        public string Origen { get => origen; set => origen = value; }
        public string Porveedor { get => porveedor; set => porveedor = value; }

        public override void CalcularTotal()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"--- Origen: {Origen} --- Proveedor: {Porveedor}");

            return sb.ToString();
        }
    }
}
