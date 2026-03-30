namespace SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

/// <summary>
/// Represents the status of a benefit card.
/// Connectors map raw backend statuses to these values so the portal
/// can render appropriate UI and determine available self-service actions.
/// </summary>
public enum CardStatus
{
    Requested = 0,
    Mailed = 1,
    Active = 2,
    Deactivated = 3,
    Unknown = 4,

    // Card was issued/processed but not yet mailed (DC: "Issued on [date]")
    Processed = 5,

    // Card reported lost by cardholder — eligible for replacement
    Lost = 6,

    // Card reported stolen by cardholder — eligible for replacement
    Stolen = 7,

    // Card reported damaged by cardholder — eligible for replacement
    Damaged = 8,

    // Card deactivated by the state with no reissue allowed
    DeactivatedByState = 9,

    // Card was never activated by the cardholder
    NotActivated = 10,

    // Card temporarily frozen — no transactions allowed
    Frozen = 11,

    // Card could not be delivered to the address on file
    Undeliverable = 12
}
