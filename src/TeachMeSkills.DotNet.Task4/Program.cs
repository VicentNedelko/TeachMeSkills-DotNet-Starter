using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius : ");
            double radius = Double.Parse(Console.ReadLine());
            Console.Write("Enter Height : ");
            double height = Double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Volume : {0:000.00}", Math.PI * radius * radius * height);
            Console.WriteLine("Square : {0:000.00}", 2 * Math.PI * radius * (radius + height));
        }
    }
}
