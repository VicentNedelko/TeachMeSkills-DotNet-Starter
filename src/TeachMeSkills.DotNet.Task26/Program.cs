using System;

namespace TeachMeSkills.DotNet.Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght : ");
            int n = Int32.Parse(Console.ReadLine());
            Random rand = new Random();
            Console.Write("Enter new element : ");
            int element = Int32.Parse(Console.ReadLine());
            int[] newArray = new int[n + 1];
            int[] sourceArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                sourceArray[i] = rand.Next(100);
            }
            Console.WriteLine();
            Console.WriteLine("SOURCE Array : ");
            PrintArray(sourceArray);
            Console.WriteLine();
            AddNewElement(sourceArray, element, out newArray);
            Console.WriteLine("ARRAY with new element : ");
            PrintArray(newArray);


        }
        private static void AddNewElement(int[] array, int newElement, out int[] newArray)
        {
            int[] outArray = new int[array.Length + 1];
            outArray[0] = newElement;
            for (int i = 1; i < array.Length + 1; i++)
            {
                outArray[i] = array[i - 1];
            }
            newArray = outArray;
        }
        private static void PrintArray(int[] arrayToPrint)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------");
            Console.WriteLine("ARRAY elements : ");
            foreach (int digit in arrayToPrint)
            {
                Console.Write("[{0}]; ", digit);
            }
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
