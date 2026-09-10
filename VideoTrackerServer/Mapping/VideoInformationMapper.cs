using VideoTrackerServer.Domain.Models;
using VideoTrackerServer.DTOs;

namespace VideoTrackerServer.Mapping;

/// <summary>
///     Маппинг.
/// </summary>
public class VideoInformationMapper
{
    /// <summary>
    ///     Маппинг дто к модели.
    /// </summary>
    /// <param name="videoInformationRequests"> Дто. </param>
    /// <returns> Модель для бизнес логики. </returns>
    public VideoInformation VideoInformationProcessMapping(VideoInformationRequest[] videoInformationRequests)
    {
        return new VideoInformation();
    }
}