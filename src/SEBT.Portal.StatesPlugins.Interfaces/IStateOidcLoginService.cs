using SEBT.Portal.StatesPlugins.Interfaces.Models;

namespace SEBT.Portal.StatesPlugins.Interfaces;

/// <summary>
/// Optional plugin capability: OIDC login for a state (authorization code + PKCE).
/// When a state plugin implements this, the portal exposes GET /api/auth/oidc/{code}/config and
/// POST /api/auth/oidc/{code}/exchange-code for that state. The frontend drives the IdP redirect;
/// the backend exchanges the code and validates the id_token via <see cref="ValidateIdTokenAsync"/>.
/// </summary>
public interface IStateOidcLoginService : IStatePlugin
{
    /// <summary>
    /// Two-letter state code (e.g. "CO") used for route and config lookup.
    /// </summary>
    string StateCode { get; }

    /// <summary>
    /// Prepares the IdP authorization URL and stores pending login server-side.
    /// </summary>
    /// <param name="redirectUri">Callback URL (must be allowed by the IdP client config).</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>URL to redirect the user to, and the state value for the callback.</returns>
    Task<(string AuthorizationUrl, string State)> PrepareAuthorizationAsync(
        string redirectUri,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Exchanges the authorization code for tokens and returns the state auth context.
    /// </summary>
    /// <param name="code">Authorization code from the callback query.</param>
    /// <param name="state">State from the callback query.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Auth context (IdToken, AccessToken, claims) for the authenticated user.</returns>
    Task<StateAuthContext> ExchangeCodeForTokensAsync(
        string code,
        string state,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Validates an ID token (JWT) obtained by the frontend via the Authorization Code + PKCE flow.
    /// Use when the state uses frontend-side PKCE; the frontend sends the id_token to the backend after exchanging the code.
    /// </summary>
    /// <param name="idToken">The identity token (JWT) from the IdP.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Auth context (IdToken, AccessToken, claims) for the authenticated user.</returns>
    Task<StateAuthContext> ValidateIdTokenAsync(
        string idToken,
        CancellationToken cancellationToken = default);
}
