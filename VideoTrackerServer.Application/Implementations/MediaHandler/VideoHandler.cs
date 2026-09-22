using TmbdApi;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations.MediaHandler;

/// <summary>
///     Реализация поиска информации для типа видео.
/// </summary>
public class VideoHandler : IMediaHandler
{
    /// <inheritdoc/>
    public ContentVideoTypes Types => ContentVideoTypes.Video;

    /// <summary>
    ///     Сервис взаимодействия с TMDB.
    /// </summary>
    private readonly ITmdbClient _tmdbClient;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public VideoHandler(ITmdbClient tmdbClient)
    {
        _tmdbClient = tmdbClient;
    }
    
    /// <inheritdoc/>
    public string Handle()
    {
        return "video";
    }
}