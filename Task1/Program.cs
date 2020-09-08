using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string UserInput;
            
            Console.WriteLine("What's your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("When were you born?");
            UserInput = Console.ReadLine();
            int Age = 2020 - Int32.Parse(UserInput);

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {Age} years old.");
        
        }
    }
}
