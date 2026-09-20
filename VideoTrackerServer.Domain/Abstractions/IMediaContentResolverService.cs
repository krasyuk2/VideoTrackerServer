using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Domain.Abstractions;

/// <summary>
///     Сервис определения типа контента, и получение его информации
/// </summary>
public interface IMediaContentResolverService
{
    /// <summary>
    ///     Получить информацию о медиа.
    /// </summary>
    /// <param name="videoInformation"> Информация о видео.</param>
    /// <returns> Информация о медиа. </returns>
    Task<string> GetInformationMediaContent(VideoInformation videoInformation);
}