using System;

namespace TeachMeSkills.DotNet.Task19
{
    class Program
    {
        static void GetNumbers(int startDigit, int endDigit)
        {
            for (int i = startDigit; i <= endDigit; i++)
            {
                int devSum = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) { devSum++; }
                }
                if (devSum > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} is a composite number.", i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (devSum == 2 || devSum == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0} is a simple number.", i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Start number : ");
            int start = Int32.Parse(Console.ReadLine());
            Console.Write("Enter End number : ");
            int end = Int32.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            GetNumbers(start, end);
        }
    }
}
