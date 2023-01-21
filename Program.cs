using System;

namespace Calculator
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number :   ");  
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :   ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition of two numbers : {0}" , x + y);
            Console.WriteLine("Subtraction of two numbers : {0}  " , x - y);
            Console.WriteLine("Multiplication of two numbers : {0}   " , x * y);
            Console.WriteLine("Division of two numbers :  {0} " , x / y);

        }
    }
}
