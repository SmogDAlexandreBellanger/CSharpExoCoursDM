using System;

namespace Paird_Impair
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbr;

            Console.WriteLine("Bonjour, veuillez saisir un nombre, pair ou impair.");
            nmbr = int.Parse(Console.ReadLine());

            if(nmbr % 2 == 0)
            {
                Console.WriteLine("Votre nombre est pair!");
            }
            else
            {
                Console.WriteLine("Votre nombre est impair!");
            }
        }
    }
}
