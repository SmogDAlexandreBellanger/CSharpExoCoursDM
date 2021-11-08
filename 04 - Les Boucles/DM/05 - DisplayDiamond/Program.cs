using System;

namespace _05___DisplayDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombrRang = HelperRead.ReadInt();
            int nombrAct = 1;
            int nombrActII = 1;
            int invertNombrAct = 2;
            int invertNombrActII = 3;
            int nombrInf = nombrAct;
            int nombrMax = nombrRang;
            int nombrEtoile = nombrRang * 2 - 1;
            int nombrEtoileII = nombrEtoile;

            while(nombrAct <= nombrRang)
            {
                nombrInf = 1;

                nombrMax = nombrRang;

                while(nombrMax >= nombrAct)
                {
                    Console.Write(" ");
                    nombrMax--;
                }
                while(nombrInf <= nombrActII)
                {
                    Console.Write("*");
                    nombrInf++;

                }
                Console.WriteLine("");
                nombrAct++;
                nombrActII += 2;
            }

            while(nombrAct >= 3)
            {
                nombrInf = nombrEtoile;
                nombrMax = 1;
                while(nombrMax <= invertNombrAct)
                {
                    Console.Write(" ");
                    nombrMax++;
                }
                while(nombrInf >= invertNombrActII)
                {
                    Console.Write("*");
                    nombrInf--;
                }
                Console.WriteLine("");
                nombrAct--;
                invertNombrAct++;
                invertNombrActII += 2;

            }
        }
    }
}
