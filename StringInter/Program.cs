using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {lastName}");
        }
    }
}
