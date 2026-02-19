using SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

namespace SEBT.Portal.StatesPlugins.Interfaces.Data.Cases;

/// <summary>
/// Represents a household member/case from the state backend, matching the shape of dbo.HouseholdMemberResult.
/// </summary>
public class SummerEbtCase
{
    public string? SummerEBTCaseID { get; init; }
    public string? ApplicationId { get; init; }
    public string? ApplicationStudentId { get; init; }
    public required string ChildFirstName { get; init; }
    public required string ChildLastName { get; init; }
    public required DateOnly ChildDateOfBirth { get; init; }
    public required string HouseholdType { get; init; }
    public required string EligibilityType { get; init; }
    public DateOnly? ApplicationDate { get; init; }
    public ApplicationStatus ApplicationStatus { get; init; } = ApplicationStatus.Unknown;
    public Address? MailingAddress { get; init; }
    public string? EbtCaseNumber { get; init; }
    public string? EbtCardLastFour { get; init; }
    public string? EbtCardStatus { get; init; }
    public DateOnly? EbtCardIssueDate { get; init; }
    public decimal? EbtCardBalance { get; init; }
    public DateOnly? BenefitAvailableDate { get; init; }
    public DateOnly? BenefitExpirationDate { get; init; }
}
