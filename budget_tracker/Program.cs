using System;
using budgetTracker.Config;
using budgetTracker.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace budgetTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Starting up budget tracking application.");
        ConfigureServices(args);
        Console.WriteLine("Exiting application.");
    }

    private static void ConfigureServices(string[] args)
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        builder.Configuration
            .AddJsonFile($"appsettings{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .Build();
        
        var options = new ConnectionStringsOptions();
        builder.Configuration.GetSection("ConnectionStrings").Bind(options); // configure
        
        builder.Services.AddSingleton<BudgetRepository>();
        var host = builder.Build();
        host.Run();
    }
}
