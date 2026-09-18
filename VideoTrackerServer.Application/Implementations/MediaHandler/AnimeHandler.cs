using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations.MediaHandler;

/// <summary>
///     Реализация поиска информации для типа аниме.
/// </summary>
public class AnimeHandler : IMediaHandler
{
    /// <inheritdoc/>
    public ContentVideoTypes Types => ContentVideoTypes.Anime;
    
    /// <inheritdoc/>
    public string Handle()
    {
        return "amine";
    }
}