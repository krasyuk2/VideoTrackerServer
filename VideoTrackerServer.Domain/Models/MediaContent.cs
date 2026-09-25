namespace VideoTrackerServer.Domain.Models;

public class MediaContent
{
    /// <summary>
    ///     Идентификатор от Api.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Название.
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    ///     Постер.
    /// </summary>
    public string UrlPoster { get; set; }
    
    /// <summary>
    ///     Описание
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    ///     Продолжительность.
    /// </summary>
    public int Duration { get; set; }
    
    /// <summary>
    ///     Дата выхода.
    /// </summary>
    public DateTime ReleaseDate { get; set; }
    
    /// <summary>
    ///     Оценка.
    /// </summary>
    public double Rating { get; set; }
}