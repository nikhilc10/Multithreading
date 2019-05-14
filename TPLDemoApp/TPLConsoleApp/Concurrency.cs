using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLConsoleApp
{
    /// <summary>
    /// Concurrency means executing multiple tasks on same core using context switching. Async await does not create worker threads but to make main threaded non-blocking. Only single thread exists in this case
    /// </summary>
    public static class Concurrency
    {
        public static void TestFunction()
        {
            Download1();
            Download2();

            Console.WriteLine("Enter your name:");
            var str = Console.ReadLine();
            Console.WriteLine(str);
            Console.Read();
        }

        public static async void Download1()
        {
            await Task.Delay(10000);
            Console.WriteLine("Downloading file1");
        }

        public static async void Download2()
        {
            await Task.Delay(10000);
            Console.WriteLine("Downloading file2");
        }
    }
}
