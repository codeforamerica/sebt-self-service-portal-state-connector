using SEBT.Portal.StatesPlugins.Interfaces.Models;

namespace SEBT.Portal.StatesPlugins.Interfaces;

/// <summary>
/// Provides the state's auth context (JWT and tokens) for the current request/session.
/// Implemented by states that use an external identity provider; callers can use this to fetch
/// the identity token and optional access token/claims received from that provider.
/// </summary>
public interface IStateAuthService : IStatePlugin
{
    /// <summary>
    /// Fetches the state auth context (identity token JWT, optional access token and claims) when available.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The auth context if the user has authenticated via the state's identity provider; otherwise null.</returns>
    Task<StateAuthContext?> GetStateAuthAsync(CancellationToken cancellationToken = default);
}
