using System;

namespace _04___DisplayTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombrEtoile = HelperRead.ReadInt();
            int nombrAct = 1;
            int nombrInf = nombrAct;

            while(nombrAct <= nombrEtoile)
            {
                nombrInf = 1;
                while(nombrInf <= nombrAct)
                {
                    Console.Write("*");
                    nombrInf++;

                }
                Console.WriteLine("");
                nombrAct++;
            }
        }
    }
}
