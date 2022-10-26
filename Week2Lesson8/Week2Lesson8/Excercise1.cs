using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise1
    {
        public static void run()
        {
            /*
             * 1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise1");
            Console.WriteLine("--------------\n");

            int counter = 0;
            int flag = 0;

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        flag = 1;
                    }

                }

                if (flag == 0)
                {
                    counter++;
                }

                flag = 0;
            }

            Console.WriteLine($"W zakresie od 0 do 100 znajduje się {counter} liczb pierwszych.");
           

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}