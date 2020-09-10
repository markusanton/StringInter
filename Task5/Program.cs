using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            var i = Int32.Parse(userInput);

            if (i % 2 == 0)
            {
                Console.WriteLine("The number you entered is even.");
            }
            else
            {
                Console.WriteLine("The number you entered is odd.");
            }
        }
    }
}
