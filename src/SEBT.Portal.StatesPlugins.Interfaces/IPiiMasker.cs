namespace SEBT.Portal.StatesPlugins.Interfaces;

/// <summary>
/// Contract for masking PII fields so users can recognize their data without
/// exposing full details. Each state connector implements this with
/// state-specific masking rules.
/// </summary>
public interface IPiiMasker
{
    /// <summary>
    /// Masks an email address, preserving enough to be recognizable.
    /// </summary>
    /// <param name="email">The email address to mask.</param>
    /// <returns>The masked email, or null if the input is null or whitespace.</returns>
    string? MaskEmail(string? email);

    /// <summary>
    /// Masks a phone number, preserving enough to be recognizable.
    /// </summary>
    /// <param name="phone">The phone number to mask.</param>
    /// <returns>The masked phone, or null if the input is null or whitespace.</returns>
    string? MaskPhone(string? phone);

    /// <summary>
    /// Masks street address lines.
    /// </summary>
    /// <param name="streetAddress1">The primary street address line.</param>
    /// <param name="streetAddress2">The secondary street address line (apt, suite, etc.).</param>
    /// <returns>A masked street indicator, or null if both lines are null or whitespace.
    /// Callers should log a warning when this returns null — a missing address likely indicates
    /// an upstream data issue that warrants investigation.</returns>
    string? MaskStreetAddress(string? streetAddress1, string? streetAddress2);
}
