namespace SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

/// <summary>
/// Represents a benefit application with its associated children and card information.
/// </summary>
public class Application
{
    public string? ApplicationNumber { get; set; }
    public string? CaseNumber { get; set; }
    public ApplicationStatus ApplicationStatus { get; set; } = ApplicationStatus.Unknown;
    public DateTime? BenefitIssueDate { get; set; }
    public DateTime? BenefitExpirationDate { get; set; }
    public string? Last4DigitsOfCard { get; set; }
    public CardStatus CardStatus { get; set; } = CardStatus.Requested;
    public DateTime? CardRequestedAt { get; set; }
    public DateTime? CardMailedAt { get; set; }
    public DateTime? CardActivatedAt { get; set; }
    public DateTime? CardDeactivatedAt { get; set; }
    public List<Child> Children { get; set; } = new();
    public int ChildrenOnApplication => Children.Count;
    public IssuanceType IssuanceType { get; set; } = IssuanceType.Unknown;
}
