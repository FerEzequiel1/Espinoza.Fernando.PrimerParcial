using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_ingresos
{
    public class ListaProductos
    {
        private List<Producto> listaDeProductos;

        public ListaProductos(List<Producto> productos)
        {
            this.listaDeProductos = productos;
        }

        public List<Producto> ListaDeProductos { get => listaDeProductos; set => listaDeProductos = value; }

        public  void MostrarDetalles()
        {
            foreach (Producto producto in ListaDeProductos)
            {
                Console.WriteLine(producto.ToString());
            }

        }

        public static bool operator +(ListaProductos l, Producto p)
        {
            if (l != p)
            {
                l.ListaDeProductos.Add(p);
                return true;
            }
            return false;
        }
        public static bool operator -(ListaProductos l, Producto p)
        {
            if (l == p)
            {
                l.ListaDeProductos.Remove(p);
                return true;
            }
            return false;
        }
        

        public static bool operator ==(ListaProductos l, Producto p)
        {
            foreach (Producto producto in l.ListaDeProductos)
            {
                if (producto.Equals(p))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(ListaProductos e, Producto p)
        {
            return (!(e == p));
        }

        public void OrdenPorPrecioCantidad(string orden,string tipo)
        {
            List<Producto> listaOrdenada;


            if (orden == "Ascendente" && tipo == "Precio total")
            {
                listaOrdenada = listaDeProductos.OrderBy(producto => producto.PrecioTotal()).ToList();
            }
            else if (orden != "Ascendente" && tipo == "Precio total")
            {
                listaOrdenada = listaDeProductos.OrderByDescending(producto => producto.PrecioTotal()).ToList();
            }
            else if (orden == "Ascendente" && tipo == "Cantidad")
            {
                listaOrdenada = listaDeProductos.OrderBy(producto => producto.Cantidad).ToList();
            }
            else
            {
                listaOrdenada = listaDeProductos.OrderByDescending(producto => producto.Cantidad).ToList();
            }

            listaDeProductos = listaOrdenada;

        }

    }
}
