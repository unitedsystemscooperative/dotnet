using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

#pragma warning disable CS8618

namespace UnitedSystemsCooperative.Bot.Models;

[ExcludeFromCodeCoverage]
public class InaraResponse
{
    [JsonPropertyName("header")]
    public InaraResponseHeader Header { get; set; }
    [JsonPropertyName("events")]
    public IEnumerable<InaraResponseEvent> Events { get; set; }
}

[ExcludeFromCodeCoverage]
public class InaraResponseHeader
{
    [JsonPropertyName("eventStatus")]
    public int EventStatus { get; set; }
}

[ExcludeFromCodeCoverage]
public class InaraResponseEvent
{
    [JsonPropertyName("eventStatus")]
    public int EventStatus { get; set; }
    [JsonPropertyName("eventStatusText")]
    public string? EventStatusText { get; set; }
    [JsonPropertyName("eventData")]
    public InaraCmdr EventData { get; set; }
}
