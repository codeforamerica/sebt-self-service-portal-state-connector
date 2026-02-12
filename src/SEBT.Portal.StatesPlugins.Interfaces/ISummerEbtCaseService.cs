using SEBT.Portal.StatesPlugins.Interfaces.Models;
using SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

namespace SEBT.Portal.StatesPlugins.Interfaces;

public interface ISummerEbtCaseService : IStatePlugin
{
    /// <summary>
    /// Retrieves household data for the given guardian email (OTP/authentication email),
    /// including Summer EBT cases for that household.
    /// </summary>
    /// <param name="guardianEmail">The guardian's email address used for OTP authentication.</param>
    /// <param name="piiVisibility">Which PII elements the caller is allowed to receive. Required; no default.</param>
    /// <param name="ial">Identity Assurance Level the user has achieved. Use this (not PiiVisibility) for backend policy such as whether to return address.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Household data with Summer EBT cases, or null if none found.</returns>
    Task<HouseholdData?> GetHouseholdByGuardianEmailAsync(
        string guardianEmail,
        PiiVisibility piiVisibility,
        IdentityAssuranceLevel ial,
        CancellationToken cancellationToken = default);
}