using System;

namespace _3Invincible
{
    class Program
    {
        static void Main(string[] args)
        {
            int pdv = 100;
            bool invincible = true;
            int dmg;

            Console.WriteLine("Veuillez saisir un montant de dégats.");
            dmg = int.Parse(Console.ReadLine());
            if(dmg >= 100)
            {
                Console.WriteLine("Montant de dégats trop haut!");
                dmg = 0;
            }            
            Console.WriteLine("Ouch! Il vous reste " + (pdv -= dmg) + " point de vies.");
            Console.WriteLine("Soin des blessures. Invincibilité activée.");
            invincible = true;
            pdv = 100;
            Console.WriteLine("Veuillez saisir une nouvelle fois un montant de dégats.");
            dmg = int.Parse(Console.ReadLine());

            if(invincible == true)
            {
                Console.WriteLine("Ping! Vous êtes invincibles, vous n'avez pris aucun dégat. Vous avez toujours " + pdv + " points de vie.");
            }
            else
            {
                Console.WriteLine("Ouch! Il vous reste " + (pdv -= dmg) + " point de vies.");
            }


        }
    }
}
