using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string UserInput;

            Console.WriteLine("When were you born?");
            UserInput = Console.ReadLine();
            Age = 2020 - Int32.Parse(UserInput);

            if (Age < 18)
            {
                Console.WriteLine($"You are too young for a drivers license, you are {Age}.");
            }
            else
            {
                Console.WriteLine($"You are old enough for a drivers license, you are {Age}.");
            }
        }
    }
}
