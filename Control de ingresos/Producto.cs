namespace Control_de_ingresos
{
    public abstract class Producto
    {
        private float precio;
        private string nombre;
        private string marca;
        private int cantidad;

        public Producto(float precio, string nombre, string marca, int cantidad) : this(marca,nombre,cantidad)
        {
            this.precio = precio;
        }

        public Producto(string marca, string nombre,int cantidad):this(marca)
        {
            this.nombre = nombre;
            this.Cantidad = cantidad;
        }
        protected Producto(string marca)
        {
            this.marca = marca;
        }

        public Producto()
        {

        }


        public float Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public override bool Equals(object? obj)
        {
            return obj is Producto producto;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(precio, nombre, marca, Precio, Nombre, Marca);
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} --- Marca: {Marca} --- Cantidad: {Cantidad}--- Precio: {Precio}";
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
