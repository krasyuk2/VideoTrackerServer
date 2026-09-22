using TmbdApi;
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
    
    /// <summary>
    ///     Сервис взаимодействия с TMDB.
    /// </summary>
    private readonly ITmdbClient _tmdbClient;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public AnimeHandler(ITmdbClient tmdbClient)
    {
        _tmdbClient = tmdbClient;
    }
    
    /// <inheritdoc/>
    public string Handle()
    {
        return "amine";
    }
}