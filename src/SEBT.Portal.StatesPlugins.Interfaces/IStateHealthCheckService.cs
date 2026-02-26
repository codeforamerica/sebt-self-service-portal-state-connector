using SEBT.Portal.StatesPlugins.Interfaces.Data;

namespace SEBT.Portal.StatesPlugins.Interfaces;

public interface IStateHealthCheckService : IStatePlugin
{
    Task<HealthCheckResult> CheckHealthAsync(CancellationToken cancellationToken = default);
}
