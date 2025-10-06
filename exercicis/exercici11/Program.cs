namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriu el teu nom d'usuari");
        var nom = Console.ReadLine();

        Console.WriteLine("Escriu el teu domini");
        var domini = Console.ReadLine();

        Console.WriteLine("La teva nova adreça electronica és " + nom + domini + "@gmail.com");


    }
}
