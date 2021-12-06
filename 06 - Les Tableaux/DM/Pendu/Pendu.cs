using System;

namespace DM
{
    class Pendu
    {
        static void Main(string[] args)
        {
            //Ce bool est notre indicateur de difficulté. False c'est normal et True tourne en difficile.
            bool difficulté = ChooseYourDifficulty();
            //C'est le mot choisi
            string motEntré = SaisieDeMot(difficulté);
            //Voila le nombre de coups attribués
            int nombreDeCoup = NombreDeCoup(difficulté);
            int NombreRécompense = 0;
            //Ici on a les tableau de char, un plein du mot choisi, l'autre vide et enfin une copie du vide pour comparaison.
            char[] monTableauMot = motEntré.ToCharArray();
            char[] monTableauVide = new char[monTableauMot.Length];
            char[] monTableauVideCopie = new char[monTableauVide.Length];

            //Les tableaux vides sont remplis d'étoiles selon la taille du tableau contenant le mot.
            for (int i = 0; i <= monTableauVide.Length - 1; i++)
            {
                monTableauVide[i] = '*';
                monTableauVideCopie[i] = '*';

            }
//Ce for fait tourner cette boucle tant qu'il reste des coups au joueur.
            for (int j = 0; j <= nombreDeCoup;)
            {
                //On initie le programme de tour
                monTableauVide = Tour(monTableauMot, monTableauVide, motEntré);
                //Le tableau vide est réécrit pour voir si des valeurs ont étés découvertes.
                for (int k = 0; k <= monTableauVide.Length - 1; k++)
                {
                    Console.Write(monTableauVide[k]);


                }
                Console.WriteLine();
                //Ici le jeu vérifie le nombre de lettres devinées. Si elles le sont toutes le joueur gagne.
                NombreRécompense = 0;
                for (int k = 0; k <= monTableauVide.Length - 1; k++)
                {
                    if (monTableauVide[k] == monTableauMot[k])
                    {
                        NombreRécompense++;
                        if (NombreRécompense == monTableauMot.Length)
                        {
                            Console.WriteLine("Bravo! Vous avez gagné! Il vous aura fallu " + j + " coups.");
                            return;

                        }
                    }
                }
                //Si le tableau vide est identique à sa copie ça veut dire qu'il a été renvoyé sans bonne réponse, et donc que le joueur perds un tour.
                if (monTableauVide == monTableauVideCopie)
                {
                    Console.WriteLine("Oh non, votre lettre n'était pas présente dans le mot!");
                    j++;
                    //J est le nombre de tour utilisé, et fait varier le switch VieDuPendu qui affiche le pendu.
                    VieDuPendu(j, difficulté);
                    Console.WriteLine("Il vous reste " + (nombreDeCoup - j) + " coups.");
                    monTableauVideCopie = monTableauVide;

                }
                //La défaite est affichée ici si tout les coups sont épuisés.
                if (j == nombreDeCoup)
                {
                    Console.WriteLine("Vous avez perdu! le mot était " + motEntré);
                }
            }
        }

        static bool ChooseYourDifficulty()
        {
            //La difficulté est choisie ici avec deux lettres, renvoyant un bool.
            bool difficulté;
            Console.WriteLine("Veuillez Sélectionner votre difficulté :");
            Console.WriteLine("Normal : N");
            Console.WriteLine("Difficile : D");
            string réponse = Console.ReadLine().ToLower();

            while (réponse != "n" || réponse != "d")
            {
                switch (réponse)
                {
                    case "n":
                        Console.WriteLine("Vous avez sélectionné la difficulté Normal. Bon jeu!");
                        return difficulté = false;
                    case "d":
                        Console.WriteLine("Vous avez sélectionné la difficulté Difficile. Bon jeu!");
                        return difficulté = true;
                }
            }

            return difficulté = false;
        }

        static string SaisieDeMot(bool difficulté)
        {
            string motChoisie;
            //La fonction choisi aléatoirement un mot en fonction de la difficulté attribuée.

            string[] motDe4a6 = new string[] { "meme", "mercy", "stand", "hamon", "pepe", "stonks", "floyd", "juan" };
            string[] motDe8a10 = new string[] { "america", "poggers", "mozambique", "rotatory", "adventure", "christmas", "computer", "wallride" };
            Random random = new Random();

            if (!difficulté)
            {
                motChoisie = motDe4a6[random.Next(1, 8)];
            }
            else
            {
                motChoisie = motDe8a10[random.Next(1, 8)];
            }

            return motChoisie;
        }

