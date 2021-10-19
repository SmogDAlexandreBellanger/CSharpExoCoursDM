using System;

namespace _7EnToutesLettres
{
    class Program
    {
        static void Main(string[] args)
        {
            int chiffre;

            Console.WriteLine("Bonjour! Veuillez saisir un chiffre entre 0 et 9.");
            chiffre = int.Parse(Console.ReadLine());

            switch(chiffre)
            
            {
                case (0):
                Console.WriteLine(chiffre + " s'épele Z-E-R-O");
                break;

                case (1):
                Console.WriteLine(chiffre + " s'épele U-N");
                break;

                case (2):
                Console.WriteLine(chiffre + " s'épele D-E-U-X");
                break;

                case (3):
                Console.WriteLine(chiffre + " s'épele T-R-O-I-S");
                break;

                case (4):
                Console.WriteLine(chiffre + " s'épele Q-U-A-T-R-E");
                break;

                case (5):
                Console.WriteLine(chiffre + " s'épele C-I-N-Q");
                break;

                case (6):
                Console.WriteLine(chiffre + " s'épele S-I-X");
                break;

                case (7):
                Console.WriteLine(chiffre + " s'épele S-E-P-T");
                break;
                
                case (8):
                Console.WriteLine(chiffre + " s'épele H-U-I-T");
                break;

                case (9):
                Console.WriteLine(chiffre + " s'épele N-E-U-F");
                break;

                default:
                Console.WriteLine("Oups! Mauvais input.");
                break;
            }
        }
    }
}
