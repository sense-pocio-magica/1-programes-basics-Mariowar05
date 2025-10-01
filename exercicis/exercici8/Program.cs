namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina hora és?");
        var Hora = Console.ReadLine();
        int Hour = Convert.ToInt16(Hora);

        Console.WriteLine("I quants minuts?");
        var Minuts = Console.ReadLine();
        int Minutes = Convert.ToInt16(Minuts);

        int Dia = 24;

        int dia = 60;

        int resulH = Dia - Hour;
        int resulM = dia - Minutes;

        Console.WriteLine("Ara són lés" + " " + resulH + ", amb " + resulM + " " + "minuts");


    }
}
