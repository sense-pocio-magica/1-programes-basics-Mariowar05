namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix la primera data");
        var data1 = Console.ReadLine();
        int Data1 = Convert.ToInt32(data1);

        Console.WriteLine("Introdueix la segona data");
        var data2 = Console.ReadLine();
        int Data2 = Convert.ToInt32(data2);

        var nom0 = data1[data1.Length - 8];

        var nom1 = data1[data1.Length - 7];

        var nom2 = data1[data1.Length - 6];

        var nom3 = data1[data1.Length - 5];

        var nom4 = data1.Substring(4);

        var nom5 = data2[data2.Length - 8];

        var nom6 = data2[data2.Length - 7];

        var nom7 = data2[data2.Length - 6];

        var nom8 = data2[data2.Length - 5];

        var nom9 = data2.Substring(4);

        Console.WriteLine("La teva data és"+ " " +nom0 + nom1 + "/" + nom2 + nom3+ "/" + nom4);
        Console.WriteLine("La teva data és"+ " " + nom5 + nom6 + "/" + nom7 + nom8 + "/" + nom9);
        
    }
}
