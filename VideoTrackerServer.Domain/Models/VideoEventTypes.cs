namespace VideoTrackerServer.Domain.Models;

/// <summary>
///     Перечисление типов событий с плеером, которые могут прислать
/// </summary>
public enum VideoEventTypes
{
    Play,
    Pause,
    Seeked,
    TimeUpdate
}