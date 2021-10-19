using System;

namespace _8Richter
{
    class Program
    {
        static void Main(string[] args)
        {
            int chiffre;

            Console.WriteLine("Bonjour! Quel est la hauteur du séisme? (0-9)");
            chiffre = int.Parse(Console.ReadLine());

            switch(chiffre)
            
            {
                case (1):
                Console.WriteLine(chiffre + " : Micro tremblement de terre, non ressenti");
                break;

                case (2):
                Console.WriteLine(chiffre + " : Très mineur. non ressenti mais détecté");
                break;

                case (3):
                Console.WriteLine(chiffre + " : Mineur. causant rarement des dommages");
                break;

                case (4):
                Console.WriteLine(chiffre + " : Léger. Secousses notables d’objets à l’intérieur des maisons");
                break;

                case (5):
                Console.WriteLine(chiffre + " : Modéré. Légers dommages aux édifices bien construits");
                break;

                case (6):
                Console.WriteLine(chiffre + " : Fort. Destructeur dans des zones allant jusqu’à 180 kilomètres à la ronde si elles sont peuplées");
                break;

                case (7):
                Console.WriteLine(chiffre + " : Majeur. Dommages modérés à sévères dans des zones plus vastes.");
                break;
                
                case (8):
                Console.WriteLine(chiffre + " : Important. Dommages sérieux dans des zones à des centaines de kilomètres à la ronde");
                break;

                case (9):
                Console.WriteLine(chiffre + " : Dévastateur.Dévaste des zones sur des milliers de kilomètres à la ronde");
                break;

                default:
                Console.WriteLine("Oups! Mauvais input.");
                break;
            }
        }
    }
}
