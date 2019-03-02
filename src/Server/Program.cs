using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Database;
using Serilog;


namespace Server
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .Enrich.WithProperty("Application", "GraphDBServer")
                .WriteTo.Console()
                .CreateLogger();

            try
            {
                var host = CreateWebHostBuilder(args).Build();

                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    try
                    {
                        // ensure mr. database is created or we go nowhere.
                        var context = services.GetRequiredService<BuildDBContext>();
                        context.Database.EnsureCreated();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "An error occurred creating the DB.");
                    }
                }

                host.Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectandly");
                return -1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
            
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)                
                .UseSerilog()
                .UseStartup<Startup>()
                .ConfigureKestrel((context, options) => 
                {
                    options.AddServerHeader = false;
                });
    }
}
