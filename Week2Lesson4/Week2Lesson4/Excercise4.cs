using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson4
{
    public class Excercise4
    {
        public static void run()
        {

            /*
             * Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, 
             * a następnie przypiszesz im następujące wartości:
                a. 10
                b. Szkoła Dotneta
                c. 12,5
                Pamiętaj o użyciu poprawnych typów danych.
            */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise4");
            Console.WriteLine("--------------");

            int firstNumber;
            string firstString;
            double secondNumber;

            firstNumber = 10;
            firstString = "Szkoła Dotneta";
            secondNumber = 12.5;

            Console.WriteLine($"{firstNumber} {firstString} {secondNumber}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();


        }
    }
}