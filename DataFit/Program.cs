using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataFit.DataBase.Seed;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataFit
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var varHost = CreateWebHostBuilder(args).Build();

            using (var scope = varHost.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                try
                {
                    await DataFitSeedData.EnsureDataFitSeedData(scope.ServiceProvider);
                }
                catch (Exception e)
                {
                }
            }
            varHost.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>();
        
    }
}
