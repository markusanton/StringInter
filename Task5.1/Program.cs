using System;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favourite animal?");
            string UserInput = Console.ReadLine();
           
            if (UserInput == "dog")
            {
                Console.WriteLine("You are a partygoer.");
            }
            else if (UserInput == "cat")
            {
                Console.WriteLine("You are a homebird.");
            }
            else
            {
                Console.WriteLine($"You are a {UserInput} person.");
            }
        }
    }
}
