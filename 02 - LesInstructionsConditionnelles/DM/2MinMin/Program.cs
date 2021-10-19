using System;

namespace MinMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int nbmin = 3;

            Console.WriteLine("Bonjour, veuillez saisir la valeur de a.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la valeur de b.");
            b = int.Parse(Console.ReadLine());

            if(a < nbmin)
            {
                a = nbmin;
                Console.WriteLine("Valeur de a trop haute, valeur descendue à " + a + ".");
            }

            if(b < nbmin)
            {
                b = nbmin;
                Console.WriteLine("Valeur de b trop haute, valeur descendue à " + b + ".");
            }

            Console.WriteLine("La valeur a est de : " + a + " et b est de : " + b + ".");
        }
    }
}
