using System;
using budgetTracker.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace budgetTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Starting up budget tracking application");
        ConfigureServices(args);
    }

    private static void ConfigureServices(string[] args)
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddSingleton<BudgetRepository>();
        var host = builder.Build();
        host.Run();
    }
}
