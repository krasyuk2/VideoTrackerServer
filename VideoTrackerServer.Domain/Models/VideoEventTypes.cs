using System.Text.Json.Serialization;

namespace VideoTrackerServer.Domain.Models;

/// <summary>
///     Перечисление типов событий с плеером, которые могут прислать
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VideoEventTypes
{
    Play,
    Pause,
    Seeked,
    TimeUpdate
}