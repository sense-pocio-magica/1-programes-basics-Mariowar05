namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Posa una paraula");
        var nom = Console.ReadLine();

        var data1 = nom[nom.Length - 10];

        Console.WriteLine("La primera lletra és " + data1 + ", la segona és"  );


    }
}
