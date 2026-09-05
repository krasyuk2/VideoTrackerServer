using System.Text.Json.Serialization;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.DTOs;

/// <summary>
///     Dto получение информации о просмотренном видео.
/// </summary>
public class VideoInformationRequest
{
    /// <summary>
    ///     Событие, которое произошло с плеером.
    /// </summary>
    [JsonPropertyName("type")]
    public VideoEventTypes EventType { get; set; }
    
    /// <summary>
    ///     Текущее время, приходит количество секунд - без дробной части
    /// </summary>
    [JsonPropertyName("time")]
    public int Time { get; set; }
    
    /// <summary>
    ///     Заголовок станицы.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = String.Empty;
    
    /// <summary>
    ///     Продолжительность всего видео.
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
    
    /// <summary>
    ///     Скорость воспроизведения.
    /// </summary>
    [JsonPropertyName("speed")]
    public double PaybackRate { get; set; }
}