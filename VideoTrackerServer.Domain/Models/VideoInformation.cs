namespace VideoTrackerServer.Domain.Models;

/// <summary>
///     Модель данных видео плеера.
/// </summary>
public class VideoInformation
{
    /// <summary>
    ///     Словарь значений зависимостей событий и времени.
    /// </summary>
    public Dictionary<VideoEventTypes, int[]> VideoEvents { get; set; } = new Dictionary<VideoEventTypes, int[]>();
    
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
    ///     Ссылка веб станицы на которо й плеер.
    /// </summary>
    public string WebSiteUrl { get; set; } = String.Empty;

    /// <summary>
    ///     Основные og теги.
    /// </summary>
    public OgProperty OgProperty { get; set; }
}