using System;

namespace TeachMeSkills.DotNet.Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(100);
            }
            Console.WriteLine("Normal array : ");
            foreach(int digit in array)
            {
                Console.Write("[{0}]; ", digit);
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Reversed arrary : ");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write("[{0}]; ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
