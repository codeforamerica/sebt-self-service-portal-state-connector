using SEBT.Portal.StatesPlugins.Interfaces.Data.Cases;

namespace SEBT.Portal.StatesPlugins.Interfaces;

public interface ISummerEbtCaseService : IStatePlugin
{
    Task<IList<SummerEbtCase>> GetHouseholdCases();
}