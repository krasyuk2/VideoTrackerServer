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
    ///     Значение которое отдает tmdb;
    /// </summary>
    private const string MEDIA_TYPE = "movie";
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MovieHandler(ITmdbClient tmdbClient)
    {
        _tmdbClient = tmdbClient;
    }
    
    /// <inheritdoc/>
    public async Task<MediaContent?> Handle(string query)
    {
        var tmdbClientResult = await _tmdbClient.GetMultiAsync(query);
        if (tmdbClientResult is null || tmdbClientResult.Results.Length == 0)
            return null;
        var movie = tmdbClientResult.Results
            .Where(m => m.MediaType == MEDIA_TYPE && m.Title!.Length == query.Length)
            .ToList();
        var movieId = movie.First().Id;
        
    }
}