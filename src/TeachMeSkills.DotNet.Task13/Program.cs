using System;

namespace TeachMeSkills.DotNet.Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter B : ");
            int b = Int32.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("---------------------------------");
            for (int i = a + 1; i < b; i++)
            {
                sum += i;
                if (i % 2 == 1)
                {
                    Console.Write("{0} ; ", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum : {0}", sum);
        }
    }
}
