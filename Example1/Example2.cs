using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example1
{
    public static class Example2
    {

        // Thread t1
        public static void print(bool isEven)
        {
            Console.WriteLine($"Current Thread ID is:: {Thread.CurrentThread.ManagedThreadId}");

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

        public static void RunForEver()
        {
            while (true) { Thread.Sleep(1000); }
        }


        public static int PrintTask(CancellationToken token)
        {
            Console.WriteLine($"Is Thread Pool Thread: {Thread.CurrentThread.IsThreadPoolThread}");
            int total = default(int);
            for (int i = 1; i <= 50; i++)
            {
                total = total + i;
                Console.WriteLine($"Current task id={Task.CurrentId}, value is {i}, total is {total}");
            }

            return total;
        }
    }
}
