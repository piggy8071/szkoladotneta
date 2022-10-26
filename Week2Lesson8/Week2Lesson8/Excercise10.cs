using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise10
    {
        public static void run()
        {
            /*
             * 10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise10");
            Console.WriteLine("--------------\n");

            int number1, number2;

            Console.WriteLine("Enter a first number...");
            Int32.TryParse(Console.ReadLine(), out number1);
            int number1Copy = number1;
            Console.WriteLine("Enter a second number...");
            Int32.TryParse(Console.ReadLine(), out number2);
            int number2Copy = number2;

            int i = 2;
            int nww = 1;

            while (i <= number1 || i <= number2)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    nww = nww * i;
                    number1 = number1 / i;
                    number2 = number2 / i;
                }
                else if (number1 % i != 0 && number2 % i == 0)
                {
                    nww = nww * i;
                    number2 = number2 / i;
                }
                else if (number1 % i == 0 & number2 % i != 0)
                {
                    nww = nww * i;
                    number1 = number1 / i;
                }

                else
                {
                    i++;
                }
            }

            Console.WriteLine("Najmniejsza wspólna wielokrotność liczb {0} i {1} to {2}", number1Copy, number2Copy, nww);




            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}