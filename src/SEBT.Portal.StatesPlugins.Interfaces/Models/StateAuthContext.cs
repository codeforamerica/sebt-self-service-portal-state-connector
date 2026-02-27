namespace SEBT.Portal.StatesPlugins.Interfaces.Models;

/// <summary>
/// Authentication context from a state's identity provider.
/// Holds the identity token (JWT), optional access token, and decoded claims for the current session.
/// </summary>
/// <param name="IdToken">Identity token (JWT), e.g. OpenID Connect ID token.</param>
/// <param name="AccessToken">OAuth 2.0 access token (optional; for API calls).</param>
/// <param name="IdTokenClaims">Decoded identity token claims (optional; claims are like email, phone etc.).</param>
public record StateAuthContext(
    string IdToken,
    string? AccessToken = null,
    IReadOnlyDictionary<string, object>? IdTokenClaims = null);
