using TmbdApi;
using VideoTrackerServer.Application.Implementations.MediaHandler;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations;

/// <summary>
///     Сервис определения типа контента, и получение его информации
/// </summary>
public class MediaContentResolverService : IMediaContentResolverService
{
    /// <summary>
    ///     Сервис парсинга полученной информации о медиа.
    /// </summary>
    private readonly IMediaProviderService _videoProviderService;
    
    /// <summary>
    ///     Выбор реализации в зависимости от типа.
    /// </summary>
    private readonly MediaResolver _mediaResolver;
    
    private readonly ITmdbClient _tmdbClient;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MediaContentResolverService(IMediaProviderService videoProviderService, MediaResolver mediaResolver,
        ITmdbClient tmdbClient)
    {
        _videoProviderService = videoProviderService;
        _mediaResolver = mediaResolver;
        _tmdbClient = tmdbClient;
    }

    /// <inheritdoc/>
    public async Task<string> GetInformationMediaContent(VideoInformation videoInformation)
    {
        var name = _videoProviderService.GetMediaName(videoInformation);
        var type = _videoProviderService.GetMediaType(videoInformation);
        
        var testResolve = _mediaResolver.Resolve(type);
        var test = await _tmdbClient.GetMultiAsync("mentalist");
        
        return $"{name} - {type}";
    }
}

