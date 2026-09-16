using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Domain.Abstractions;

/// <summary>
///     Сервис, который предоставляет информацию медиа.
/// </summary>
public interface IMediaProviderService
{
    /// <summary>
    ///     Получить названия медиа.
    /// </summary>
    /// <param name="videoInformation"> Информация о медиа. </param>
    /// <returns> Названиме медиа. </returns>
    string GetMediaName(VideoInformation videoInformation);
    
    /// <summary>
    ///     Получить тип медиа.
    /// </summary>
    /// <param name="videoInformation"> Информация о медиа. </param>
    /// <returns> Тип медиа. </returns>
    ContentVideoTypes GetMediaType(VideoInformation videoInformation);
}