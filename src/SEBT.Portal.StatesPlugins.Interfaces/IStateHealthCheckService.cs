using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SEBT.Portal.StatesPlugins.Interfaces;

/// <summary>
/// State plugin that registers health checks for external service connectivity.
/// </summary>
public interface IStateHealthCheckService : IStatePlugin
{
    /// <summary>
    /// Configures health checks for the state's external dependencies.
    /// </summary>
    void ConfigureHealthChecks(IHealthChecksBuilder builder);
}
