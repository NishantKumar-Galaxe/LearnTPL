using System;
using System.Diagnostics;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process.Start("notepad.exe", "d:\\Hello.txt");

            var app = new Process
            {
                StartInfo = {
                    FileName=@"notepad.exe",
                    Arguments="d:\\Hello.txt"
                }
            };

            app.Start();
            app.PriorityClass = ProcessPriorityClass.High;

            Console.WriteLine("Going to kill process");

            app.WaitForInputIdle(5000);
         

            var allrunningProcesses = Process.GetProcesses();
            foreach (var process in allrunningProcesses)
            {
                if (process.ProcessName.Equals("notepad"))
                {
                    process.Kill();
                }
            }


            Console.WriteLine("No more notepad instances at all....");
            Console.ReadLine();
        }
    }
}
