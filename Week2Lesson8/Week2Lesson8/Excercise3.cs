using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise3
    {
        public static void run()
        {
            /*
             * Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise3");
            Console.WriteLine("--------------\n");

            int number = 0;
            Console.WriteLine("How many elements of Fibonacci sequence you want to display?");

            Int32.TryParse(Console.ReadLine(), out number); 
            
            long a = 0;
            long b = 1;
            long c = 0;

            Console.Write("Ciąg Fibonacciego: " + a +" " + b);

            for (int i = 0; i <= number; i++)
            {
                c = a + b;
                a = b;
                b = c;
                

                Console.Write(" " + c);
            }
            

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}