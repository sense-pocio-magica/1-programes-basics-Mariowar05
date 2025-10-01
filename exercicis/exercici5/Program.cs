namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com et dius?");
        var nom = Console.ReadLine();

        Console.WriteLine("Quin any vas neixer?");
        var edat = Console.ReadLine();
        int Edat = Convert.ToInt16(edat);

        int  Any = 2025;

        Console.WriteLine("Hola " + nom + ". " + "Ja tens " + (Any-Edat) + " " + "anys?");

    }
}
