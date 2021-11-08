using System;

namespace _01___HelperRead
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez saisir les valeurs indiquer : ");
            int valueInt = HelperRead.ReadInt();
            int valueIntMinMax = HelperRead.ReadIntMinMax();
            float valueFloat = HelperRead.ReadFloat();
            float valueFloatMinMax = HelperRead.ReadFloatMinMax();

            Console.WriteLine("Vos valeurs sont : " + valueInt + ", " + valueIntMinMax + ", " + valueFloat + ", " + valueFloatMinMax + ".");
        }
    }
}
