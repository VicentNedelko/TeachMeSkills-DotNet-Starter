using System;

namespace TeachMeSkills.DotNet.Task21
{
    class Program
    {
        static (double res1, double res2, double res3) Calculate(int digit1, int digit2, int digit3)
        {
            (double, double, double) Result = ((double) digit1 / 5.0, (double) digit2 / 5.0, (double) digit3 / 5.0);
            return Result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Digit 1 : ");
            int digit1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Digit 2 : ");
            int digit2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Digit 3 : ");
            int digit3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.WriteLine("Result 1 : {0:00.00}, Result 2 : {1:00.00}, Result 3 : {2:00.00};",
                Calculate(digit1, digit2, digit3).res1, Calculate(digit1, digit2, digit3).res2, Calculate(digit1, digit2, digit3).res3);
        }
    }
}
