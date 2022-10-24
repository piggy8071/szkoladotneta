using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise11
    {
        public static void run()
        {
            /*
             * Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
             * Dane testowe : 3 Rezultat w terminalu : Dostateczny
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise11");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter number of a grade [1-6]");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
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