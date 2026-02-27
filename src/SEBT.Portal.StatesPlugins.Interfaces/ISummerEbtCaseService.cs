using SEBT.Portal.StatesPlugins.Interfaces.Models;
using SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

namespace SEBT.Portal.StatesPlugins.Interfaces;

public interface ISummerEbtCaseService : IStatePlugin
{
    /// <summary>
    /// Retrieves household data for the given guardian email (OTP/authentication email).
    /// </summary>
    /// <param name="guardianEmail">The guardian's email address used for OTP authentication.</param>
    /// <param name="piiVisibility">Which PII elements the caller is allowed to receive. Required; no default.</param>
    /// <param name="identityAssuranceLevel">The IAL the user has achieved; used for backend policy.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Household data, or null if none found.</returns>
    Task<HouseholdData?> GetHouseholdByGuardianEmailAsync(
        string guardianEmail,
        PiiVisibility piiVisibility,
        IdentityAssuranceLevel identityAssuranceLevel,
        CancellationToken cancellationToken = default);
}