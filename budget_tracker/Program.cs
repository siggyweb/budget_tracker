using System;
using Microsoft.Extensions.DependencyInjection;

namespace budgetTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        ConfigureServices();
    }

    private static void ConfigureServices()
    {
        var services = new ServiceCollection();
        // register postgresdb service here
        var serviceProvider = services.BuildServiceProvider();
    }
}
