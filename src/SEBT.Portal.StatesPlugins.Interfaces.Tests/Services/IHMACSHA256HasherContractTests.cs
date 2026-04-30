using System.Reflection;
using Xunit;
using SEBT.Portal.StatesPlugins.Interfaces.Services;

namespace SEBT.Portal.StatesPlugins.Interfaces.Tests.Services;

public class IHMACSHA256HasherContractTests
{
    [Fact]
    public void Interface_exists_in_Services_namespace()
    {
        var t = typeof(IHMACSHA256Hasher);
        Assert.Equal("SEBT.Portal.StatesPlugins.Interfaces.Services", t.Namespace);
        Assert.True(t.IsInterface);
    }

    [Fact]
    public void Hash_method_takes_string_returns_string()
    {
        var method = typeof(IHMACSHA256Hasher).GetMethod(
            "Hash",
            BindingFlags.Public | BindingFlags.Instance,
            new[] { typeof(string) });

        Assert.NotNull(method);
        Assert.Equal(typeof(string), method!.ReturnType);
    }
}
