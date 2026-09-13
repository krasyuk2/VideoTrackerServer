using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Domain.Abstractions;

/// <summary>
///     Сервис для работы с полученными данными видео.
/// </summary>
public interface IVideoService
{
    /// <summary>
    ///     Обработка полученной информации о просмотренном видео, странице
    /// </summary>
    /// <param name="videoInformation"> Переданные данные о странице и видео. </param>
    Task ProcessVideoInformation(VideoInformation[] videoInformation);
}