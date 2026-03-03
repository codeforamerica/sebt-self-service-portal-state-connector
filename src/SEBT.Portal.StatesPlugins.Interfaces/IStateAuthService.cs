using System.Security.Claims;
using SEBT.Portal.StatesPlugins.Interfaces.Models;

namespace SEBT.Portal.StatesPlugins.Interfaces;

/// <summary>
/// Provides IdP-derived claims for the current user. Implemented by states that use an external
/// identity provider (e.g. OIDC). The portal copies non-common IdP claims into the portal JWT at
/// complete-login; callers pass the request's <see cref="ClaimsPrincipal"/> (e.g. HttpContext.User).
/// </summary>
public interface IStateAuthService : IStatePlugin
{
    /// <summary>
    /// Builds a view of IdP claims from the authenticated user's claims (portal JWT includes these at complete-login).
    /// </summary>
    /// <param name="user">The current request's user (e.g. HttpContext.User); null or unauthenticated returns null.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>IdP claims view if the user has IdP claims (e.g. signed in via state IdP); otherwise null.</returns>
    Task<IdpClaimsView?> GetIdpClaimsViewAsync(ClaimsPrincipal? user, CancellationToken cancellationToken = default);
}
