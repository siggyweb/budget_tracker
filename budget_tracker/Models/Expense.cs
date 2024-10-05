using System.ComponentModel.DataAnnotations;

namespace budgetTracker.Models;

public class Expense
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; } = default!;

    public decimal Amount { get; set; }
    
    public DateTime Created { get; set; }
    
    public bool Recurring { get; set; }

    public string? RecurringPeriod { get; set; }
    
    public string? Description { get; set; }

}