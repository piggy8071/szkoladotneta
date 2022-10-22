using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson4
{
    public class Excercise5
    {
        public static void run()
        {

            /*
             * Napisz program w którym poprosisz użytkownika o jego dane personalne 
             * tj. Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85,7), itp 
             * (postaraj się wymyślić jak najwięcej) i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych 
             * używając metody: typDanych.Parse(odpowiedźOdUżytkownika).
             */

            Console.WriteLine("--------------");
            Console.WriteLine("Excercise5");
            Console.WriteLine("--------------");

            string firstName, lastName, phoneNumber, email;
            int age;
            char gender;
            double height, weight;

            Console.WriteLine("\nEnter firstname...");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname... ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter age of the employee... ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose gender ('m' or 'k')");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight... ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height... ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone number... ");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email... ");
            email = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine($"FirstName: {firstName} \nLastName: {lastName} \nAge: {age} \nGender: {gender} " +
                $"\nWeight: {weight} \nHeight: {height} \nPhoneNumber: {phoneNumber} \nEmail: {email}");
            Console.WriteLine("--------------");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }  
    }
}