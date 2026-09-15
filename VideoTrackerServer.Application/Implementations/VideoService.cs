using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations;

/// <summary>
///     Сервис по обработке полученной информации о видео.
/// </summary>
public class VideoService : IVideoService
{
    /// <summary>
    ///     Сервис по сбору информации
    /// </summary>
    private readonly IMediaContentResolverService _mediaContentResolverService;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public VideoService(IMediaContentResolverService mediaContentResolverService)
    {
        _mediaContentResolverService = mediaContentResolverService;
    }
    
    /// <inheritdoc/>
    public List<string> ProcessVideoInformation(VideoInformation[] videoInformation)
    {
        var result = new List<string>();
        foreach (var videoInformationItem in videoInformation)
        {
            var type = _mediaContentResolverService.GetInformationMediaContent(videoInformationItem);
            result.Add(type);
        }
        return result;
    }
}