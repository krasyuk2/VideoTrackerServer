using Microsoft.AspNetCore.Mvc;
using VideoTrackerServer.DTOs;

namespace VideoTrackerServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VideoController : ControllerBase
{
    /// <summary>
    ///     Записать коллекцию информации о просмотренном видео
    /// </summary>
    [HttpPost("set-video-information")]
    public IActionResult SetVideoInformation([FromBody] VideoInformationRequest[] request)
    {   
        return Ok("Маладец 5");
    }
}