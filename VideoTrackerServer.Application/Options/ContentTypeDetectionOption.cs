using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Options;

/// <summary>
///     Настройки для определения типа медиа.
/// </summary>
public class ContentTypeDetectionOption
{
    /// <summary>
    ///     Порог при котором мы можем сказать какой тип.
    /// </summary>
    public double Threshold { get; set; }
    
    /// <summary>
    ///     Источники информации с весами.
    /// </summary>
    public Dictionary<MediaSourceTypes, double> SourceWeights { get; set; } = new Dictionary<MediaSourceTypes, double>();
    
    /// <summary>
    ///     Правила сопоставления.
    /// </summary>
    public List<TypeRuleOption> Rules { get; set; } = new List<TypeRuleOption>();
}