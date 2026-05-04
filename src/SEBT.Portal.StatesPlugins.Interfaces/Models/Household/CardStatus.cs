using System.Text.Json.Serialization;

namespace SEBT.Portal.StatesPlugins.Interfaces.Models.Household;

/// <summary>
/// Represents the status of a benefit card.
/// Connectors map raw backend statuses to these values so the portal
/// can render appropriate UI and determine available self-service actions.
/// Serialized as the member name (e.g., "Active", "Lost") over the API
/// per JsonStringEnumConverter, so member identifiers are the wire contract.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CardStatus
{
    Active = 0,
    Damaged = 1,
    DeactivatedByState = 2,
    Frozen = 3,
    Lost = 4,
    NotActivated = 5,
    Processed = 6,
    Stolen = 7,
    Undeliverable = 8,
    Unknown = 9
}
