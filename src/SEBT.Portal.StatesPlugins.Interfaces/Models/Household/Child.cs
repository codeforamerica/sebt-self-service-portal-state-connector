namespace SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

/// <summary>
/// Represents a child on a benefit application.
/// </summary>
public class Child
{
    public int? CaseNumber { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
