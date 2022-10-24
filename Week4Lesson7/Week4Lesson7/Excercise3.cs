using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise3
    {
        public static void run()
        {
            /*
             * 3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna. 
             * Dane testowe : 14 Rezultat w terminalu : 14 jest liczbą dodatnią
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise3");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter a number...");
            int number = int.Parse(Console.ReadLine());

            if (number >=0 )
            {
                Console.WriteLine($"{number} jest liczbą dodatnią");
            }
            else
            {
                Console.WriteLine($"{number} jest liczbą ujemną");
            }

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}