using System;

namespace DM
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthToColor MTC = new MonthToColor();
            MTC.EnumMois();

            ValidInput VI = new ValidInput();
            bool keyprogram = VI.Input();
            while(keyprogram != false)
            {
                keyprogram = VI.Input();
            }
            Console.WriteLine("Bravo vous savez appuyer sur les touches autorisées :)!");

        }
    }
}