        static int NombreDeCoup(bool difficulté)
        //Ici le int de coups varie selon la difficulté.
        {
            int nombreDeCoup;
            if (!difficulté)
            {
                nombreDeCoup = 15;

            }
            else
            {
                nombreDeCoup = 12;
            }

            return nombreDeCoup;
        }

        static char[] Tour(char[] monTableauPlein, char[] monTableauVide, string motEntré)
        {
            //C'est ici que tout le tour se passe. La fonction demande un mot/lettre, si le mot est bon elle fait gagnée, si la lettre est bonne elle l'ajoute au tableau vide, sinon elle renvoi le tableau tel quel.
            Console.WriteLine("Entrez une lettre ou un mot");
            string lettreEntrée = Console.ReadLine();
            char lettre;

            for (int i = 0; i <= monTableauPlein.Length - 1; i++)
            {
                if (lettreEntrée == motEntré)
                {
                    for (int j = 0; j <= monTableauPlein.Length - 1; j++)
                    {
                        monTableauVide[j] = monTableauPlein[j];
                    }
                    break;
                }
                for (int g = 0; g <= monTableauVide.Length - 1; g++)
                {
                    Console.Write(monTableauVide[g]);
                }
                if (char.TryParse(lettreEntrée, out lettre))
                {


                    lettre = char.Parse(lettreEntrée);
                    if (lettre == monTableauPlein[i])
                    {
                        monTableauVide[i] = monTableauPlein[i];
                    }
                }
            }
            for (int g = 0; g <= monTableauVide.Length - 1; g++)
            {
                Console.Write(monTableauVide[g]);
            }
            return monTableauVide;
        }

        static void VieDuPendu(int j, bool difficulté)
        //Ici le pendu est affiché selon la valeur de J. Plus elle est haute, plus le joueur a jouer de tours, plus il est proche de perdre.
        {
            if (!difficulté)
                switch (j)
                {
                    case 1:
                        Console.WriteLine("  0");
                        break;
                    case 2:
                        Console.WriteLine("  0");
                        Console.WriteLine("-");
                        break;
                    case 3:
                        Console.WriteLine("  0");
                        Console.WriteLine("--");
                        break;
                    case 4:
                        Console.WriteLine("  0");
                        Console.WriteLine("---");
                        break;
                    case 5:
                        Console.WriteLine("  0");
                        Console.WriteLine("----");
                        break;
                    case 6:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----");
                        break;
                    case 7:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        break;
                    case 8:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        break;
                    case 9:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        break;
                    case 10:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        break;
                    case 11:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine(" /");
                        break;
                    case 12:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine(" /");
                        Console.WriteLine("/");
                        break;
                    case 13:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine(" / \\ ");
                        Console.WriteLine("/");
                        break;
                    case 14:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine(" / \\ ");
                        Console.WriteLine("/   \\");
                        break;
                    case 15:
                        Console.WriteLine("  |");
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine(" / \\ ");
                        Console.WriteLine("/   \\");
                        break;

                }
            else
            {
                switch (j)
                {
                    case 1:
                        Console.WriteLine(" 0");
                        break;
                    case 2:
                        Console.WriteLine(" 0");
                        Console.WriteLine("-");
                        break;
                    case 3:
                        Console.WriteLine(" 0");
                        Console.WriteLine("--");
                        break;
                    case 4:
                        Console.WriteLine(" 0");
                        Console.WriteLine("---");
                        break;
                    case 5:
                        Console.WriteLine(" 0");
                        Console.WriteLine("----");
                        break;
                    case 6:
                        Console.WriteLine(" 0");
                        Console.WriteLine("----");
                        Console.WriteLine(" |");
                        break;
                    case 7:
                        Console.WriteLine(" 0");
                        Console.WriteLine("----");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 8:
                        Console.WriteLine(" 0");
                        Console.WriteLine("----");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 9:
                        Console.WriteLine(" 0");
                        Console.WriteLine("----");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("/");
                        break;
                    case 10:
                        Console.WriteLine("  0");
                        Console.WriteLine(" ----");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine(" /");
                        Console.WriteLine("/");
                        break;
                    case 11:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine(" / \\ ");
                        Console.WriteLine("/");
                        break;
                    case 12:
                        Console.WriteLine("  0");
                        Console.WriteLine("|----|");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine(" / \\ ");
                        Console.WriteLine("/   \\");
                        break;
                }
            }
        }
    }
}