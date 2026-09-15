namespace VideoTrackerServer.Domain.Models;

/// <summary>
///     Виды источников информации для анализа.
/// </summary>
public enum MediaSourceTypes
{
    Title,
    OgTitle,
    OgDescription,
    OgUrl,
    PageUrl,
    PlayerUrl
}