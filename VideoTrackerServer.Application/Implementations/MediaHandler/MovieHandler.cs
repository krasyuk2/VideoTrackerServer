using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations.MediaHandler;

/// <summary>
///     Реализация поиска информации для типа фильм.
/// </summary>
public class MovieHandler : IMediaHandler
{
    /// <inheritdoc/>
    public ContentVideoTypes Types => ContentVideoTypes.Movie;
    
    /// <inheritdoc/>
    public string Handle()
    {
        return "movie";
    }
}