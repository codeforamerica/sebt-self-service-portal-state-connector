namespace SEBT.Portal.StatesPlugins.Interfaces.Data;

/// <summary>
/// Result of a state connector health check. Use pattern matching to inspect:
/// <c>result is HealthCheckResult.Unhealthy { ErrorMessage: var msg }</c>
/// </summary>
public abstract record HealthCheckResult
{
    public abstract bool IsHealthy { get; }

    public sealed record Healthy() : HealthCheckResult
    {
        public override bool IsHealthy => true;
    }

    public sealed record Unhealthy(string ErrorMessage, Exception? Exception = null) : HealthCheckResult
    {
        public override bool IsHealthy => false;
    }
}
