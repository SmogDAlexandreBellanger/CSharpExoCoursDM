using System;

namespace DM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables de la fonction palindrome
            Console.WriteLine("Saisissez un mot / une phrase");
            string unString = Console.ReadLine();
            string unStringMini = unString.ToLower();
            bool palindrome = Palindromes(unStringMini);
            
            //Vérifie le bool "palindrome" renvoyer par la fonction Palindrome en fonction du résultat
            if(palindrome == false)
            {
                Console.WriteLine(unString + " n'est pas un palindrome");
            }
            else if(palindrome == true)
            {
                Console.WriteLine(unString + " est bien un palindrome");
            }

            //Variable utilisées par la fonction AlphabetDésordonnée

            char[] tableauDésordoné = MonTableauAlphabétique();

            //Le tableau est affiché dans l'ordre alphabétique.
            Console.WriteLine();
            Console.Write("Les valeurs du tableau dans le bon ordre sont :");
            for(int i = 0; i <= tableauDésordoné.Length - 1; i++)
            {
                
                Console.Write(" " + tableauDésordoné[i]);
            }
            //On entre ici les variables string qui seront remises dans l'ordre
            Console.WriteLine();
            Console.Write("Entrez 4 mots différents");

                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();
                string string3 = Console.ReadLine();
                string string4 = Console.ReadLine();

                string[] arrangementDeString = RangementDeString(string1, string2, string3, string4);
        }

        static bool Palindromes(string monString)
        {
            bool isPalindrome = false;
            char[] monTableauChar = monString.ToCharArray();
            int intAlEndroit = 0;
            int intAlEnvers = monTableauChar.Length - 1;


            //le "compteur" compte chaque emplacements pour savoir quand sortir du for 
            for(int compteur = 0;compteur <= monTableauChar.Length - 1; intAlEndroit++, intAlEnvers--, compteur++)
            {
                //Ici le programme détecte si l'emplacement contient bien une lettre, si non, il passe cet emplacement en ajoutant à la variable.
                if(!Char.IsLetter(monTableauChar[intAlEndroit]))
                {
                    intAlEndroit++;
                    compteur++;
                }
                if(!Char.IsLetter(monTableauChar[intAlEnvers]))
                {
                    intAlEnvers--;
                    compteur++;
                }
                else
                {
                    //Chaque if monte/descends sur la tableau. Ils comparent la lettre dans leur emplacements et détectent si elles sont identiques.
                    if(monTableauChar[intAlEndroit] == monTableauChar[intAlEnvers])
                    {
                       isPalindrome = true;
                    }
                    else
                    {
                       return isPalindrome = false;
                    }
                }
                

            }

            return isPalindrome;

        }

        static char[] MonTableauAlphabétique()
        {
            //On définie un tableau duquel on va prendre des lettres au hasard
            char[] alphabet = new char[26]{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            Random random = new Random();
            
            //On définie le nombre d'emplacements dans notre nouveau tableau
            char[] tableauAlphaDéso = new char[26];

            //Ce for défile sur les valeurs et les attribuent au hasard
            for(int i = 0; i <= tableauAlphaDéso.Length - 1; i++)
            {
                
                tableauAlphaDéso[i] = alphabet[random.Next(0, 26)];
                //Cette valeur renvoie à une fonction qui regarde si la valeur a déja été attribuée dans le tableau. Elle renvoi un bool qui dit si il faut la re-ditribuer ou non.
                while(contains(tableauAlphaDéso, tableauAlphaDéso[i], i))
                {
                  tableauAlphaDéso[i] = alphabet[random.Next(0, 26)];   
                }
            }
            //Le tableau est affiché.
            Console.Write("Les valeurs du tableau sont :");
            for(int i = 0; i <= tableauAlphaDéso.Length - 1; i++)
            {
                
                Console.Write(" " + tableauAlphaDéso[i]);
            }
            //On envoi le tableau pour qu'il soit trier par la fonction "Order"

            tableauAlphaDéso = Order(tableauAlphaDéso);

            return tableauAlphaDéso;
        }


        static bool contains(char[] tableauAlphaDéso, char c, int max)
        {
            //La fonction vérifie que la valeur n'est pas déja attribuée et renvoi un bool.
            bool res = false;
            for (int i = 0; i < max; i++)
  {
    if (tableauAlphaDéso[i] == c) 
    {
      res = true;
    }
  }
  return res;
}
static char[] Order(char[] tableauAlphaDéso)
//Cette fonction tri le tableau.
{

    Array.Sort(tableauAlphaDéso);
    return tableauAlphaDéso;
}
static string[] RangementDeString(string string1, string string2, string string3, string string4)
{
    //On établi le tableau en y entrant les variables dans chaque spots.
    string[] tableauDeString = {string1, string2, string3, string4};
//Voila donc le tableau comme il est entré de base.
Console.WriteLine("Vous avez entré :");
    for(int i = 0; i <= tableauDeString.Length - 1; i++)
            {
                
                Console.WriteLine(" " + tableauDeString[i]);
            }
            Array.Sort(tableauDeString);
//Et ici quand il ressort trié par Array.Sort
Console.WriteLine();
Console.WriteLine("Voila votre tableau ré-arrangé dans l'ordre alphabétique :");
            for(int i = 0; i <= tableauDeString.Length - 1; i++)
            {
                
                Console.WriteLine(" " + tableauDeString[i]);
            }

    return tableauDeString;
}
    }

    
    
}


