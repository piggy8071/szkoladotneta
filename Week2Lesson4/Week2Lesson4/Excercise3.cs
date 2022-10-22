using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson4
{
    public class Excercise3
    {
        public static void run()
        {
            /*
             * Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. 
             * (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
             * */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise3");
            Console.WriteLine("--------------");

            Console.WriteLine("\nPodaj szerokość i długość prostokąta...");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            double d = Math.Pow((a * a + b * b), 0.5);
            Console.WriteLine($"Przekątna prostokąta wynosi {d}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();



        }
    }
}
