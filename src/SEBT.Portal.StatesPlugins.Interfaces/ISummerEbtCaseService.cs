using SEBT.Portal.StatesPlugins.Interfaces.Data.Cases;

namespace SEBT.Portal.StatesPlugins.Interfaces;

public interface ISummerEbtCaseService
{
    Task<IList<SummerEbtCase>> GetHouseholdCases();
}