using Microsoft.AspNetCore.Mvc;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.DTOs;
using VideoTrackerServer.Mapping;

namespace VideoTrackerServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VideoController : ControllerBase
{
    /// <summary>
    ///     Сервис по обработке видео.
    /// </summary>
    private readonly IVideoService _videoService;
    
    /// <summary>
    ///     Маппинг.
    /// </summary>
    private readonly VideoInformationMapper _videoInformationMapper;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public VideoController(IVideoService videoService, VideoInformationMapper videoInformationMapper)
    {
        _videoService = videoService;
        _videoInformationMapper = videoInformationMapper;
    }
    
    /// <summary>
    ///     Записать коллекцию информации о просмотренном видео
    /// </summary>
    [HttpPost("set-video-information")]
    public async Task<List<string>> ProcessVideoInformation([FromBody] VideoInformationRequest[] request)
    {
        var videoInformationModel = _videoInformationMapper.VideoInformationProcessMapping(request);
        var  result= await _videoService.ProcessVideoInformation(videoInformationModel);
        return result;
    }
}