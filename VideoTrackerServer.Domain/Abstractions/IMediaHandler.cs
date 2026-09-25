using System.Net.Mime;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Domain.Abstractions;

/// <summary>
///     Сервис реализации в зависимости от типа.
/// </summary>
public interface IMediaHandler
{
    /// <summary>
    ///     Тип медиа.
    /// </summary>
    ContentVideoTypes Types { get; }
    
    /// <summary>
    ///     Получить филь по имени и типу.
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    Task<MediaContent?> Handle(string query);
}