using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise7
    {
        public static void run()
        {
            /*
             * Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej 
             * o długości wprowadzonej przez użytkownika i wg wzoru:
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise7");
            Console.WriteLine("--------------\n");

            int number = 0;
            Console.WriteLine("Enter a number...");

            Int32.TryParse(Console.ReadLine(), out number);

            int spaceNumber = number/2;
            int starNumber = 1;
            string space = "";
            string star = "";

            for(int i = 0; i < number; i++)
            {
                space = String.Concat(Enumerable.Repeat(" ", spaceNumber));
                star = String.Concat(Enumerable.Repeat("*", starNumber));
                Console.WriteLine(space + star);
                if (i < number / 2)
                {
                    spaceNumber--;
                    starNumber = starNumber + 2;
                }
                else
                {
                    spaceNumber++;
                    starNumber = starNumber - 2;
                }
                
            }    



            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}