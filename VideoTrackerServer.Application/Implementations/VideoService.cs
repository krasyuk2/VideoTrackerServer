using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations;

/// <summary>
///     Сервис по обработке полученной информации о видео.
/// </summary>
public class VideoService : IVideoService
{
    /// <inheritdoc/>
    public async Task ProcessVideoInformation(VideoInformation[] videoInformation)
    {
        
    }
}