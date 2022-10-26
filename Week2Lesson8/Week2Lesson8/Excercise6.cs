using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise6
    {
        public static void run()
        {
            /*
             * Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ + 1/3 + ¼ itd.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise6");
            Console.WriteLine("--------------\n");

            double result = 0;

            for (double i = 1; i <= 20; i++)
            {
                result = result + 1 / i;
            }
            Console.Write("Result:" + result);


            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}