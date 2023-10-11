using Control_de_ingresos;

internal class Program
{
    private static void Main(string[] args)
    {
        Arroz arroz = new Arroz("Arroz blanco","Arroz","3 gallos",3,155f);

        Gaseosa mirinda = new Gaseosa("Mirinda", "Gaseosa", "Fanta", 4, 150f);

        Console.WriteLine(mirinda.ToString()); 
    }
}