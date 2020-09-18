using System;

namespace TeachMeSkills.DotNet.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.Write("Enter radius : ");
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("Square = {0:00.00}", (double)(pi * r * r));
        }
    }
}
