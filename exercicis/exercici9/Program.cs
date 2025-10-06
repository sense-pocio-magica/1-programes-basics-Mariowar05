namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quants metres vols convertir");
        var Meters = Console.ReadLine();
        int Metre = Convert.ToInt16(Meters);

        int Feet = 3; 

        Console.WriteLine("Els metres són" + " " +  Meters );
        Console.WriteLine("i els metres en peus són " + (Metre*Feet));


    }
}
