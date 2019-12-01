using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Example1
{
    public static class Example2
    {

        // Thread t1
        public static void print(bool isEven)
        {
            if (isEven)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Even Number {i}");
                    }
                }
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"Odd Number {i}");
                    }
                }
            }
        }
    }
}
