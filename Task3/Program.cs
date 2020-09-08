using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            string UserInput1 = Console.ReadLine();
            var UserInput1v = Int32.Parse(UserInput1);

            Console.WriteLine("Enter number 2: ");
            string UserInput2 = Console.ReadLine();
            var UserInput2v = Int32.Parse(UserInput2);

            if (UserInput1v == UserInput2v)
            {
                Console.WriteLine($"Number 1({UserInput1v}) and Number 2({UserInput2v}) are equal.");
            }
            else
                Console.WriteLine($"Number 1({UserInput1v}) and Number 2({UserInput2v}) are not equal.");
            }

    }
}
