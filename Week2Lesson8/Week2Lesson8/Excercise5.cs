using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise5
    {
        public static void run()
        {
            /*
             * Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise5");
            Console.WriteLine("--------------\n");

            double result = 0;

            for (double i = 1; i <=20; i++)
            {
                result = Math.Pow(i, 3);
                Console.Write(" " + result);
            }
            

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}