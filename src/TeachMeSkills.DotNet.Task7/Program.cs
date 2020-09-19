using System;

namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter digit : ");
            int digit = Int32.Parse(Console.ReadLine());
            if (digit >= 0 && digit <= 14) Console.WriteLine("Range : [0 - 14]");
            else if (digit >= 15 && digit <= 35)
                Console.WriteLine("Range : [15 - 35]");
            else if (digit >= 36 && digit <= 50)
                Console.WriteLine("Range : [36 - 50]");
            else if (digit >= 51 && digit <= 100)
                Console.WriteLine("Range : [51 - 100]");
            else Console.WriteLine("Digit is out all ranges.");
        }
    }
}
