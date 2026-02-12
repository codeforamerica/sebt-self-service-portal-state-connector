using SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

namespace SEBT.Portal.StatesPlugins.Interfaces;

public interface ISummerEbtCaseService : IStatePlugin
{
    /// <summary>
    /// Retrieves household data for the given guardian email (OTP/authentication email).
    /// </summary>
    /// <param name="guardianEmail">The guardian's email address used for OTP authentication.</param>
    /// <param name="includeAddress">Whether to include address information (e.g. when ID verification is completed).</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Household data, or null if none found.</returns>
    Task<HouseholdData?> GetHouseholdByGuardianEmailAsync(
        string guardianEmail,
        bool includeAddress = false,
        CancellationToken cancellationToken = default);
}