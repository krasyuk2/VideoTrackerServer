using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations.MediaHandler;

/// <summary>
///     Реализация поиска информации для типа сериал.
/// </summary>
public class SerialHandler : IMediaHandler
{
    /// <inheritdoc/>
    public ContentVideoTypes Types => ContentVideoTypes.Serial;
    
    /// <inheritdoc/>
    public string Handle()
    {
        return "serial";
    }
}