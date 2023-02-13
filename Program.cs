using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicsStore;
using Microsoft.AspNetCore.Hosting;

namespace ElectronicsStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
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