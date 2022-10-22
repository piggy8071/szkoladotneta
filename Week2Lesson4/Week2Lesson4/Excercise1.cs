using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson4
{
    public class Excercise1
    {
        public static void run()
        {
            /*
             * 1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
                a. Imię,
                b. Nazwisko
                c. Wiek
                d. Płeć (‘m’ albo ‘k’)
                e. PESEL
                f. Numer pracownika (np. 2509324094)
                Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje 
            */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise1");
            Console.WriteLine("--------------");

            string firstName = "Jan", lastName = "Kowalski", pesel = "1234567890", employeeID = "2509324094";
            int age = 50;
            char gender = 'm';
            
            Console.WriteLine("--------------");
            Console.WriteLine($"FirstName: {firstName} \nLastName:{lastName} \nAge: {age} \nGender: {gender} " +
                $"\nPESEL: {pesel} \nEmplyeeID:{employeeID}");
            Console.WriteLine("--------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
