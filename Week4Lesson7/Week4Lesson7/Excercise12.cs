using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise12
    {
        public static void run()
        {
            /*
             * 12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę 
             * Dane testowe : 4
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise12");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter number of a day [1-7]");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("The wrong number was entered");
                    break;


            }
          

            

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}