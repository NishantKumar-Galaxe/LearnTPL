using System;
using System.Diagnostics;
using System.Threading;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {


            // Example-1 starts here 

            //Process.Start("notepad.exe", "d:\\Hello.txt");

            //var app = new Process
            //{
            //    StartInfo = {
            //        FileName=@"notepad.exe",
            //        Arguments="d:\\Hello.txt"
            //    }
            //};

            //app.Start();
            //app.PriorityClass = ProcessPriorityClass.High;

            //Console.WriteLine("Going to kill process");

            //app.WaitForInputIdle(5000);


            //var allrunningProcesses = Process.GetProcesses();
            //foreach (var process in allrunningProcesses)
            //{
            //    if (process.ProcessName.Equals("notepad"))
            //    {
            //        process.Kill();
            //    }
            //}


            //Console.WriteLine("No more notepad instances at all....");
            //Console.ReadLine();

            // Example-1 Ends here 

            // Example-2 starts here 


            Thread T1 = new Thread(() => Example2.print(true));
            T1.Start();

            Example2.print(false);

            // Example-2 Ends here 


            Console.ReadLine();
        }
    }
}
