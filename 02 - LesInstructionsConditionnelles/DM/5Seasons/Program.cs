using System;

namespace _5Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;

            Console.WriteLine("Bonjour! Veuillez saisir un mois");
            month = Console.ReadLine();

            switch(month)
            
            {
                case ("janvier"):
                Console.WriteLine("Nous sommes en Hiver.");
                break;

                case ("février"):
                Console.WriteLine("Nous sommes en Hiver.");
                break;

                case ("mars"):
                Console.WriteLine("Nous sommes au Printemps.");
                break;

                case ("avril"):
                Console.WriteLine("Nous sommes au Printemps.");
                break;

                case ("mai"):
                Console.WriteLine("Nous sommes au Printemps.");
                break;

                case ("juin"):
                Console.WriteLine("Nous sommes au Eté.");
                break;

                case ("juillet"):
                Console.WriteLine("Nous sommes au Eté.");
                break;

                case ("aout"):
                Console.WriteLine("Nous sommes au Eté.");
                break;
                
                case ("septembre"):
                Console.WriteLine("Nous sommes au Automne.");
                break;

                case ("octobre"):
                Console.WriteLine("Nous sommes au Automne.");
                break;

                case ("novembre"):
                Console.WriteLine("Nous sommes au Automne.");
                break;

                case ("décembre"):
                Console.WriteLine("Nous sommes en Hiver.");
                break;

                default:
                Console.WriteLine("Oups! Mauvais input.");
                break;
            }
        }
    }
}
