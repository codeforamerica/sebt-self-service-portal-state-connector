using Xunit;
using SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

namespace SEBT.Portal.StatesPlugins.Interfaces.Tests;

/// <summary>
/// Contract tests for enum values. This ensures that the enum values are correct and that 
/// they are not changed unintentionally without updating the tests.
/// </summary>
public class EnumContractTests
{
    [Theory]
    [InlineData(ApplicationStatus.Unknown, 0)]
    [InlineData(ApplicationStatus.Pending, 1)]
    [InlineData(ApplicationStatus.Approved, 2)]
    [InlineData(ApplicationStatus.Denied, 3)]
    [InlineData(ApplicationStatus.UnderReview, 4)]
    [InlineData(ApplicationStatus.Cancelled, 5)]
    public void ApplicationStatus_has_expected_values(ApplicationStatus value, int expected)
    {
        Assert.Equal(expected, (int)value);
    }

    [Theory]
    [InlineData(CardStatus.Requested, 0)]
    [InlineData(CardStatus.Mailed, 1)]
    [InlineData(CardStatus.Active, 2)]
    [InlineData(CardStatus.Deactivated, 3)]
    public void CardStatus_has_expected_values(CardStatus value, int expected)
    {
        Assert.Equal(expected, (int)value);
    }

    [Theory]
    [InlineData(BenefitIssuanceType.Unknown, 0)]
    [InlineData(BenefitIssuanceType.SummerEbt, 1)]
    [InlineData(BenefitIssuanceType.TanfEbtCard, 2)]
    [InlineData(BenefitIssuanceType.SnapEbtCard, 3)]
    public void BenefitIssuanceType_has_expected_values(BenefitIssuanceType value, int expected)
    {
        Assert.Equal(expected, (int)value);
    }

    [Theory]
    [InlineData(IssuanceType.Unknown, 0)]
    [InlineData(IssuanceType.SummerEbt, 1)]
    [InlineData(IssuanceType.TanfEbtCard, 2)]
    [InlineData(IssuanceType.SnapEbtCard, 3)]
    public void IssuanceType_has_expected_values(IssuanceType value, int expected)
    {
        Assert.Equal(expected, (int)value);
    }
}
