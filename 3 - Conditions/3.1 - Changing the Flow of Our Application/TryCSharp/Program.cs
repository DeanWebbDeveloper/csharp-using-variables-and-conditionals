using System;

namespace TryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            string name = Console.ReadLine();

            Console.WriteLine("How many people are in your band?");
            int numberOfMembers = 0;
            if (!int.TryParse(Console.ReadLine(), out numberOfMembers))
            {
                Console.WriteLine("Input was not valid");
                Environment.Exit(0);
            };

            if (numberOfMembers < 1)
            {
                Console.WriteLine("you must have at least one member");
                Environment.Exit(0);
            }
            else if (numberOfMembers == 1)
            {
                Console.WriteLine(name + " is a solo");
            }
            else if (numberOfMembers == 2)
            {
                Console.WriteLine(name + " is a duo");
            }
            else
            {
                Console.WriteLine(name + " has " + numberOfMembers + " members");
            }
        }
    }
}
