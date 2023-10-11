namespace Control_de_ingresos
{
    public abstract class Producto
    {
        private string tipo;
        private float precio;
        private string nombre;
        private string marca;
        private int cantidad;

        public Producto(string nombre,string tipo, string marca, int cantidad,float precio) : this(tipo,marca, nombre,cantidad)
        {
            this.precio = precio;
            
        }

        public Producto(string tipo,string marca, string nombre,int cantidad):this(marca)
        {
            this.nombre = nombre;
            this.Cantidad = cantidad;
            this.tipo = tipo;
        }
        protected Producto(string marca)
        {
            this.marca = marca;
            this.nombre = "Sin indentificar";    
            this.cantidad=1;
            this.precio=100f;
            this.tipo = "Desconocido";


        }

        public Producto()
        {
            
        }
        

        public float Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override bool Equals(object? obj)
        {
            return obj is Producto producto;

        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} --- Tipo:{Tipo} --- Marca: {Marca} --- Cantidad: {Cantidad} --- Precio: {Precio}";
        }

        public virtual void MiMetodoVirtual()
        {
            if (Marca == "arcor")
            {
                precio = precio * 1.3f;
            }

        }
        public abstract void CalcularTotal();

    }
}
