namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina és la primera nota?");
        var Nota1 = Console.ReadLine();
        int N1 = Convert.ToInt16(Nota1);

        Console.WriteLine("I la segona?");
        var Nota2 = Console.ReadLine();
        int N2 = Convert.ToInt16(Nota2);

        Console.WriteLine("I la tercera?");
        var Nota3 = Console.ReadLine();
        int N3 = Convert.ToInt16(Nota3);

        int resultat = N1 + N2 + N3;

        int ResFin = resultat / 3;

        Console.WriteLine("La teva mitjana és " + ResFin);


    }
}
