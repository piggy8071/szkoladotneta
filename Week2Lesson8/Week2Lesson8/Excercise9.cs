using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise9
    {
        public static void run()
        {
            /*
             * 9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise9");
            Console.WriteLine("--------------\n");

            int number = 0;
            string numberBinary = "";
            Console.WriteLine("Enter a number...");
            Int32.TryParse(Console.ReadLine(), out number);

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    numberBinary = numberBinary + "0";
                }
                else
                {
                    numberBinary = numberBinary + "1";
                }

                number = number / 2;                   
            }

            for (int i = 0; i < numberBinary.Length; i++)
            {
                Console.Write(numberBinary[numberBinary.Length - i - 1]);
            }
              

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}