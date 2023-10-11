namespace Control_de_ingresos
{
    public class Producto
    {
        private float precio;
        private string nombre;
        private string marca;
        private int cantidad;

        public Producto(float precio, string nombre, string marca, int cantidad) : this(marca, nombre)
        {
            this.precio = precio;
            this.Cantidad = cantidad;

        }

        public Producto(string marca, string nombre)
        {
            this.marca = marca;
            this.nombre = nombre;

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

    }
}
