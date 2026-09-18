using System.Net.Mime;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Domain.Abstractions;

/// <summary>
///     Сервис реализации в зависимости от типа.
/// </summary>
public interface IMediaHandler
{
    ContentVideoTypes Types { get; }
    string Handle();
}