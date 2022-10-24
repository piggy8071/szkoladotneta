using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise1
    {
        public static void run()
        {
            /*
             * 1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie. 
             * Dane testowe: a : 5 b : 5 Rezultat w terminalu : 5 i 5 są równe
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise1");
            Console.WriteLine("--------------\n");

            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} są różne");
            }


            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}