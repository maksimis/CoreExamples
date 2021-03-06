using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreExamples.Examples.AsyncExample;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoreExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Uncomment for run AsyncExample
            //AsyncExample.RunAsуncExample();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
