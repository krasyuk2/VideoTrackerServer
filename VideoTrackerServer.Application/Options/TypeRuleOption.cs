using VideoTrackerServer.Domain.Abstractions;

namespace VideoTrackerServer.Application.Options;

public class TypeRuleOption
{
    /// <summary>
    ///     Тип контента к которому относится слово
    /// </summary>
    public ContentVideoTypes Type { get; set; }
    
    /// <summary>
    ///     Ключевое слово сопоставления.
    /// </summary>
    public string KeyWord { get; set; }
    
    /// <summary>
    ///     Вес.
    /// </summary>
    public double Weight { get; set; }
    
    /// <summary>
    ///     Является ли ключевое слово регулярным выражением.
    /// </summary>
    public bool IsRegex { get; set; }
}