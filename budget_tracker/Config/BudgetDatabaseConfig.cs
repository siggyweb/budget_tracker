using Microsoft.Extensions.Configuration;

namespace budgetTracker.Config;

public class BudgetDatabaseConfig
{
    public string ConnectionString { get; set; }
}