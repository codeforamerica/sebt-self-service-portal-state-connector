namespace SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

/// <summary>
/// Request to issue a replacement card for one or more cases in a household.
/// </summary>
public class CardReplacementRequest
{
    /// <summary>The household identifier value (e.g., guardian email) resolved by the portal.</summary>
    public required string HouseholdIdentifierValue { get; init; }

    /// <summary>Case IDs (from <c>SummerEbtCase.SummerEBTCaseID</c>) the replacement applies to.</summary>
    public required IReadOnlyList<string> CaseIds { get; init; }

    /// <summary>Reason for the replacement request. <see cref="CardReplacementReason.Unspecified"/> when the UI does not collect one.</summary>
    public required CardReplacementReason Reason { get; init; }
}
