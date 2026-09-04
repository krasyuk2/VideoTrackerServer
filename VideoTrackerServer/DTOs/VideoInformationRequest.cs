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
    public VideoEventTypes EventType { get; set; }
    
    /// <summary>
    ///     Текущее время, приходит количество секунд - без дробной части
    /// </summary>
    public int Time { get; set; }
    
    /// <summary>
    ///     Заголовок станицы.
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    ///     Продолжительность всего видео.
    /// </summary>
    public int Duration { get; set; }
    
    /// <summary>
    ///     Скорость воспроизведения.
    /// </summary>
    public double PaybackRate { get; set; }
}