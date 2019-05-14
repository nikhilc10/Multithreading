using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLConsoleApp
{
    /// <summary>
    /// Concurrency means executing multiple tasks on different cores. Here multiple worker threads are created and tasks are executed on those threads
    /// </summary>
    public static class Parallelism
    {
        public static void TestFunction()
        {
            Task.Factory.StartNew(Download1);
            Task.Factory.StartNew(Download2);

            Console.WriteLine("Enter your name:");
            var str = Console.ReadLine();
            Console.WriteLine($"Hello {0}", str);
            Console.Read();
        }

        public static void Download1()
        {
            Task.Delay(10000);
            Console.WriteLine("Downloading file1");
        }

        public static void Download2()
        {
            Task.Delay(10000);
            Console.WriteLine("Downloading file2");
        }
    }
}
