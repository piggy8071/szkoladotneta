using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lesson7
{
    public class Excercise5
    {
        public static void run()
        {
            /*
             * Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się 
             * o stanowisko posła (21), premiera, sentarora (30), prezydenta (35). 
             * Dane testowe : 21 Rezultat w terminalu : Możesz zostać posłem
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise5");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter your age...");
            int age = int.Parse(Console.ReadLine());

            
            if (age >= 21 && age < 25)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else if (age >= 25 && age < 30)
            {
                Console.WriteLine("Możesz zostać burmistrzem");
            }
            else if (age >= 30 && age < 35)
            {
                Console.WriteLine("Możesz zostać senatorem");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            else
            {
                Console.WriteLine("Musisz jeszcze poczekać...");
            }
            
            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}