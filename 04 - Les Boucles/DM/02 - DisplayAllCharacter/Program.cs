using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombrMax = HelperRead.ReadInt();
            int nombrAct = 0;
            int nombrMinChar = 33 + nombrAct;
            

            while(nombrMinChar <= nombrMax + 32)
            {
                char charac = (char)nombrMinChar;
                Console.Write(charac + ", ");
                nombrMinChar++;
            }
        }
    }
}