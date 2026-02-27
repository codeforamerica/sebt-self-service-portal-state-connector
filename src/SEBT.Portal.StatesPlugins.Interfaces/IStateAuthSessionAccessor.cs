namespace SEBT.Portal.StatesPlugins.Interfaces;

using SEBT.Portal.StatesPlugins.Interfaces.Models;

/// <summary>
/// Provides the current request's state auth session id (e.g. from cookie).
/// Implemented by the portal; state plugins that implement <see cref="IStateAuthService"/> use this
/// to look up the stored <see cref="StateAuthContext"/> in <see cref="IStateAuthStore"/>.
/// </summary>
public interface IStateAuthSessionAccessor
{
    /// <summary>
    /// Gets the state auth session id for the current request, or null if none (e.g. no cookie).
    /// </summary>
    string? GetCurrentSessionId();
}
