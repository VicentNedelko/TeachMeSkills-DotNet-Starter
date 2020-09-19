using System;

namespace TeachMeSkills.DotNet.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value : ");
            int value = Int32.Parse(Console.ReadLine());
            int rest = 0;
            while (value > 1 && rest == 0)
            {
                rest = value % 2;
                value /= 2;
            }
            if (rest != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Value is NOT a power of 2");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Value is a power of 2");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
