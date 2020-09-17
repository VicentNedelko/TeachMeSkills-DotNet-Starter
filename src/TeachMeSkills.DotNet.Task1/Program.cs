using System;

namespace TeachMeSkills.DotNet.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size : ");
            int n = Int32.Parse(Console.ReadLine());
            int[] testArray = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                testArray[i] = rand.Next(100);
            }

            PrintArray(testArray);
            Console.WriteLine("MIN value : {0}", GetMinMaxValue(testArray).minValue);
            Console.WriteLine("MAX value : {0}", GetMinMaxValue(testArray).maxValue);
        }

        static void PrintArray (int[] array)
        {
            Console.WriteLine("ARRAY : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int value in array)
            {
                Console.Write("[" + value + "]" + "; ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static (int minValue, int maxValue) GetMinMaxValue (int[] array)
        {
            int minValue = array[0];
            int maxValue = array[0];
            foreach (int value in array)
            {
                if (value < minValue)
                {
                    minValue = value;
                }
                else if (value > maxValue)
                {
                    maxValue = value;
                }
            }
            var result = (minValue, maxValue);
            return result;
        }
    }
}
