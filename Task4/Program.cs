using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            string userInput = Console.ReadLine();
            var Number = Int32.Parse(userInput);

            if (Number > 0)
            {
                Console.WriteLine("The number you entered is positive.");
            }
            else if (Number < 0)
            {
                Console.WriteLine("The number you entered is negative.");
            }
            else
            {
                Console.WriteLine("Please provide a number other than 0.");
            }
        }
    }
}
