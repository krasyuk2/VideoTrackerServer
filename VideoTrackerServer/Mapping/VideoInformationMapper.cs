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

    public VideoInformation VideoInformationProcessMapping(VideoInformationRequest videoInformationRequests)
    {
        return new VideoInformation()
        {
            EventType = videoInformationRequests.EventType,
            Time = videoInformationRequests.Time,
            Title = videoInformationRequests.Title,
            Duration = videoInformationRequests.Duration,
            PaybackRate = videoInformationRequests.PaybackRate,
            Poster = videoInformationRequests.Poster,
            PlayerUrl = videoInformationRequests.PlayerUrl,
            WebSiteUrl = videoInformationRequests.WebSiteUrl,
            OgProperty = new OgProperty()
            {
                Title = videoInformationRequests.OgProperty.Title,
                Type = videoInformationRequests.OgProperty.Type,
                Description = videoInformationRequests.OgProperty.Description,
                Url = videoInformationRequests.OgProperty.Url,
                Image = videoInformationRequests.OgProperty.Image,
            },
            IsActiveTab = videoInformationRequests.IsActiveTab,
        };
    }
}