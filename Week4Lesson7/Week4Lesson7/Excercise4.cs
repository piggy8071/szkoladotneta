using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise4
    {
        public static void run()
        {
            /*
             * Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym. 
             * Dane testowe : 2016 Rezultat w terminalu : 2016 jest rokiem przestępnym
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise4");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter a year...");
            int year = int.Parse(Console.ReadLine());

            if ( year % 4 == 0 )
            {
                if ( year % 100 == 0 && year % 400 != 0)
                {
                    Console.WriteLine($"{year} nie jest rokiem przestępnym");
                }
                else
                {
                    Console.WriteLine($"{year} jest rokiem przestępnym");
                }
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }








            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}