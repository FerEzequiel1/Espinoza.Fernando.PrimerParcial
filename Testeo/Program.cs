using Control_de_ingresos;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Arroz arroz1 = new Arroz("Arroz blanco","Arroz", (EMarca)Enum.Parse(typeof(EMarca), "Gallo"), 3,500f,"Argentina","Pablo");
        Arroz arroz2 = new Arroz("Arroz Integral", "Arroz", (EMarca)Enum.Parse(typeof(EMarca), "Gallo"), 5, 600f,"Argentina","Chacra Gonzalez");
        Arroz comboArroz = arroz1 + arroz2;

        Gaseosa gaseosa1 = new Gaseosa("Seven up", "Gaseosa", (EMarca)Enum.Parse(typeof(EMarca), "SevenUp"), 3, 500f,3f,"Lima");
        Gaseosa gaseosa2 = new Gaseosa("Pepsi", "Gaseosa", (EMarca)Enum.Parse(typeof(EMarca), "Pepsi"), 3, 500f, 3f, "Cola");

        Salchicha salchicha1 = new Salchicha("Trini", "Salchicha", (EMarca)Enum.Parse(typeof(EMarca), "Vienissima"), 4, 300f,12,"No");
        Salchicha salchicha2 = new Salchicha("Don Antonio", "Salchicha", (EMarca)Enum.Parse(typeof(EMarca), "Swift"), 4, 150f,6,"si");
        Salchicha comboSalchicha = salchicha1 + salchicha2;

        List<Producto> productos   = new List<Producto>();

        productos.Add(arroz1);
        productos.Add(arroz2);
        productos.Add(comboArroz);
        productos.Add(gaseosa1);
        productos.Add(gaseosa2);
        productos.Add(salchicha1);
        productos.Add(salchicha2);
        productos.Add(comboSalchicha);

        ListaProductos listaDeProductos = new(productos);

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        path += @"\Mayorista Trapal";

        Producto.Serializar(listaDeProductos, path);
        //listaDeProductos = Producto.Deserializar(path);

        





    }





















}
