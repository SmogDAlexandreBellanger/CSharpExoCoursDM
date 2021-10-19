using System;

namespace _4ColoredLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int pdv;

            Console.WriteLine("Bonjour, veuillez sélectionné votre total de Pv.");
            pdv = int.Parse(Console.ReadLine());

            if(pdv <= 0)
            {
                Console.WriteLine("NOIR");
            }
            if((pdv > 0) && (pdv < 21))
            {
                Console.WriteLine("ROUGE");
            }
            if((pdv > 20) && (pdv < 41))
            {
                Console.WriteLine("ORANGE");
            }
            if((pdv > 40) && (pdv < 61))
            {
                Console.WriteLine("JAUNE");
            }
            if(pdv > 60)
            {
                Console.WriteLine("VERT");
            }
        }
    }
}
