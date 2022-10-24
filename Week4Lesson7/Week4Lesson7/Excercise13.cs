using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise13
    {
        public static void run()
        {
            /*
             * Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) 
             * I będzie prostym kalkulatorem Podaj pierwszą liczbę: … Podaj drugą liczbę: … 
             * Podaj numer operacji do wykonania:
                1. Dodawanie
                2. Odejmowanie
                3. Mnożenie
                4. Dzielenie
                …
                Twój wynik to:
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise13");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Podaj pierwszą liczbę:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("Podaj numer operacji do wykonania:");
            int operationNumber = int.Parse(Console.ReadLine());
            double result = 0;

            switch (operationNumber)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("The wrong number was entered");
                    break;

            }

            Console.WriteLine($"Twój wynik to: {result}");

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}