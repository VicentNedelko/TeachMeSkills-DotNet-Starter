using System;

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter operand1 : ");
            double operand1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter operand2 : ");
            double operand2 = Double.Parse(Console.ReadLine());
            Console.Write("Enter operation : ");
            string operation = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Result : {0:0.00} {1} {2:0.00} = {3:0.00}", operand1, operation, operand2, operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine("Result : {0:0.00} {1} {2:0.00} = {3:0.00}", operand1, operation, operand2, operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine("Result : {0:0.00} {1} {2:0.00} = {3:0.00}", operand1, operation, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2 != 0) Console.WriteLine("Result : {0:0.00} {1} {2:0.00} = {3:0.00}", operand1, operation, operand2, operand1 / operand2);
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error! Devision by zero.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error! Wrong operation.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
            }
        }
    }
}
