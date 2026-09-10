namespace VideoTrackerServer.Domain.Models;

/// <summary>
///     Og информация страницы.
/// </summary>
public class OgProperty
{
    /// <summary>
    ///     Заголовок.
    /// </summary>
    public string? Title { get; set; }
    
    /// <summary>
    ///     Тип информации.
    /// </summary>
    public string? Type { get; set; }
    
    /// <summary>
    ///     Описание.
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    ///     Ссылка на ресурс.
    /// </summary>
    public string? Url { get; set; }
    
    /// <summary>
    ///     Постер.
    /// </summary>
    public string? Image { get; set; }

}