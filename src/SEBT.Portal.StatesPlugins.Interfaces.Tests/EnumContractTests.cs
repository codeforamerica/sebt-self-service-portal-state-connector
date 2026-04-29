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
    [InlineData(CardStatus.Unknown, 4)]
    [InlineData(CardStatus.Processed, 5)]
    [InlineData(CardStatus.Lost, 6)]
    [InlineData(CardStatus.Stolen, 7)]
    [InlineData(CardStatus.Damaged, 8)]
    [InlineData(CardStatus.DeactivatedByState, 9)]
    [InlineData(CardStatus.NotActivated, 10)]
    [InlineData(CardStatus.Frozen, 11)]
    [InlineData(CardStatus.Undeliverable, 12)]
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

    [Theory]
    [InlineData(CardReplacementReason.Unspecified, 0)]
    [InlineData(CardReplacementReason.Lost, 1)]
    [InlineData(CardReplacementReason.Stolen, 2)]
    [InlineData(CardReplacementReason.Damaged, 3)]
    [InlineData(CardReplacementReason.Undeliverable, 4)]
    public void CardReplacementReason_has_expected_values(CardReplacementReason value, int expected)
    {
        Assert.Equal(expected, (int)value);
    }
}
