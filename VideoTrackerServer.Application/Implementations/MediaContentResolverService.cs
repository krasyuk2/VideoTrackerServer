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
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MediaContentResolverService(IMediaProviderService videoProviderService, MediaResolver mediaResolver)
    {
        _videoProviderService = videoProviderService;
        _mediaResolver = mediaResolver;
    }
    
    /// <summary>
    ///     Собрать информацию о медиа.
    /// </summary>
    /// <param name="videoInformation"> Информация о медиа. </param>
    /// <returns> Обработанные данные о медиа. </returns>
    public string GetInformationMediaContent(VideoInformation videoInformation)
    {
        var name = _videoProviderService.GetMediaName(videoInformation);
        var type = _videoProviderService.GetMediaType(videoInformation);
        
        var testResolve = _mediaResolver.Resolve(type);
        
        return $"{name} - {type}";
    }
}

