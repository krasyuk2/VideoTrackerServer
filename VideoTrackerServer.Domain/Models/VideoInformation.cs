namespace VideoTrackerServer.Domain.Models;

/// <summary>
///     Модель данных видео плеера.
/// </summary>
public class VideoInformation
{
    /// <summary>
    ///     Событие, которое произошло с плеером.
    /// </summary>
    public VideoEventTypes EventType { get; set; }
    
    /// <summary>
    ///     Текущее время, приходит количество секунд - без дробной части
    /// </summary>
    public int[] Time { get; set; } = Array.Empty<int>();
    
    /// <summary>
    ///     Заголовок станицы.
    /// </summary>
    public string Title { get; set; } = String.Empty;
    
    /// <summary>
    ///     Продолжительность всего видео.
    /// </summary>
    public int Duration { get; set; }
    
    /// <summary>
    ///     Скорость воспроизведения.
    /// </summary>
    public double PaybackRate { get; set; }

    /// <summary>
    ///     Обложка в плеере.
    /// </summary>
    public string Poster { get; set; } = string.Empty;

    /// <summary>
    ///     Ссылка плеера.
    /// </summary>
    public string PlayerUrl {get; set;} = String.Empty;
    
    /// <summary>
    ///     Ссылка веб станицы на которой плеер.
    /// </summary>
    public string WebSiteUrl { get; set; } = String.Empty;

    /// <summary>
    ///     Основные og теги.
    /// </summary>
    public OgProperty OgProperty { get; set; }
    
    /// <summary>
    ///     Проверка того что при событии, вкладка была активна
    /// </summary>
    public bool? IsActiveTab { get; set; }
}