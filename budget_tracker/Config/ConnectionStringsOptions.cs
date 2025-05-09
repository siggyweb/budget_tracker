using Microsoft.Extensions.Configuration;

namespace budgetTracker.Config;

public class ConnectionStringsOptions
{
    public string BudgetDb { get; set; }
}