using System;

namespace assignments1a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100]; //creating an array of size 100
            int i, n, sum = 0;
            Console.Write("Input the number of elements to be stored in the array :");  //number of elemnts in an array
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)         //to print array sequence number & reading the array elements
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)     //adding the elements in the array
            {
                sum = sum + a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }
}

