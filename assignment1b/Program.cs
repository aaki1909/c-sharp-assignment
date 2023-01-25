using System;

namespace assignment1b
{
    public class Program
    {
 
        public static void Main(string[] args)
        {
            
            Console.Write("Input the First Number : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            int number2 = int.Parse(Console.ReadLine());

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);

            
        }
    }
}
