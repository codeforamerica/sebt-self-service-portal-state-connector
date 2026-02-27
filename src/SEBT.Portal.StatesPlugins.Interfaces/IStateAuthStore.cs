using SEBT.Portal.StatesPlugins.Interfaces.Models;

namespace SEBT.Portal.StatesPlugins.Interfaces;

/// <summary>
/// Session-keyed store for state IdP auth context (e.g. after OIDC callback).
/// Implemented by the portal; state plugins that implement <see cref="IStateAuthService"/> use this
/// to read the stored context for the current request's session.
/// </summary>
public interface IStateAuthStore
{
    /// <summary>
    /// Stores the auth context for the given session, with an optional expiration.
    /// </summary>
    /// <param name="sessionId">Session identifier (e.g. from cookie).</param>
    /// <param name="context">The auth context to store.</param>
    /// <param name="expiration">How long the entry is valid.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task SetAsync(
        string sessionId,
        StateAuthContext context,
        TimeSpan expiration,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the auth context for the given session, or null if not found or expired.
    /// </summary>
    /// <param name="sessionId">Session identifier.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The stored context, or null.</returns>
    Task<StateAuthContext?> GetAsync(
        string sessionId,
        CancellationToken cancellationToken = default);
}
