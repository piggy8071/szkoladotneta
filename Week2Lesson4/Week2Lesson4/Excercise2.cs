using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson4
{
    public class Excercise2
    {
        public static void run()
        {
            /*
             * Napisz program, w którym stworzysz 3 zmienne z jedną literą, 
             * a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise2");
            Console.WriteLine("--------------");

            char a = 'a', b = 'b', c = 'c';

            Console.WriteLine($"{c} {b} {a}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
