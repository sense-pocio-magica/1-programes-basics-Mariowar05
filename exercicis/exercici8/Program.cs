namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quants minuts hi vols?");
        var Hora = Console.ReadLine();
        int Hour = Convert.ToInt16(Hora);

        int dia = 60;

        int resulH = Hour/dia;
        int resulM = Hour % 60;

        Console.WriteLine("N'hi han " + resulH + " " + "hores senceres" + ", amb" + resulM +"minuts" );


    }
}
