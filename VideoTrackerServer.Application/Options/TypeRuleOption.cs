using VideoTrackerServer.Domain.Abstractions;

namespace VideoTrackerServer.Application.Options;

/// <summary>
///     Настройки ключевых слов для поиска.
/// </summary>
public class TypeRuleOption
{
    /// <summary>
    ///     Тип к которому отновится слово поиска.
    /// </summary>
    public ContentVideoTypes Type { get; set; }
    
    /// <summary>
    ///     Слово сопоставления.
    /// </summary>
    public string KeyWord { get; set; }
    
    /// <summary>
    ///     Вес.
    /// </summary>
    public double Weight { get; set; }
    
    /// <summary>
    ///     Регулярное ли выражение слово сопоставления.
    /// </summary>
    public bool IsRegex { get; set; }
}