using TmbdApi;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations.MediaHandler;

/// <summary>
///     Реализация поиска информации для не определенного типа.
/// </summary>
public class UnrecognizedHandler : IMediaHandler
{
    /// <inheritdoc/>
    public ContentVideoTypes Types => ContentVideoTypes.Unrecognized;
    
    /// <summary>
    ///     Сервис взаимодействия с TMDB.
    /// </summary>
    private readonly ITmdbClient _tmdbClient;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public UnrecognizedHandler(ITmdbClient tmdbClient)
    {
        _tmdbClient = tmdbClient;
    }
    
    /// <inheritdoc/>
    public async Task<MediaContent?> Handle(string query)
    {
       return new MediaContent();
    }
}