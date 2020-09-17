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
            Console.WriteLine();
            Console.WriteLine("MIN value : {0}", GetMinMaxValue(testArray).minValue);
            Console.WriteLine("MAX value : {0}", GetMinMaxValue(testArray).maxValue);
            Console.WriteLine("SUM value : {0}", GetMinMaxValue(testArray).sum);
            Console.WriteLine(String.Format("AVERAGE value : {0:00.00}", GetMinMaxValue(testArray).average));
            Console.WriteLine();
            Console.WriteLine("Print ODD Numbers : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int number in testArray)
            {
                if (number % 2 != 0)
                {
                    Console.Write("[" + number + "]; ");
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
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

        static (int minValue, int maxValue, int sum, double average) GetMinMaxValue (int[] array)
        {
            int minValue = array[0];
            int maxValue = array[0];
            int sumValue = 0;
            double aver = 0.0;
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
                sumValue += value;
            }
            aver = (double)sumValue / (double)array.Length;
            var result = (minValue, maxValue, sumValue, aver);
            return result;
        }
    }
}
