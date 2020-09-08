using System;

namespace Week2IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string UserInput;

            Console.WriteLine("How old are you?");
            UserInput = Console.ReadLine();
            Age = Int32.Parse(UserInput);

            if (Age < 18)
            {
                Console.WriteLine($"You are too young, you are {Age}");
            }
            else if (Age > 18)
            {
                Console.WriteLine($"You are old enough, you are {Age}");
            }
            else
            {
                Console.WriteLine($"Congrats! You are {Age}");
            }
        }
    }
}
