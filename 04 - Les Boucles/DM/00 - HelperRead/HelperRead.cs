using System;

class HelperRead
{
    public static int ReadInt(string message = "Entrez une valeur entière : ")
    {
        if(string.IsNullOrWhiteSpace(message))
        {
            message = "Entrez une valeur entière : ";
        }

        Console.WriteLine(message);
        string saisie = Console.ReadLine();
        
        int value = 0;

        while(!int.TryParse(saisie, out value))
        {
            Console.WriteLine("Erreur de saisie !");
            Console.WriteLine(message);
            saisie = Console.ReadLine();
        }
        
        return value;
    }

    public static int ReadIntMinMax(string message = "Entrez une valeur entière entre 5 et 30 : ")
    {
        if(string.IsNullOrWhiteSpace(message))
        {
            message = "Entrez une valeur entière entre 5 et 30 : ";
        }

        Console.WriteLine(message);
        string saisie = Console.ReadLine();
        
        int value = 0;
        int max = 30;
        int min = 5;

        while(!int.TryParse(saisie, out value) || value <= min || value >= max)
        {
            Console.WriteLine("Erreur de saisie !");
            Console.WriteLine(message);
            saisie = Console.ReadLine();
        }
        
        return value;
    }


    public static float ReadFloat(string message = "Entrez une valeur décimale : ")
    {
        if(string.IsNullOrWhiteSpace(message))
        {
            message = "Entrez une valeur décimale : ";
        }

        Console.WriteLine(message);
        string saisie = Console.ReadLine();
        
        float value = 0;

        while(!float.TryParse(saisie, out value))
        {
            Console.WriteLine("Erreur de saisie !");
            Console.WriteLine(message);
            saisie = Console.ReadLine();
        }
        
        return value;
    }

    public static float ReadFloatMinMax(string message = "Entrez une valeur décimale entre 5 et 30 : ")
    {
        if(string.IsNullOrWhiteSpace(message))
        {
            message = "Entrez une valeur décimale entre 5 et 30 : ";
        }

        Console.WriteLine(message);
        string saisie = Console.ReadLine();
        
        float value = 0;
        float max = 30;
        float min = 5;

        while(!float.TryParse(saisie, out value) || value <= min || value >= max)
        {
            Console.WriteLine("Erreur de saisie !");
            Console.WriteLine(message);
            saisie = Console.ReadLine();
        }
        
        return value;
    }
}