using Microsoft.AspNetCore.Mvc;

namespace VideoTrackerServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VideoController : ControllerBase
{
    /// <summary>
    ///     Записать коллекцию информации о просмотренном видео
    /// </summary>
    [HttpPost("set-video-information")]
    public Task SetVideoInformation()
    {
        return Task.CompletedTask;
    }
}