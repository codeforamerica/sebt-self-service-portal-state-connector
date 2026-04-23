using SEBT.Portal.StatesPlugins.Interfaces.Models;
using SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

namespace SEBT.Portal.StatesPlugins.Interfaces;

public interface ISummerEbtCaseService : IStatePlugin
{
    /// <summary>
    /// Retrieves household data by identifier type and value (e.g. phone from JWT, email from OTP).
    /// Preferred entry point for state lookups; supports CO phone-from-claims without persisting PII.
    /// </summary>
    /// <param name="identifierType">Type of identifier (e.g. Email, Phone).</param>
    /// <param name="identifierValue">Normalized value (e.g. email or phone number).</param>
    /// <param name="piiVisibility">Which PII elements the caller is allowed to receive.</param>
    /// <param name="identityAssuranceLevel">The IAL the user has achieved.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Household data with Summer EBT cases, or null if none found or type not supported.</returns>
    Task<HouseholdData?> GetHouseholdByIdentifierAsync(
        HouseholdIdentifierType identifierType,
        string identifierValue,
        PiiVisibility piiVisibility,
        IdentityAssuranceLevel identityAssuranceLevel,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves household data for the given guardian email (OTP/authentication email).
    /// Convenience for email-only lookups; implementations may delegate to <see cref="GetHouseholdByIdentifierAsync"/>.
    /// </summary>
    /// <param name="guardianEmail">The guardian's email address used for OTP authentication.</param>
    /// <param name="piiVisibility">Which PII elements the caller is allowed to receive. Required; no default.</param>
    /// <param name="identityAssuranceLevel">The IAL the user has achieved; used for backend policy such as whether to return address.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Household data with Summer EBT cases, or null if none found.</returns>
    Task<HouseholdData?> GetHouseholdByGuardianEmailAsync(
        string guardianEmail,
        PiiVisibility piiVisibility,
        IdentityAssuranceLevel identityAssuranceLevel,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// For co-loaded ID proofing with SNAP/TANF: attempts to match the submitted benefit identifier
    /// (mapped to the state warehouse <c>IC</c> field) and the guardian's date of birth against
    /// state data. Only the DC plugin implements this (e.g. <c>GetHouseholdByGuardian</c> with JSON
    /// <c>{"IC":...,"DOB":...}</c>); other states should return <c>false</c>.
    /// </summary>
    /// <param name="benefitIdentifierIc">The SNAP/TANF identifier value from onboarding (IC equivalent).</param>
    /// <param name="guardianDateOfBirth">Guardian DOB from the ID proofing form.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns><c>true</c> when the state warehouse reports at least one matching household case row (DC only).</returns>
    Task<bool> TryMatchCoLoadedGuardianByBenefitIdAndDobAsync(
        string benefitIdentifierIc,
        DateOnly guardianDateOfBirth,
        CancellationToken cancellationToken = default);
}