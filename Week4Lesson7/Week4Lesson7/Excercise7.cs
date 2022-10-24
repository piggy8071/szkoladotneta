using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise7
    {
        public static void run()
        {
            /*
             * 7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa 
             * Dane testowe: 25 63 79 Rezultat w terminalu : 79 jest największa z podanych
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise7");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter 3 numbers...");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int max = num1 >= num2 ? num1 : num2;
            max = max < num3 ? num3 : max;

            Console.WriteLine($"{max} jest największą z podanych");
           

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}