using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise8
    {
        public static void run()
        {
            /*
             * 8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów: 
             * Wynik z Matury z matematyki powyżej 70 Wynik z fizyki powyżej 55 Wynik z chemii powyżej 45 
             * Łączny wynik z 3 przedmiotów powyżej 180 
             * Albo Wynik z matematyki i jednego przedmiotu powyżej 150 Dane testowe: Matematyka 80
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise8");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter math result...");
            int mathResult = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter physics result...");
            int physicsResult = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chemistry result...");
            int chemistryResult = int.Parse(Console.ReadLine());

            if (mathResult > 70 || physicsResult > 55 || chemistryResult > 45 || (mathResult + physicsResult + chemistryResult) > 170
                || (mathResult + physicsResult) > 150 || (mathResult + chemistryResult) > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }



            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}