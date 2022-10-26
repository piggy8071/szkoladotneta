using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise4
    {
        public static void run()
        {
            /*
             * Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej: 
             * 1 2 3 4 5 6 7 8 9 10
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise4");
            Console.WriteLine("--------------\n");

            int currentLevel = 1;
            int numCounter = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(" " +i);
                numCounter++;

                if (currentLevel == numCounter)
                {
                    Console.WriteLine();
                    currentLevel++;
                    numCounter = 0;
                }
            }
            
            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}