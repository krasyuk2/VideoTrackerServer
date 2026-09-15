using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Domain.Abstractions;

/// <summary>
///     Сервис определения типа контента, и получение его информации
/// </summary>
public interface IMediaContentResolverService
{
    string GetInformationMediaContent(VideoInformation videoInformation);
}