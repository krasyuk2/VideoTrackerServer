using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations.MediaHandler;

/// <summary>
///     Резолвер.
/// </summary>
public class MediaResolver
{
    /// <summary>
    ///     Словарь тип - реализация.
    /// </summary>  
    private readonly Dictionary<ContentVideoTypes, IMediaHandler> _mediaHandlers;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MediaResolver(IEnumerable<IMediaHandler> mediaHandlers)
    {
        _mediaHandlers = mediaHandlers.ToDictionary(x => x.Types);
    }

    /// <summary>
    ///     Выполнение реализации в зависимости от типа.
    /// </summary>
    /// <param name="type"> Тип контента. </param>
    /// <returns> Информация о видео. </returns>
    public string Resolve(ContentVideoTypes type) => _mediaHandlers[type].Handle();
}