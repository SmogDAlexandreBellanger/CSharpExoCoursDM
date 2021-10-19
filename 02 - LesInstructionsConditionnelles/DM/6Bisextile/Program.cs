using System;

namespace _6Bisextile
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Bonjour! Veuillez saisir une année.");
            year = int.Parse(Console.ReadLine());

            if((year % 4 == 0) || (year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0))
            {
                Console.WriteLine("C'est bel et bien une année bisextile!");
            }
            else
            {
                Console.WriteLine("Ce n'est pas une année bisextile.");
            }
        }
    }
}
