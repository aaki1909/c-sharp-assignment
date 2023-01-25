using System;

namespace assignment1c
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, area;     //declaring the variables
            const double PI = 3.14;  

            Console.Write("Enter the radius of circle: ");  //radius of circle
            r = Convert.ToDouble(Console.ReadLine());
            //calculating the area of number
            area = PI * r * r;

            Console.WriteLine("\nThe area of circle is {0} \n when radius is {1}  ", area, r);

            Console.WriteLine("\nThe circumference of circle is {0}  ", 2 * PI * r);    //circumference of circle
        }
    }
}
