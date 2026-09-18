using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations.MediaHandler;

/// <summary>
///     Реализация поиска информации для не определенного типа.
/// </summary>
public class UnrecognizedHandler : IMediaHandler
{
    /// <inheritdoc/>
    public ContentVideoTypes Types => ContentVideoTypes.Unrecognized;
    
    /// <inheritdoc/>
    public string Handle()
    {
        return "unrecognized";
    }
}