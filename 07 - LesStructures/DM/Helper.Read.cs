using System;

class HelperRead
{
    public static int ReadInt(string message)
    {
        if(string.IsNullOrWhiteSpace(message))
        {
            message = "Entrez une valeur entière : ";
        }

        Console.WriteLine(message);
        string saisie = Console.ReadLine();
        
        int value = 0;

        while(!int.TryParse(saisie, out value) || int.Parse(saisie) >= 13)
        {
            Console.WriteLine("Erreur de saisie !");
            Console.WriteLine(message);
            saisie = Console.ReadLine();
        }
        
        return value;
    }
}