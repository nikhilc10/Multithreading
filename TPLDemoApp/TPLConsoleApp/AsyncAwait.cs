using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLConsoleApp
{
    public class AsyncAwait
    {
        public async Task<string> GetData()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            int threadId1 = Thread.CurrentThread.ManagedThreadId;

            Task<string> t1 = Task.Factory.StartNew<string>(Data1);
            Task<string> t2 = Task.Factory.StartNew<string>(Data2);
            Task<string> t3 = Task.Factory.StartNew<string>(Data3);
            Task<string> t4 = Task.Factory.StartNew<string>(Data4);

            int finalThreadId1 = Thread.CurrentThread.ManagedThreadId;

            await Task.WaitAll(t1, t2, t3, t4);

            watch.Stop();

            Console.WriteLine("Initial Thread Id is: " + threadId1.ToString());
            Console.WriteLine("Final Thread Id is: " + finalThreadId1.ToString());
            Console.WriteLine(watch.ElapsedMilliseconds);

            Console.ReadLine();
        }

        public string Data1()
        {
            return "This is data1";
        }
        public string Data2()
        {
            return "This is data2";
        }
        public string Data3()
        {
            return "This is data3";
        }
        public string Data4()
        {
            return "This is data4";
        }
    }
}
