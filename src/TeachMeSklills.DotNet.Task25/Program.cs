using System;

namespace TeachMeSklills.DotNet.Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size : ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] outArray = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++) //TODO: feel array with RAND value
            {
                array[i] = rand.Next(100);
            }
            Console.WriteLine("SOURCE Array : ");
            PrintArray(array);
            MyReverse(array, out outArray);
            Console.WriteLine();
            Console.WriteLine("REVERSED Array : ");
            PrintArray(outArray);

        }
        private static void PrintArray (int[] arrayToPrint)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ARRAY elements : ");
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int value in arrayToPrint)
            {
                Console.Write("[{0}]; ", value);
            }
            Console.WriteLine();
        }
        private static void MyReverse (int[] sourceArray, out int[] outArray)
        {
            int[] tempArray = new int[sourceArray.Length];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                tempArray[sourceArray.Length - 1 - i] = sourceArray[i];
            }
            outArray = tempArray;
        }
    }
}
