using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombrMax = HelperRead.ReadInt();
            int nombrAct = 0;

            while(nombrAct <= nombrMax)
            {
                if(nombrAct % 2 == 0)
                {
                Console.Write(nombrAct + ", ");
                }
                nombrAct++;
            }
        }
    }
}
