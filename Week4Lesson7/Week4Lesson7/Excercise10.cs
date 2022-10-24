using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise10
    {
        public static void run()
        {
            /*
             * Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt 
             * Dane testowe : 40 55 65 Rezultat w terminalu : Można zbudować trójkąt
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise10");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter lenghts of sides of triangle...");
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            int side3 = int.Parse(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1 )
            {
                Console.WriteLine("Mozna zbudowac trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}