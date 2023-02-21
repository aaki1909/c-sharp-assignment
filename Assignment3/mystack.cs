using System;
using System.Collections.Generic;


namespace Assignment3
{
    internal class MyStack
    {
        int size = 10;
        int[] numArray = new int[10];
        int top = -1;

        public void Push(int value)
        {
            numArray[top] = value;
            top++;
        }

        public int Pop()
        {
            top--;
            return numArray[top + 1];
        }


    }
}
