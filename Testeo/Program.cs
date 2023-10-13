using Control_de_ingresos;

internal class Program
{
    private static void Main(string[] args)
    {
        Arroz arroz = new Arroz("Arroz blanco","Arroz","3 galloss",3,100f);
        Arroz arroz2 = new Arroz("Arroz blanco2", "Arroz", "3 gallos", 3, 155f);
        Arroz arroz3 = new Arroz("Arroz blanco2", "Arroz2", "3 gallos", 3, 155f);
        Gaseosa mirinda = new Gaseosa("pepsi", "Arroz", "3 gallos", 3, 200f,3f,"Naranja");
        Gaseosa mirinda1 = new Gaseosa("seven up", "Arrsoz", "3 galloss", 3, 155f);
        Salchicha unPaquete = new Salchicha("Papu", "Salchicha", "La vienissima", 4, 155f);
        Salchicha unPaquete2 = new Salchicha("Paspu", "Salchicha", "La vienissima", 4, 200f);
        Salchicha unPaquete3 = new Salchicha("Paspusssssssssssssss", "Salchicha", "La vienissima", 4, 200f);
        Salchicha mirind = new Salchicha("Mirinda", "Gaseosa", "Fanta", 4, 150f);
        Salchicha unPaquete4 = new Salchicha("Paspuuu", "Salchiasdadasdcha", "La vieniadasdasdssima", 4, 200f);


        List <Producto> productos   = new List<Producto>();

        productos.Add(arroz);
        productos.Add(arroz2);
        productos.Add(arroz3);
        productos.Add(mirinda);

        ListaProductos estante = new(productos);

        estante.MostrarDetalles();










    }
}