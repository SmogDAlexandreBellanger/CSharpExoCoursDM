using System;

namespace DM
{
    class ValidInput
    {

        /*[System.ComponentModel.TypeConverter(typeof(System.Windows.Input.KeyConverter))]
        public enum Key 
        {

        }
        public static class Keyboard
        {

        }*/

        public bool Input()
        {
            //ConsoleKey key = new ConsoleKey();

            bool keypressed = false;

            Console.WriteLine("Pressez la touche Droite, Gauche, Bas ou Haut.");
            //key = Console.ReadKey();


            if(Console.ReadKey().Key != ConsoleKey.LeftArrow || Console.ReadKey().Key != ConsoleKey.RightArrow || Console.ReadKey().Key != ConsoleKey.UpArrow || Console.ReadKey().Key != ConsoleKey.DownArrow)
            {
                Console.WriteLine("Say whaaaat");
                return keypressed = true;
            }

            else
            {
                return keypressed = false;

            }
            
                        

        }

    }
}
