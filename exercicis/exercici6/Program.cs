namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("El perímetre d'un quadrat és la suma de tots els seus costats");
        var Costat1 = Console.ReadLine();
        int C1 = Convert.ToInt16(Costat1);

        var Costat2 = Console.ReadLine();
        int C2 = Convert.ToInt16(Costat2);

        var Costat3 = Console.ReadLine();
        int C3 = Convert.ToInt16(Costat3);

        var Costat4 = Console.ReadLine();
        int C4 = Convert.ToInt16(Costat4);

        int Costat12 = C1 + C2;
        int Costat34 = C3 + C4;

        Console.WriteLine("El perímetre del quadrat és" + ", " + (Costat12+Costat34) +" " +"m2");


    }
}
