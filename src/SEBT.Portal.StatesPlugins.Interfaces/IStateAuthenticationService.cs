using Swashbuckle.AspNetCore.SwaggerGen;

namespace SEBT.Portal.StatesPlugins.Interfaces;

public interface IStateAuthenticationService
{
    void ConfigureSwaggerGenSecurityOptions(SwaggerGenOptions options);
}