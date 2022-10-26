using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise2
    {
        public static void run()
        {
            /*
             * Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise2");
            Console.WriteLine("--------------\n");

            int i = 0;
            
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}, ");
                }

                i++;
            }
            while (i <= 1000);
      
            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}