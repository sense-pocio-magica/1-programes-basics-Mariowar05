namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el primer número, és el 3");
        var num1 = Console.ReadLine();
        int Num1 = Convert.ToInt16(num1);

        Console.WriteLine("Introdueix el segón número, és el 4");
        var num2 = Console.ReadLine();
        int Num2 = Convert.ToInt16(num2);

        Console.WriteLine("Introdueix el primer número, és el 25");
        var num3 = Console.ReadLine();
        int Num3 = Convert.ToInt16(num3);

        Console.WriteLine("Introdueix el segón número, és el 5");
        var num4 = Console.ReadLine();
        int Num4 = Convert.ToInt16(num4);


        Console.WriteLine("La suma és " + (Num1 + Num2) + ", la resta és " + (Num1 - Num2));
        Console.WriteLine("La multiplicació és " + (Num1 * Num2) + ", i la divisió és " + (Num1 / Num2));

        Console.WriteLine("La suma és " + (Num3 + Num4) + ", la resta és " + (Num3 - Num4));
        Console.WriteLine("La multiplicació és " + (Num3 * Num4) + ", i la divisió és " + (Num3 / Num4));






    }
}
