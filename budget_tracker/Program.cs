﻿using System;
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

        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        
        var dbConfig = new BudgetDatabaseConfig();
        configuration.Bind("ConnectionStrings:BudgetDb", dbConfig);
        builder.Services.AddSingleton(dbConfig);
        
        builder.Services.AddSingleton<BudgetRepository>();
        builder.Services.AddOptions();
        var host = builder.Build();
        host.Run();
    }
}
