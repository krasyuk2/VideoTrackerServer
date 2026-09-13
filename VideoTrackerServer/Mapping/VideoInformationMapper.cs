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
    public VideoInformation[] VideoInformationProcessMapping(VideoInformationRequest[] videoInformationRequests)
    {
        return videoInformationRequests.Select(x => new VideoInformation()
        {
            EventType = x.EventType,
            Time = x.Time,
            Title =  x.Title,
            Duration = x.Duration,
            PaybackRate =  x.PaybackRate,
            Poster = x.Poster,
            PlayerUrl =  x.PlayerUrl,
            WebSiteUrl =  x.WebSiteUrl,
            OgProperty = new OgProperty()
            {
                Title = x.OgProperty.Title,
                Type = x.OgProperty.Type,
                Description = x.OgProperty.Description,
                Url = x.OgProperty.Url,
                Image =  x.OgProperty.Image,
            },
            IsActiveTab = x.IsActiveTab,
        }).ToArray(); }
}