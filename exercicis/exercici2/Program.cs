namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A quin carrer vius?");
        var carrer = Console.ReadLine();

        Console.WriteLine("I el número?");
        var número = Console.ReadLine();
        int number = Convert.ToInt16(número);

        Console.WriteLine("I el codí postàl?");
        var codi = Console.ReadLine();
        int code = Convert.ToInt16(codi);

        Console.WriteLine("I la població on vius?");
        var poble = Console.ReadLine();

        Console.WriteLine("Vius al " + carrer + ", amb el número " + número + " " + "el codi postal " + codi + " " + "a la població de" + " " + poble);

        



    }

}
