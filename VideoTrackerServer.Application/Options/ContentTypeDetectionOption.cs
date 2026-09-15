namespace VideoTrackerServer.Application.Options;

/// <summary>
///     Настройки обнаружение типа медиа.
/// </summary>
public class ContentTypeDetectionOption
{
    /// <summary>
    ///     Правила сопоставления.
    /// </summary>
    public TypeRuleOption[] Rules { get; set; }
}