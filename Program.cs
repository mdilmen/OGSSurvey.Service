using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;
using System;

namespace OGSSurvey.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
                    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                    .MinimumLevel.Override("System.Net.Http.HttpClient", LogEventLevel.Warning)
                    .WriteTo.File(new RenderedCompactJsonFormatter(), @"c:/temp/logs/OGSSurvey.Service.json")
            .CreateLogger();
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureAppConfiguration(SetupConfiguration)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        private static void SetupConfiguration(HostBuilderContext ctx, IConfigurationBuilder builder)
        {
            //throw new NotImplementedException();
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true);
            builder.AddEnvironmentVariables();
        }
    }
}
