using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

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


            //Thread T1 = new Thread(() => Example2.print(true));
            //T1.Start();

            //Example2.print(false);

            // Example-2 Ends here 

            //Thread T2 = new Thread(() => Example2.RunForEver());
            //T2.IsBackground = true;
            //T2.Start();

            // Example-3 starts here 

            //Task
            //Task.Run(() => Example2.PrintTask());
            //Task.Run(() => Example2.PrintTask());

            var cts = new CancellationTokenSource();


            var res = Task.Factory.StartNew(() => Example2.PrintTask(cts.Token), cts.Token);
            var res1 = Task.Factory.StartNew(() => Example2.PrintTask(cts.Token), cts.Token);


            Console.WriteLine($"Result of first task is {res.Result}");
            Console.WriteLine($"Result of second task is {res1.Result}");
          
            // Example-3 Ends here 



            // Example-4 starts here 

            // Example-4 Ends here 


            // Example-5 starts here 

            // Example-5 Ends here 


            // Example-6 starts here 

            // Example-6 Ends here 


            // Example-7 starts here 

            // Example-7 Ends here 


            // Example-8 starts here 

            // Example-8 Ends here 


            Console.Read();
        }
    }
}
