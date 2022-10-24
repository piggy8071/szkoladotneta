using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise2
    {
        public static void run()
        {
            /*
             * Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta. 
             * Dane testowe : 15 Rezultat w terminalu : 15 jest liczbą nieparzystą
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise2");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter a number...");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine($"{number} jest liczbą nieparzystą");
            }
            else
            {
                Console.WriteLine($"{number} jest liczbą parzystą");
            }




            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}