namespace SEBT.Portal.StatesPlugins.Interfaces.Models;

/// <summary>
/// Read-only view of IdP-derived claims copied into the portal JWT at OIDC complete-login.
/// Plugins that implement <see cref="IStateAuthService"/> build this from the request's
/// <see cref="System.Security.Claims.ClaimsPrincipal"/> (User.Claims).
/// </summary>
/// <param name="Phone">Phone claim from the IdP (e.g. MyColorado), if present.</param>
/// <param name="GivenName">Given name, if present.</param>
/// <param name="FamilyName">Family name, if present.</param>
/// <param name="Email">Email, if present.</param>
/// <param name="Sub">Subject identifier from the IdP, if present.</param>
public record IdpClaimsView(
    string? Phone = null,
    string? GivenName = null,
    string? FamilyName = null,
    string? Email = null,
    string? Sub = null);
