using System;

namespace TeachMeSkills.DetNet.Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A | B = (A | B)->!(!A & !B)");
            Console.WriteLine("---------------------");
            bool A = false;
            bool B = false;
            Console.WriteLine("0 | 0 = {0} -> {1}", A || B, !(!A && !B));
            B = true;
            Console.WriteLine("0 | 1 = {0} -> {1}", A || B, !(!A && !B));
            A = true;
            B = false;
            Console.WriteLine("1 | 0 = {0} -> {1}", A || B, !(!A && !B));
            B = true;
            Console.WriteLine("1 | 1 = {0} -> {1}", A || B, !(!A && !B));
        }
    }
}
