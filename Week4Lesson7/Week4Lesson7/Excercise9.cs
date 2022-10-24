using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise9
    {
        public static void run()
        {
            /*
             * 9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach 
             * Temp < 0 – cholernie piździ 
             * Temp 0 – 10 – zimno 
             * Temp 10 – 20 – chłodno 
             * Temp 20 – 30 – w sam raz 
             * Temp 30 – 40 – zaczyna być słabo, bo gorąco
             * Temp >= 40 – a weź wyprowadzam się na Alaskę. 
             * Dane testowe : 41 Rezultat w terminalu : a weź wyprowadzam się na Alaskę.
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise9");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter temperature...");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature < 0 )
            {
                Console.WriteLine("cholernie piździ ");
            }
            else if (temperature >= 0 && temperature < 10  )
            {
                Console.WriteLine("zimno");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else 
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}