using Microsoft.AspNetCore.Mvc;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.DTOs;
using VideoTrackerServer.Mapping;

namespace VideoTrackerServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MediaInformationController : ControllerBase
{
    /// <summary>
    ///     Сервис парсинга полученной информации.
    /// </summary>
    private readonly IMediaProviderService _videoProviderService;
    
    /// <summary>
    ///     Маппинг.
    /// </summary>
    private readonly VideoInformationMapper _videoInformationMapper;
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MediaInformationController(IMediaProviderService videoProviderService)
    {
        _videoProviderService = videoProviderService;
    }

    /// <summary>
    ///     Получить название из предложенной информации.
    /// </summary>
    /// <param name="videoInformationRequest"> Информация о видео. </param>
    /// <returns> Название. </returns>
    [HttpPost("name")]
    public string GetMediaName(VideoInformationRequest videoInformationRequest)
    {
        var videoInformation = _videoInformationMapper.VideoInformationProcessMapping(videoInformationRequest);
        return _videoProviderService.GetMediaName(videoInformation);
    }

    /// <summary>
    ///     Получить тип из предложенной информации.
    /// </summary>
    /// <param name="videoInformationRequest"> Информация о видео. </param>
    /// <returns> Тип. </returns>
    [HttpPost("type")]
    public string GetMediaType(VideoInformationRequest videoInformationRequest)
    {
        var videoInformation = _videoInformationMapper.VideoInformationProcessMapping(videoInformationRequest);
        return _videoProviderService.GetMediaType(videoInformation).ToString();
    }
}