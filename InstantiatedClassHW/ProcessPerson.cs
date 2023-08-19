using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassHW
{
    internal class ProcessPerson
    {
        public static void GetPersonName(PersonModel person)
        {
            Console.WriteLine("Welcome, What is your name? ");
            person.Name = Console.ReadLine(); 
        }

        public static void GetPersonGender(PersonModel person)
        {
            Console.WriteLine($"Hello, {person.Name}, enter M if you're male, or F if you're female");
            person.Gender = Console.ReadLine().ToLower();
        }

        public static void GetPersonAge(PersonModel person)
        {
            Console.WriteLine($"Last Question, please enter your age");
            string ageText = Console.ReadLine();

            if(!int.TryParse(ageText, out int age) ) { 
                GetPersonAge(person);
            }
            person.Age = age;
        }

        public static void ConfirmPerson(PersonModel person)
        {
            Console.WriteLine($"We have you confirmed as {person.Name}, gender: {person.Gender}, age: {person.Age}");
        }

        public static void AddNewPerson(PersonModel person)
        {
            GetPersonName(person);
            GetPersonGender(person);
            GetPersonAge(person);
            ConfirmPerson(person);
        }
    }
}
