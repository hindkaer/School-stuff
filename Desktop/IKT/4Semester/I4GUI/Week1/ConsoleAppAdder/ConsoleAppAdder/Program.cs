using System;

namespace ConsoleAppAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            string a = Console.ReadLine();

            Console.WriteLine("Enter 2nd number:");
            string b = Console.ReadLine();

            int valueA = int.Parse(a);
            int valueB = int.Parse(b);

            int c = valueA + valueB;

            Console.WriteLine("The sum of 1 and 2 is {0}.", c);
        }
    }
}
