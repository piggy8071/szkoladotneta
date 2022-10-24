using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise6
    {
        public static void run()
        {
            /*
             * Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
             * Dane testowe : 140 Rezultat w terminalu : Jesteś krasnoludem
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise6");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter your height...");
            int height = int.Parse(Console.ReadLine());


            if (height < 140)
            {
                Console.WriteLine("Jesteś krasnoludem.");
            }
            else if (height >= 140 && height < 170)
            {
                Console.WriteLine("Istnieją duże szanse, że jesteś Azjatą.");
            }
            else if (height >= 170 && height < 185)
            {
                Console.WriteLine("Witamy w średniej!");
            }
            else
            {
                Console.WriteLine("Nikt Ci nie podskoczy!");
            }

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}