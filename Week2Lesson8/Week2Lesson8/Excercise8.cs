using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Excercise8
    {
        public static void run()
        {
            /*
             * 8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
                Testowe dane:
                Abcdefg
                Rezultat
                Gfedcba
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise8");
            Console.WriteLine("--------------\n");

            Console.WriteLine("Enter a word...");

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[word.Length - i - 1]);
            }

            Console.WriteLine("\n--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}