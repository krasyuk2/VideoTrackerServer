using TmbdApi;
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
    
    /// <summary>
    ///     Сервис взаимодействия с TMDB.
    /// </summary>
    private readonly ITmdbClient _tmdbClient;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MovieHandler(ITmdbClient tmdbClient)
    {
        _tmdbClient = tmdbClient;
    }
    
    /// <inheritdoc/>
    public string Handle()
    {
        return "movie";
    }
}