using System;

namespace DM
{

    public class MonthToColor
    {
        //Déclaration des 3 enums
        public enum Saison
            {
                Hiver,
                Printemps,
                Eté,
                Automne
            }
        public enum Mois
            {
                Janvier,
                Février,
                Mars,
                Avril,
                Mai,
                Juin,
                Juillet,
                Aout,
                Septembre,
                Octobre, 
                Novembre,
                Décembre
            }
        public enum Colors
            {
                Blanc,
                Vert,
                Jaune,
                Rouge
            }
        public void EnumMois()
        {
            int moisEntré = HelperRead.ReadInt("Entrez un chiffre :");
            int saison = EnumSaison(moisEntré);
            int couleur = EnumCouleur(saison);

            Console.WriteLine("Le mois : " + ((Mois)moisEntré - 1) + " fait partie de la saison " + (Saison)saison + " et est de la couleur " + (Colors)couleur);
            

        } 

        static int EnumSaison(int mois)
        {
            int saison;
            switch(mois)
            {
                case 1:
                return saison = 0;
                break;

                case 2:
                return saison = 0;
                break;

                case 3:
                return saison = 1;
                break;

                case 4:
                return saison = 1;
                break;

                case 5:
                return saison = 1;
                break;

                case 6:
                return saison = 2;
                break;

                case 7:
                return saison = 2;
                break;

                case 8:
                return saison = 2;
                break;

                case 9:
                return saison = 3;
                break;

                case 10:
                return saison = 3;
                break;

                case 11:
                return saison = 3;
                break;

                case 12:
                return saison = 0;
                break;

                default:
                return saison = 0;
                break;
            }
        }

        static int EnumCouleur(int saisonEntrée)
        {
            int couleur;
            switch(saisonEntrée)
            {
                case 0:
                return couleur = 0;
                break;

                case 1:
                return couleur = 1;
                break;

                case 2:
                return couleur = 2;
                break;

                case 3:
                return couleur = 3;
                break;

                default:
                return couleur = 0;
                break;

            }
        }
    }
}
