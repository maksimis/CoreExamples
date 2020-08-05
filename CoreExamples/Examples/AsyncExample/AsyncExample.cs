using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreExamples.Examples.AsyncExample
{
    public static class AsyncExample
    {
        static void ReallyHeavyFunction()
        {
            Thread.Sleep(8000);
            Console.WriteLine("ReallyHeavyFunction completed");
        }

        static async void ReallyHeavyFunctionAsync()
        {
            Console.WriteLine("Start ReallyHeavyFunctionAsync");
            await Task.Run(() => ReallyHeavyFunction());
        }
        
        static string ReallyHeavyFunctionWithReturn()
        {
            Console.WriteLine("Start ReallyHeavyFunctionWithReturn");
            Thread.Sleep(16000);
            return "ReallyHeavyFunctionWithReturn completed";
        }
        
        static async Task<string> ReallyHeavyFunctionWithReturnAsync()
        {
            return await Task.Run(() => ReallyHeavyFunctionWithReturn());
        }

        public static async void RunAsуncExample()
        {
            Console.WriteLine("Start RunAsуncExample");
            ReallyHeavyFunctionAsync();
            var x = await ReallyHeavyFunctionWithReturnAsync();
            Console.WriteLine(x);
            Console.WriteLine("Stop RunAsуncExample");
        }
    }
}