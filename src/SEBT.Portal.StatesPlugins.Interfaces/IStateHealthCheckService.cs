using Microsoft.Extensions.DependencyInjection;

namespace SEBT.Portal.StatesPlugins.Interfaces;

/// <summary>
/// Plugin interface for state-specific health checks.
/// Implementations call <see cref="IHealthChecksBuilder.AddCheck"/> to register
/// health checks with ASP.NET Core's health check middleware.
/// </summary>
public interface IStateHealthCheckService : IStatePlugin
{
    void ConfigureHealthChecks(IHealthChecksBuilder builder);
}
