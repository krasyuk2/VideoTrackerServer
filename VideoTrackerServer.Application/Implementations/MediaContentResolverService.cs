using System.Text.RegularExpressions;
using Microsoft.Extensions.Options;
using VideoTrackerServer.Application.Options;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations;

/// <summary>
///     Сервис определения типа контента, и получение его информации
/// </summary>
public class MediaContentResolverService : IMediaContentResolverService
{
    /// <summary>
    ///     Конфиги поиска по типу.
    /// </summary>
    private readonly ContentTypeDetectionOption _typeDetectionOption;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MediaContentResolverService(IOptions<ContentTypeDetectionOption> typeDetectionOption)
    {
        _typeDetectionOption = typeDetectionOption.Value;
    }

    public string GetInformationMediaContent(VideoInformation videoInformation)
    {
        return GetContentTypeMedia(videoInformation).ToString();
    }
    
    /// <summary>
    ///     Получить название медиа.
    /// </summary>
    /// <param name="videoInformation"> Информация о медиа. </param>
    /// <returns> Название медиа. </returns>
    private string GetNameMedia(VideoInformation videoInformation)
    {
        return "";
    }

    /// <summary>
    ///     Получить тип медиа.
    /// </summary>
    /// <param name="videoInformation"> Информация о медиа. </param>
    /// <returns> Тип медиа. </returns>
    private ContentVideoTypes GetContentTypeMedia(VideoInformation videoInformation)
    {
        var score = new Dictionary<ContentVideoTypes, double>();
        foreach (var (type, text) in EnumerateMediaSources(videoInformation))
        {
            if(!_typeDetectionOption.SourceWeights.TryGetValue(type, out var weight))
                continue;
            if(string.IsNullOrEmpty(text)) continue;
            foreach (var rule in _typeDetectionOption.Rules)
            {
                if (rule.IsRegex)
                {
                    var regex = new Regex(rule.KeyWord);
                    var match = regex.Matches(text);
                    if (match.Count > 0)
                        score.TryAdd(rule.Type, weight);
                }
                if(text.Contains(rule.KeyWord))
                    score.TryAdd(rule.Type, weight);
            }
        }
        var sum = score.Sum(x => x.Value);
        if(sum <= 0)
            return ContentVideoTypes.Unrecognized;
        
        var best = score.MaxBy(x => x.Value);
        return best.Value >= _typeDetectionOption.Threshold ? best.Key : ContentVideoTypes.Unrecognized;
    }

    private IEnumerable<(MediaSourceTypes Type, string? Text)> EnumerateMediaSources(VideoInformation videoInformation)
    {
        yield return (MediaSourceTypes.Title, videoInformation.Title);
        yield return (MediaSourceTypes.OgUrl, videoInformation.OgProperty.Url);
        yield return (MediaSourceTypes.OgTitle, videoInformation.OgProperty.Title);
        yield return (MediaSourceTypes.OgDescription, videoInformation.OgProperty.Description);
        yield return (MediaSourceTypes.OgUrl, videoInformation.OgProperty.Url);
        yield return (MediaSourceTypes.PageUrl, videoInformation.WebSiteUrl);
        yield return (MediaSourceTypes.PlayerUrl, videoInformation.PlayerUrl);
    }
}

