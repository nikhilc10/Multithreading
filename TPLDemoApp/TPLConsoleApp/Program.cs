using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concurrency using async/await
            //Concurrency.TestFunction();

            // Parallelism using TPL
            //Parallelism.TestFunction();

            AsyncAwait objAsyncAwait = new AsyncAwait();
            objAsyncAwait.GetData();
        }

        
    }
}
