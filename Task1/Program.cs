using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string userInputyearOfBirth;
            
            Console.WriteLine("What's your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("When were you born?");
            userInputyearOfBirth = Console.ReadLine();
            int yearOfBirthint;
            yearOfBirthint = Int32.Parse(userInputyearOfBirth);
            int yearofBirthFinal = 2020 - yearOfBirthint;

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {yearofBirthFinal} years old.");
        
        }
    }
}
