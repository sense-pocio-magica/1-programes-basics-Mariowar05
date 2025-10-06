namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aquest producte es");
        var producte = Console.ReadLine();

        Console.WriteLine("El seu preu és");
        var preu = Console.ReadLine();
        int número = Convert.ToInt16(preu);

        bool no = false ;
        //var not = Console.ReadLine(no);

        Console.WriteLine("Aquest producte es " + producte + ", " + "el seu preu és" + " " + preu + "." );
        Console.WriteLine("Hi ha stock?" + " " + no + "."); 





    }
}
